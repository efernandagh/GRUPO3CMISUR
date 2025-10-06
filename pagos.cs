using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INICIO
{
    public partial class frmPagos : Form
    {
        public frmPagos()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {





        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir números, punto decimal, backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // Permitir solo un punto decimal
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
    ' Limpiar todos los campos
    txtPago.Clear()
    txtFactura.Clear()
    txtMonto.Clear()
    dtpFecha.Value = DateTime.Now
    cboEstado.SelectedIndex = 0


    ' Poner el foco en el primer campo
    txtPago.Focus()


    MessageBox.Show("Formulario limpiado", "Limpiar", MessageBoxButtons.OK, MessageBoxIcon.Information)
End Sub
        }

        private void pagos_Load(object sender, EventArgs e)
        {
            Public Class frmPagos
    Private Sub frmPagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configurar el DateTimePicker
        dtpFecha.Format = DateTimePickerFormat.Custom
        dtpFecha.CustomFormat = "dddd dd 'de' MMMM 'de' yyyy"


        ' Llenar el ComboBox de ESTADO
        cboEstado.Items.Clear()
        cboEstado.Items.Add("Pendiente")
        cboEstado.Items.Add("Pagado")
        cboEstado.Items.Add("Cancelado")
        cboEstado.SelectedIndex = 0


        ' Configurar campos de texto solo para números
        txtPago.MaxLength = 10
        txtFactura.MaxLength = 20
        txtMonto.MaxLength = 15
    End Sub
End Class
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
    ' Preguntar si está seguro de salir
    Dim resultado As DialogResult = MessageBox.Show("¿Está seguro que desea salir?", _
                                                     "Confirmar salida", _
                                                     MessageBoxButtons.YesNo, _
                                                     MessageBoxIcon.Question)


    If resultado = DialogResult.Yes Then
        Me.Close()
    End If
End Sub
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
    ' Validar que todos los campos estén llenos
    If String.IsNullOrWhiteSpace(txtPago.Text) Then
        MessageBox.Show("Por favor ingrese el número de PAGO", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtPago.Focus()
        Return
    End If

    If String.IsNullOrWhiteSpace(txtFactura.Text) Then
        MessageBox.Show("Por favor ingrese el número de FACTURA", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtFactura.Focus()
        Return
    End If

    If String.IsNullOrWhiteSpace(txtMonto.Text) Then
        MessageBox.Show("Por favor ingrese el MONTO", "Campo requerido", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        txtMonto.Focus()
        Return
    End If


    ' Validar que el monto sea un número válido
    Dim monto As Decimal
    If Not Decimal.TryParse(txtMonto.Text, monto) Then
        MessageBox.Show("El MONTO debe ser un número válido", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
        txtMonto.Focus()
        Return
    End If


    ' Si todo es válido, mostrar mensaje de éxito
    Dim mensaje As String = String.Format("Pago guardado exitosamente:" & vbCrLf & vbCrLf & _
                                         "Pago: {0}" & vbCrLf & _
                                         "Factura: {1}" & vbCrLf & _
                                         "Fecha: {2}" & vbCrLf & _
                                         "Monto: {3:C2}" & vbCrLf & _
                                         "Estado: {4}", _
                                         txtPago.Text, txtFactura.Text, dtpFecha.Value.ToLongDateString(), _
                                         monto, cboEstado.SelectedItem.ToString())


    MessageBox.Show(mensaje, "Guardado exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)


    ' Aquí puedes agregar código para guardar en una base de datos
    ' Por ejemplo: GuardarEnBaseDeDatos()
End Sub
        }
    }
}
