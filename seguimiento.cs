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
    public partial class seguimiento : Form
    {
        public seguimiento()
        {
            InitializeComponent();
            Desactivar();
        }
        string conexion = "Server=ALEJANDROC\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private void seguimiento_Load(object sender, EventArgs e)
        {

            // 🔹 Cargar usuarios al iniciar el formulario
            try
            {
                // ✅ Verificar si la cadena de conexión está definida
                if (string.IsNullOrWhiteSpace(conexion))
                {
                    MessageBox.Show("⚠️ La cadena de conexión no está configurada.",
                                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(conexion))
                {
                    conn.Open();

                    string query = "SELECT ID_CONTRATO FROM CONTRATOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbContrato.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ℹ️ No se encontraron usuarios en la base de datos.",
                                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        cbContrato.Items.Add(reader["ID_CONTRATO"].ToString());
                    }

                    reader.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("❌ Error SQL al cargar usuarios:\n" + ex.Message,
                                "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error general al cargar usuarios:\n" + ex.Message,
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Desactivar()
        {
            txtSeguimiento.Enabled = false;
            cbContrato.Enabled = false;
            txtDescripcion.Enabled = false;
            dtpFecha.Enabled = false;
            txtNivel.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;


        }
        public void Activar()
        {
            txtSeguimiento.Enabled = true;
            cbContrato.Enabled = true;
            txtDescripcion.Enabled = true;
            dtpFecha.Enabled = true;
            txtNivel.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;


        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activar();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
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
        public void Almacenar()
        {
            string connectionString = "Server=ALEJANDROC\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string sql = "INSERT INTO SEGUIMIENTO (ID_SEGUIMIENTO, ID_CONTRATO, FECHA_SEGUIMIENTO, DESCRIPCION, NIVEL_SATISFACTORIO ) " +
                                 "VALUES (@ID_SEGUIMIENTO, @ID_CONTRATO, @FECHA_SEGUIMIENTO, @DESCRIPCION, @NIVEL_SATISFACTORIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_SEGUIMIENTO", txtSeguimiento.Text);
                        command.Parameters.AddWithValue("@ID_CONTRATO", Convert.ToInt32(cbContrato.SelectedItem)); ;
                        command.Parameters.AddWithValue("@FECHA_SEGUIMIENTO", DateTime.Parse(dtpFecha.Text));
                        command.Parameters.AddWithValue("@DESCRIPCION", txtDescripcion.Text);
                        command.Parameters.AddWithValue("@NIVEL_SATISFACTORIO", txtNivel.Text);


                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Proyecto agregado exitosamente.",
                        "Hola SQL Server", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }
    }
}
