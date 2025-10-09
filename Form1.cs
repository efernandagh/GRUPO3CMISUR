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
            // Centrar todo el grupo de controles
            int centerX = (this.ClientSize.Width - barratitulo.Width) / 2;
            int centerY = (this.ClientSize.Height - barratitulo.Height) / 2;
            barratitulo.Location = new Point(centerX, centerY);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button1.Visible = false;
            btnrestaurar.Visible = true;

        }

        private void btnrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnrestaurar.Visible = false;
            button1.Visible = true;
        }

        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
