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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Limpiar ComboBox de Contrato
            cmbContrato.SelectedIndex = -1;

            // Establecer fecha actual
            dtpFecha.Value = DateTime.Now;

            // Limpiar campo de monto
            txtMontoTotal.Clear();

            // Limpiar ComboBox de Método de Pago
            cmbMetodoPago.SelectedIndex = -1;

            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Poner el foco en el primer campo
            cmbContrato.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            // Preguntar si realmente quiere salir
            DialogResult resultado = MessageBox.Show(
                "¿Está seguro que desea salir del sistema de facturas?",
                "Confirmar Salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            // Si el usuario presiona "Sí", cerrar el formulario
            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // VALIDACIÓN 1: Verificar que se haya seleccionado un tipo de contrato
            if (cmbContrato.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un tipo de contrato",
                    "Campo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbContrato.Focus();
                return;
            }

            // VALIDACIÓN 2: Verificar que se haya ingresado un monto
            if (string.IsNullOrWhiteSpace(txtMontoTotal.Text))
            {
                MessageBox.Show("Por favor ingrese el monto total",
                    "Campo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                return;
            }

            // VALIDACIÓN 3: Verificar que el monto sea un número válido
            decimal monto;
            if (!decimal.TryParse(txtMontoTotal.Text, out monto))
            {
                MessageBox.Show("El monto debe ser un número válido\nEjemplo: 1500.50",
                    "Formato Incorrecto",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                txtMontoTotal.SelectAll();
                return;
            }

            // VALIDACIÓN 4: Verificar que el monto sea mayor a cero
            if (monto <= 0)
            {
                MessageBox.Show("El monto debe ser mayor a cero",
                    "Monto Inválido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                txtMontoTotal.Focus();
                txtMontoTotal.SelectAll();
                return;
            }

            // VALIDACIÓN 5: Verificar que se haya seleccionado un método de pago
            if (cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un método de pago",
                    "Campo Requerido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                cmbMetodoPago.Focus();
                return;
            }

            // SI TODAS LAS VALIDACIONES PASARON, GUARDAR LA FACTURA

            // Crear el mensaje con los datos de la factura
            string mensaje = "═══════════════════════════════\n";
            mensaje += "   FACTURA GUARDADA EXITOSAMENTE\n";
            mensaje += "═══════════════════════════════\n\n";
            mensaje += "📋 Tipo de Contrato:\n    " + cmbContrato.SelectedItem.ToString() + "\n\n";
            mensaje += "📅 Fecha:\n    " + dtpFecha.Value.ToString("dddd, dd 'de' MMMM 'de' yyyy") + "\n\n";
            mensaje += "💰 Monto Total:\n    L. " + monto.ToString("N2") + "\n\n";
            mensaje += "💳 Método de Pago:\n    " + cmbMetodoPago.SelectedItem.ToString() + "\n";
            mensaje += "═══════════════════════════════";

            // Mostrar mensaje de éxito
            MessageBox.Show(mensaje,
                "✓ Factura Registrada",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            // AQUÍ PUEDES AGREGAR CÓDIGO PARA GUARDAR EN BASE DE DATOS
            // Por ejemplo:
            // GuardarEnBaseDeDatos(cmbContrato.SelectedItem.ToString(), dtpFecha.Value, monto, cmbMetodoPago.SelectedItem.ToString());

            // Preguntar si desea crear otra factura
            DialogResult respuesta = MessageBox.Show(
                "¿Desea crear otra factura?",
                "Nueva Factura",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                // Limpiar los campos para una nueva factura
                btnLimpiar_Click(sender, e);
            }
            else
            {
                // Cerrar el formulario
                this.Close();
            }
        }
    }
}
