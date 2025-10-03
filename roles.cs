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
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";


        public roles()
        {
            InitializeComponent();
        }

        // ✅ Método para probar la conexión

        private void ProbarConexion()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    MessageBox.Show("✅ Conexión exitosa con SQL Server");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al conectar: " + ex.Message);
            }
        }
        private void roles_Load(object sender, EventArgs e)
        {
            ProbarConexion();
        }







        private void btnguardar_Click(object sender, EventArgs e)
        {

            string id = txtidrol.Text;
            string nombre = txtnombrerol.Text;
            string descripcion = txtdescrip.Text;

            // Validar campos vacíos
            if (id == "" || nombre == "" || descripcion == "")
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }




            try
            {
                using (SqlConnection con = new SqlConnection(conexion))
                {
                    con.Open();
                    string query = "INSERT INTO ROL (ID_ROL,NOMBRE_ROL, DESCRIPCION) VALUES (@Id, @Nombre, @Descripcion)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@ID", txtidrol.Text);
                    cmd.Parameters.AddWithValue("@NOMBRE", txtnombrerol.Text);
                    cmd.Parameters.AddWithValue("@DESCRIPCION", txtdescrip.Text
                        );

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("✅ Rol guardado correctamente en SQL");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ Error al guardar: " + ex.Message);
            }
            // Limpiar campos
            txtidrol.Clear();
            txtnombrerol.Clear();
            txtdescrip.Clear();
            txtidrol.Focus();

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
                    string query = "DELETE FROM Roles WHERE IdRol = @Id";
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
            txtnombrerol.Clear();
            txtdescrip.Clear();
            txtdescrip.Focus();
        }

        

         

        private void btncancelar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidrol.Clear();
            txtnombrerol.Clear();
            txtdescrip.Clear();
            txtidrol.Focus();
        }
    }

}
