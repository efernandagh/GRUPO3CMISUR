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
    public partial class servicios : Form
    {
        string conexion = "Server=DESKTOP-FT2QP2U\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";


        public servicios()
        {
            InitializeComponent();
        }
        private SqlConnection Conectar()
        {
            SqlConnection conn = new SqlConnection(conexion);
            conn.Open();
            return conn;
        }

        // 🔸 Cargar ComboBox con los servicios al iniciar
        private void servicios_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "SELECT NOMBRE_SERVICIO FROM SERVICIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    txtnombreser.Items.Add(reader["NOMBRE_SERVICIO"].ToString());
                }

                conn.Close();
            }
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {// Preguntar si está seguro de salir
            DialogResult resultado = MessageBox.Show("¿Está seguro que desea salir?",
                "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
        

        private void txtnombredelservicio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtdesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO SERVICIOS (ID_SERVICIOS, NOMBRE_SERVICIO, DESCRIPCION) VALUES (@id, @nombre, @descripcion)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtidservicio.Text);
                cmd.Parameters.AddWithValue("@nombre", txtnombreser.Text);
                cmd.Parameters.AddWithValue("@descripcion", txtdesc.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Servicio guardado correctamente.");
                conn.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();
            

            // Poner el foco en el primer campo
            txtidservicio.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

            

        

        private void LimpiarCampos()
        {
            txtidservicio.Clear();
            txtnombreser.Text = "";
            txtdesc.Clear();
        }
    }
}

