using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class usuarios : Form
    {
        public usuarios()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Obtener los valores
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string correo = txtCorreo.Text;
            string clave = txtClave.Text;
            string rol = txtRol.Text;
            string fecha = dtpfecha.Value.ToString("dd/MM/yyyy");

            // Validar
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(correo) ||
                string.IsNullOrWhiteSpace(clave) ||
                string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("⚠️ Por favor, completa todos los campos.",
                                "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Mostrar mensaje
            string mensaje = $"✅ Usuario guardado:\n\n" +
                             $"Nombre: {nombre}\n" +
                             $"Apellido: {apellido}\n" +
                             $"Correo: {correo}\n" +
                             $"Clave: {clave}\n" +
                             $"Rol: {rol}\n" +
                             $"Fecha: {fecha}";

            MessageBox.Show(mensaje, "Registro Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtnombreusuario.Clear();
            txtapellidousuarios.Clear();
            txtcorreousuario.Clear();
            txtclaveusuario.Clear();
            txtnombreusuario.Clear();
            dtpfecha.Value = DateTime.Now;

            txtnombreusuario.Focus();
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
            txtrolusuario.Clear();
            dtpfecha.Value = DateTime.Now;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            MessageBox.Show("Operación cancelada.");
        }
    }
}
