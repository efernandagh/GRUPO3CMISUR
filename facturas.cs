using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class facturas : Form
    {
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";
        public facturas()
        {
            InitializeComponent();

        }

        private void facturas_Load(object sender, EventArgs e)
        {
            // 🔹 Cargar contratos
            try
            {
                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();
                    string query = "SELECT ID_CONTRATO FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cboidcontrato.Items.Clear();

                    while (reader.Read())
                    {
                        cboidcontrato.Items.Add(reader["ID_CONTRATO"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al cargar contratos: " + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // 🔹 Cargar métodos de pago
            cmbMetodoPago.Items.Clear();
            cmbMetodoPago.Items.Add("Efectivo");
            cmbMetodoPago.Items.Add("Tarjeta");
            cmbMetodoPago.Items.Add("Transferencia");
            cmbMetodoPago.Items.Add("Depósito");
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtidfactura.Clear();
            // Limpiar ComboBox de Método de Pago
            cboidcontrato.SelectedIndex = -1;

            // Establecer fecha actual
            dtpFecha.Value = DateTime.Now;

            // Limpiar campo de monto
            txtMontoTotal.Clear();

            // Limpiar ComboBox de Método de Pago
            cmbMetodoPago.SelectedIndex = -1;

            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            // Validar campos
            if (string.IsNullOrWhiteSpace(txtidfactura.Text) ||
                cboidcontrato.SelectedIndex == -1 ||
                string.IsNullOrWhiteSpace(txtMontoTotal.Text) ||
                cmbMetodoPago.SelectedIndex == -1)
            {
                MessageBox.Show("⚠️ Por favor, completa todos los campos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que el monto sea numérico
            if (!decimal.TryParse(txtMontoTotal.Text, out decimal montoDecimal))
            {
                MessageBox.Show("⚠️ El campo MONTO debe ser un número válido.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insertar en la base de datos
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO FACTURAS (ID_FACTURA, ID_CONTRATO, FECHA_FACTURA, MONTO_TOTAL, METODO_PAGO) " +
                                   "VALUES (@idfactura, @idcontrato, @fecha, @monto, @metodo)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@idfactura", Convert.ToInt32(txtidfactura.Text));
                    cmd.Parameters.AddWithValue("@idcontrato", Convert.ToInt32(cboidcontrato.SelectedItem));
                    cmd.Parameters.AddWithValue("@fecha", dtpFecha.Value);
                    cmd.Parameters.AddWithValue("@monto", montoDecimal);
                    cmd.Parameters.AddWithValue("@metodo", cmbMetodoPago.SelectedItem.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Factura guardada correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
            mensaje += "📋 Tipo de Contrato:\n    " + cboidcontrato.SelectedItem.ToString() + "\n\n";
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

        private void cmbContrato_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboidcontrato_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
          


        }
      
    }


}


