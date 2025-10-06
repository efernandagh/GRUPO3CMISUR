namespace INICIO
{
    public partial class frmPagos : Form
    {
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
            // Validar que todos los campos estén llenos
            if (string.IsNullOrWhiteSpace(txtPago.Text))
            {
                MessageBox.Show("Por favor ingrese el número de PAGO", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPago.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtFactura.Text))
            {
                MessageBox.Show("Por favor ingrese el número de FACTURA", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFactura.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor ingrese el MONTO", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            // Validar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("El MONTO debe ser un número válido", "Error de validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMonto.Focus();
                return;
            }

            // Si todo es válido, mostrar mensaje de éxito
            string mensaje = string.Format(
                "Pago guardado exitosamente:\n\n" +
                "Pago: {0}\n" +
                "Factura: {1}\n" +
                "Fecha: {2}\n" +
                "Monto: {3:C2}\n" +
                "Estado: {4}",
                txtPago.Text, txtFactura.Text, dtpFecha.Value.ToLongDateString(),
                monto, cboEstado.SelectedItem.ToString());

            MessageBox.Show(mensaje, "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
