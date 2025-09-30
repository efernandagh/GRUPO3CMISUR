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
    public partial class facturas : Form
    {
        public facturas()
        {
            InitializeComponent();
        }

        private void facturas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(txtContrato.Text))
            {
                MessageBox.Show("Por favor ingrese el número de contrato", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtContrato.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                MessageBox.Show("Por favor ingrese el monto total", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMetodoPago.Text))
            {
                MessageBox.Show("Por favor ingrese el método de pago", "Campo requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMetodoPago.Focus();
                return;
            }

            // Validar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMontoTotal.Text, out monto))
            {
                MessageBox.Show("El monto total debe ser un número válido", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                return;
            }

            // Guardar los datos
            string mensaje = $"Factura guardada exitosamente:\n\n" +
                           $"Contrato: {txtContrato.Text}\n" +
                           $"Fecha: {dtpFecha.Value.ToLongDateString()}\n" +
                           $"Monto Total: ${monto:N2}\n" +
                           $"Método de Pago: {txtMetodoPago.Text}";

            MessageBox.Show(mensaje, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar los campos
            txtContrato.Clear();
            dtpFecha.Value = DateTime.Now;
            txtMontoTotal.Clear();
            txtMetodoPago.Clear();
            txtContrato.Focus();
        }
    }
}
