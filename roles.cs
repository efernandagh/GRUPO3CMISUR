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
using Microsoft.Data.SqlClient;





namespace INICIO
{
    public partial class roles : Form
    {
        List<string[]> listaroles = new List<string[]>();
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";
        private string conexiontionString;

        public roles()
        {
            InitializeComponent();
        }
        
        private void roles_Load(object sender, EventArgs e)
        {
            CargarRoles();
            txtidrol.Enabled = false;
            GenerarNuevoId();
        }

        private void GenerarNuevoId()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string consulta = "SELECT ISNULL(MAX(ID_ROL), 0) + 1 FROM ROL";
                    SqlCommand cmd = new SqlCommand(consulta, con);
                    object resultado = cmd.ExecuteScalar();
                    txtidrol.Text = (resultado != null) ? resultado.ToString() : "1";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al generar ID: " + ex.Message);
                txtidrol.Text = "1";
            }
        }

        private int ObtenerSiguienteIdrol()
        {
            int siguienteId = 1;

            using (SqlConnection conexion = new SqlConnection(conexiontionString))
            {
                conexion.Open();
                string consulta = "SELECT ISNULL(MAX(ID_ROL), 0) + 1 FROM ROL";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                siguienteId = Convert.ToInt32(comando.ExecuteScalar());
            }

            return siguienteId;
        }
        public void CargarRoles()
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

                    cmbnombrerol.DataSource = dt;
                    cmbnombrerol.DisplayMember = "NOMBRE_ROL";
                    cmbnombrerol.ValueMember = "ID_ROL";
                    cmbnombrerol.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("❌ Error al cargar roles: " + ex.Message);
                }
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            string nombre = cmbnombrerol.Text.Trim();
            string descripcion = txtdescrip.Text.Trim();

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO ROL (NOMBRE_ROL, DESCRIPCION) VALUES (@Nombre, @Descripcion)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Nombre", nombre);
                    cmd.Parameters.AddWithValue("@Descripcion", descripcion);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Rol guardado correctamente en SQL.");

                    // Refrescar roles en el formulario de usuarios
                    foreach (Form f in Application.OpenForms)
                    {
                        if (f is usuarios)
                        {
                            ((usuarios)f).CargarRoles();
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }

            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }


        private void btneliminar_Click(object sender, EventArgs e)
        {
            string id = txtidrol.Text;

            if (id == "")
            {
                MessageBox.Show("Ingresa el Id del rol a eliminar.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "DELETE FROM ROL WHERE ID_ROL = @Id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@Id", id);

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                        MessageBox.Show("🗑️ Rol eliminado correctamente");
                    else
                        MessageBox.Show("No se encontró un rol con ese Id.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al eliminar: " + ex.Message);
            }


            txtidrol.Clear();
            cmbnombrerol.Text = "";
            txtdescrip.Clear();
            txtdescrip.Focus();
        }




        private void btncancelar_Click(object sender, EventArgs e)
        {// Preguntar si está seguro de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
