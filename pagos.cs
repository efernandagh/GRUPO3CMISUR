using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class pagos : Form
    {
        public pagos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtMonto.Text))
            {
                MessageBox.Show("Por favor ingrese el monto del pago", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtEstado.Text))
            {
                MessageBox.Show("Por favor ingrese el estado del pago", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEstado.Focus();
                return;
            }

            // Validar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMonto.Text, out monto))
            {
                MessageBox.Show("El monto debe ser un número válido", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            // Validar que el monto sea positivo
            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMonto.Focus();
                return;
            }

            // Guardar los datos
            string mensaje = $"Pago registrado exitosamente:\n\n" +
                           $"Fecha: {dtpFecha.Value.ToLongDateString()}\n" +
                           $"Monto: ${monto:N2}\n" +
                           $"Estado: {txtEstado.Text}";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos
            dtpFecha.Value = DateTime.Now;
            txtMonto.Clear();
            txtEstado.Clear();
            txtMonto.Focus();
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto decimal, backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
    }
}
