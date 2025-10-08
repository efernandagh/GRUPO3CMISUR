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
    public partial class inventario : Form
    {
        string conexion = "Server=DESKTOP-FT2QP2U\\SQLEXPRESS;Database=MECANICA_INDUSTRIAL;Integrated Security=True;TrustServerCertificate=True;";


        public inventario()
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
                string query = "SELECT UNIDAD_MEDIDA FROM INVENTARIOS";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbunidad.Items.Add(reader["UNIDAD_MEDIDA"].ToString());
                }

                conn.Close();
            }
        }

        private void inventario_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conectar())
            {
                string query = "INSERT INTO INVENTARIOS (ID_INVENTARIO, NOMBRE_PRODUCTO, CANTIDAD, UNIDAD_MEDIDA, FECHA_INGRESO, ESTADO, ID_PROVEEDOR) VALUES (@id, @nombre, @cantidad, @unidad, @fecha, @estado, @ID_PROVEEDOR)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt64(txtidinventario.Text));
                cmd.Parameters.AddWithValue("@nombre", txtnombrepro.Text);
                cmd.Parameters.AddWithValue("@cantidad", txtcantidad.Text);
                cmd.Parameters.AddWithValue("@unidad", cmbunidad.Text);
                cmd.Parameters.AddWithValue("@fecha", Convert.ToDateTime(dtpfecha.Text));
                cmd.Parameters.AddWithValue("@estado", txtestado.Text);
                cmd.Parameters.AddWithValue("@ID_PROVEEDOR", Convert.ToInt64(txtidpro.Text));


                cmd.ExecuteNonQuery();
                MessageBox.Show("Inventario guardado correctamente.");
                conn.Close();
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            // Limpiar todos los campos
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();


            // Poner el foco en el primer campo
            txtidinventario.Focus();

            MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void LimpiarCampos()
        {
            txtidinventario.Clear();
            txtnombrepro.Text = "";
            txtcantidad.Clear();
            cmbunidad.Items.Clear();
            dtpfecha.Text = "";
            txtestado.Clear();
            txtidpro.Clear();

        }
    }
}
    