
using Microsoft.Data.SqlClient;
namespace INICIO
{
    public partial class frmPagos : Form
    {
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";
        private int idFacturaSeleccionada; // 🔹 Guardará el ID que viene desde facturas

        public frmPagos(int txtidfactura)
        {
            InitializeComponent();
            idFacturaSeleccionada = txtidfactura;
        }

        public frmPagos()
        {
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
            cmbidfaactura.SelectedIndex = 0;
            txtMonto.Clear();
            dtpFecha.Value = DateTime.Now;
            cboEstado.SelectedIndex = 0;

            // Poner el foco en el primer campo
            txtPago.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pagos_Load(object sender, EventArgs e)
        {

            dtpFecha.Format = DateTimePickerFormat.Custom;
            dtpFecha.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy";

            // 🔹 Cargar estados
            cboEstado.Items.Clear();
            cboEstado.Items.Add("Pendiente");
            cboEstado.Items.Add("Pagado");
            cboEstado.Items.Add("Cancelado");
            cboEstado.SelectedIndex = 0;

            // 🔹 Cargar facturas en ComboBox
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    string query = "SELECT ID_FACTURA FROM FACTURAS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cmbidfaactura.Items.Clear();

                    while (reader.Read())
                    {
                        cmbidfaactura.Items.Add(reader["ID_FACTURA"].ToString());
                    }
                    reader.Close();
                }

                // 🔹 Si el formulario fue abierto desde facturas, seleccionar ese ID
                if (idFacturaSeleccionada > 0)
                {
                    cmbidfaactura.SelectedItem = idFacturaSeleccionada.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar facturas: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPago.Text) || cmbidfaactura.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMonto.Text) || cboEstado.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Por favor completa todos los campos.", "Advertencia");
                return;
            }

            if (!decimal.TryParse(txtMonto.Text, out decimal monto))
            {
                MessageBox.Show("⚠️ El monto debe ser numérico.", "Advertencia");
                return;
            }

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO PAGOS (ID_PAGO, ID_FACTURA, FECHA_PAGO, MONTO_PAGO, ESTADO_PAGO) " +
                                   "VALUES (@idpago, @idfactura, @fecha, @monto, @estado)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idpago", Convert.ToInt32(txtPago.Text));
                    cmd.Parameters.AddWithValue("@idfactura", Convert.ToInt32(cmbidfaactura.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", monto);
                    cmd.Parameters.AddWithValue("@estado", cboEstado.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Pago guardado correctamente.", "Éxito");

                    // Limpiar
                    txtPago.Clear();
                    txtMonto.Clear();
                    cmbidfaactura.SelectedIndex = -1;
                    cboEstado.SelectedIndex = 0;
                    dtpFecha.Value = DateTime.Now;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }
            }
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






        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }

    }

