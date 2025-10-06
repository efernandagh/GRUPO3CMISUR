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
    public partial class proyecto : Form
    {
        public void Almacenar()
        {
            string connectionString = "Server=ALEJANDROC\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Trusted_Connection=True;Encrypt=True;TrustServerCertificate=True;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    string sql = "INSERT INTO PROYECTOS (ID_PROYECTO, NOMBRE_PROYECTO, DESCRIPCION, FECHA_INICIO, FECHA_FIN, ID_USUARIO) " +
                                 "VALUES (@ID_PROYECTO, @NOMBRE_PROYECTO, @DESCRIPCION, @FECHA_INICIO, @FECHA_FIN, @ID_USUARIO)";

                    using (SqlCommand command = new SqlCommand(sql, conexion))
                    {
                        command.Parameters.AddWithValue("@ID_PROYECTO", Txtidproyecto.Text);
                        command.Parameters.AddWithValue("@NOMBRE_PROYECTO", Txtnombrepro.Text);
                        command.Parameters.AddWithValue("@DESCRIPCION", Txtdescripcion.Text);
                        command.Parameters.AddWithValue("@FECHA_INICIO", DateTime.Parse(txtfi.Text));
                        command.Parameters.AddWithValue("@FECHA_FIN", DateTime.Parse(txtff.Text));
                        command.Parameters.AddWithValue("@ID_USUARIO", Txtusuario.Text);

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

        public proyecto()
        {
            InitializeComponent();
        }

        private void Btnguardar_Click(object sender, EventArgs e)
        {
            Almacenar();
        }

        private void proyecto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Almacenar();
        }
    }
}
