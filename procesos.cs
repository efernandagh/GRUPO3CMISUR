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
    public partial class Procesos : Form
    {
        public Procesos()
        {
            InitializeComponent();
            Desactivar();
        }
        string conexion = "Server=ALEJANDROC\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";
        private void procesos_Load(object sender, EventArgs e)
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

                    string query = "SELECT ID_USUARIO FROM USUARIOS";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataReader reader = cmd.ExecuteReader();

                    cbUsuario.Items.Clear();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("ℹ️ No se encontraron usuarios en la base de datos.",
                                        "Sin datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    while (reader.Read())
                    {
                        cbUsuario.Items.Add(reader["ID_USUARIO"].ToString());
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Activar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdPro.Clear();
            txtNomb.Clear();
            txtdescr.Clear();
            cbUsuario.SelectedIndex = -1;


            // Mensaje de confirmación
            MessageBox.Show("Todos los campos han sido limpiados", "Información",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Desactivar()
        {
            txtIdPro.Enabled = false;
            txtNomb.Enabled = false;
            txtdescr.Enabled = false;
            cbUsuario.Enabled = false;
            btnGuardar.Enabled = false;
            btnLimpiar.Enabled = false;


        }
        public void Activar()
        {
            txtIdPro.Enabled = true;
            txtNomb.Enabled = true;
            txtdescr.Enabled = true;
            cbUsuario.Enabled = true;
            btnGuardar.Enabled = true;
            btnLimpiar.Enabled = true;


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

                    string sql = "INSERT INTO PROCESOS (ID_PROCESOS, NOMBRE_PROCESO, DESCRIPCION, ID_USUARIO ) " +
                                 "VALUES (@ID_PROCESOS, @NOMBRE_PROCESO, @DESCRIPCION, @ID_USUARIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_PROCESOS", txtIdPro.Text);
                        command.Parameters.AddWithValue("@NOMBRE_PROCESO", txtNomb.Text);
                        command.Parameters.AddWithValue("@DESCRIPCION", txtdescr.Text);
                        command.Parameters.AddWithValue("@ID_USUARIO", Convert.ToInt32(cbUsuario.SelectedItem)); ;

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
