using System;
using System.Windows.Forms;

namespace INICIO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

            string contra = txtcontra.Text;



            // Abrir el formulario de menú
            Menu frmMenu = new Menu();
            frmMenu.Show();

            // Ocultar el formulario actual (registro)
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtnombre.Clear();

            txtcontra.Clear();


            txtnombre.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
