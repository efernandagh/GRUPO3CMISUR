
using Microsoft.Data.SqlClient;
namespace INICIO
{
    public partial class frmPagos : Form
    {
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";

        public frmPagos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }






        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números, punto decimal, y teclas de control
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.' && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && txtMonto.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtPago.Clear();
            txtFactura.Clear();
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;

            // Poner el foco en el primer campo
            txtPago.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pagos_Load(object sender, EventArgs e)
        {
            // Configurar el DateTimePicker
            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy";

            // Llenar el ComboBox de ESTADO
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("Pagado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;

            // Configurar campos de texto
            txtPago.MaxLength = 10;
            txtFactura.MaxLength = 20;
            txtMonto.MaxLength = 15;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Preguntar si está seguro de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            string idPago = txtPago.Text.Trim();
            string idFactura = txtFactura.Text.Trim();
            string montoTexto = txtMonto.Text.Trim();
            string estado = cboEstado.Text.Trim();
            DateTime fecha = dtpFecha.Value;

            // 🔹 Validar campos vacíos
            if (string.IsNullOrWhiteSpace(idPago))
            {
                MessageBox.Show("Por favor ingrese el número de PAGO", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(idFactura))
            {
                MessageBox.Show("Por favor ingrese el número de FACTURA", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(montoTexto))
            {
                MessageBox.Show("Por favor ingrese el MONTO", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Por favor seleccione el ESTADO", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboEstado.Focus();
                return;
            }

            // 🔹 Validar que el monto sea un número válido
            if (!decimal.TryParse(montoTexto, out decimal monto))
            {
                MessageBox.Show("El MONTO debe ser un número válido", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;
            }

            // 🔹 Insertar en la base de datos
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO PAGOS (ID_PAGO, ID_FACTURA, FECHA_PAGO, MONTO_PAGO, ESTADO_PAGO) " +
                                   "VALUES (@idpago, @idfactura, @fecha, @monto, @estado)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idpago", Convert.ToInt32(idPago));
                    cmd.Parameters.AddWithValue("@idfactura", Convert.ToInt32(idFactura));
                    cmd.Parameters.AddWithValue("@fecha", fecha);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@estado", estado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Pago guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Limpiar campos al guardar
                    txtPago.Clear();
                    txtFactura.Clear();
                    txtMonto.Clear();
                    dtpFecha.Value = DateTime.Now;
                    cboEstado.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }

            }
        }
    }

}
