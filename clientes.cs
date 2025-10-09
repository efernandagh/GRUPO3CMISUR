using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace INICIO
{
    public partial class clientes : Form
    {
        string conexion = "Server=DESKTOP-FT2QP2U\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";

        public clientes()
        {
            InitializeComponent();
        }

        private SqlConnection CrearConexion()
        {
            return new SqlConnection(conexion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO CLIENTES (ID_CLIENTES, NOMBRE_CLIENTE, CORREO, TELEFONO, DIRECCION, FECHA_REGISTRO) VALUES (@id, @nombre, @correo, @telefono, @direccion, @fecha)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id ", Convert.ToInt64(txtIdcliente.Text));
                cmd.Parameters.AddWithValue("@nombre", txtnombre.Text);
                cmd.Parameters.AddWithValue("@correo", txtcorreo.Text);
                cmd.Parameters.AddWithValue("@direccion", txtdireccion.Text);
                cmd.Parameters.AddWithValue("@telefono", txttelefono.Text);
                cmd.Parameters.AddWithValue("@fecha", dtpfecharegistro.Value);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente guardado correctamente.");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message);
                }

            }
        }

        private SqlConnection Conectar()
        {
            return new SqlConnection(conexion);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void clientes_Load(object sender, EventArgs e)
        {

        }
    }
}


