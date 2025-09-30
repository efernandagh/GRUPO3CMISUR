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




namespace INICIO
{
    public partial class roles : Form
    {
        List<string[]> listaroles = new List<string[]>();
        string conexion = "Server=DESKTOP-8QJ2O4S\\ENIAGOMEZ;Database=MECANICA_INDUSTRIAL;Integrated Security=True;";


        public roles()
        {
            InitializeComponent();
        }

        private void roles_Load(object sender, EventArgs e)
        {

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

            


            // Guardar el rol en la lista
            listaroles.Add(new string[] { id, nombre, descripcion });

            MessageBox.Show("Rol guardado correctamente ✅");

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

            bool encontrado = false;

            // Buscar y eliminar por Id
            for (int i = 0; i < listaroles.Count; i++)
            {
                if (listaroles[i][0] == id)
                {
                    listaroles.RemoveAt(i);
                    encontrado = true;
                    MessageBox.Show("Rol eliminado correctamente 🗑️");
                    break;
                }
            }

            if (!encontrado)
            {
                MessageBox.Show("No se encontró un rol con ese Id.");
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
