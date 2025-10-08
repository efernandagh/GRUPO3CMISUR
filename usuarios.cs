
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient; // Asegúrate de tener la referencia a Microsoft.Data.SqlClient


namespace INICIO
{


    public partial class usuarios : Form
    {
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";


        public usuarios()
        {
            InitializeComponent();
        }



        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtidusuario.Text.Trim();
            string nombre = txtnombreusuario.Text.Trim();
            string apellido = txtapellidousuarios.Text.Trim();
            string correo = txtCorreo.Text.Trim();
            string clave = txtClave.Text.Trim();
            DateTime fecha = dtpfecha.Value;

            if (cmbrol.SelectedIndex == -1)
            {
                MessageBox.Show("Selecciona un rol para el usuario.");
                return;
            }

            int idRol = Convert.ToInt32(cmbrol.SelectedValue);

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) || string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO USUARIOS (ID_USUARIO, NOMBRE, APELLIDO, CORREO, CLAVE, ID_ROL, FECHA_REGISTRO) " +
                                   "VALUES (@Id, @Nombre, @Apellido, @Correo, @Clave, @Rol, @Fecha)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Apellido", apellido);
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    cmd.Parameters.AddWithValue("@Clave", clave);
                    cmd.Parameters.AddWithValue("@Rol", idRol);
                    cmd.Parameters.AddWithValue("@Fecha", fecha);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Usuario guardado correctamente en SQL.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }

            LimpiarCampos();
        }


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
            txtnombreusuario.Clear();
            txtapellidousuarios.Clear();
            txtcorreousuario.Clear();
            txtclaveusuario.Clear();
            cmbrol.Text="";
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
            using (SqlConnection con = new SqlConnection(conexion))
            {
                try
                {
                    con.Open();
                    string query = "SELECT ID_ROL, NOMBRE_ROL FROM ROL";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataReader dr = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(dr);

                    cmbrol.DataSource = dt;
                    cmbrol.DisplayMember = "NOMBRE_ROL"; // Mostrar
                    cmbrol.ValueMember = "ID_ROL";       // Valor real
                    cmbrol.SelectedIndex = -1;           // Ninguno seleccionado al inicio
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }

            // Establecer fecha actual por defecto
            dtpfecha.Value = DateTime.Now;
        }
    }
}
