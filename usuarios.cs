using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace INICIO
{

    public partial class usuarios : Form

    {
        private string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";

        public usuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtidusuario.Text;
            string nombre = txtnombreusuario.Text;
            string apellido = txtapellidousuarios.Text;
            string correo = txtcorreousuario.Text;
            string clave = txtclaveusuario.Text;
            string rol = txtrolusuario.Text;
            DateTime fecha = dtpfecha.Value;

            // Validar
            if (string.IsNullOrWhiteSpace(id) ||
                string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(clave) ||
                string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("⚠️ Por favor, completa todos los campos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO USUARIOS (ID_USUARIO,NOMBRE, APELLIDO, CORREO, CLAVE, ID_ROL, FECHA_REGISTRO) " +
                                   "VALUES (@id,   @nombre, @apellido, @correo, @clave, @rol, @fecha)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtidusuario.Text));
                    cmd.Parameters.AddWithValue("@nombre", txtnombreusuario.Text);
                    cmd.Parameters.AddWithValue("@apellido", txtapellidousuarios.Text);
                    cmd.Parameters.AddWithValue("@correo", txtcorreousuario.Text);
                    cmd.Parameters.AddWithValue("@clave", txtclaveusuario.Text);
                    cmd.Parameters.AddWithValue("@rol", Convert.ToInt32(txtrolusuario.Text));
                    cmd.Parameters.AddWithValue("@fecha", dtpfecha.Value.Date);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("✅ Usuario guardado correctamente.",
                                    "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al guardar: " + ex.Message);
                }
            }
        }
        // Mostrar mensaje



        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Deseas eliminar los datos ingresados?",
                                                "Confirmar eliminación",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("🗑️ Datos eliminados correctamente.",
                                "Eliminado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }

            // Limpiar campos siempre al final
            LimpiarCampos();

        }



        // MÉTODO PARA LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
             txtidusuario.Clear();
            txtnombreusuario.Clear();
            txtapellidousuarios.Clear();
            txtcorreousuario.Clear();
            txtclaveusuario.Clear();
            txtrolusuario.Clear();
            dtpfecha.Value = DateTime.Now;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada.");
        }

        private void txtnombreusuario_TextChanged(object sender, EventArgs e)
        {

        }


        private void usuarios_Load(object sender, EventArgs e)
        {
            // Si quieres probar conexión en silencio, puedes hacer:
            /*
            using (SqlConnection conn = new SqlConnection(conexion))
            {
                try { conn.Open(); } 
                catch (Exception ex) 
                { 
                    MessageBox.Show("Error de conexión: " + ex.Message); 
                }
            }
            */
        }



     
    }
    }
