namespace INICIO
{
    partial class facturas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            btnGuardar = new Button();
            dtpFecha = new DateTimePicker();
            txtContrato = new TextBox();
            txtMontoTotal = new TextBox();
            txtMetodoPago = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(txtContrato);
            panel1.Controls.Add(txtMontoTotal);
            panel1.Controls.Add(txtMetodoPago);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(143, 28);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 336);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.FACTURAS;
            pictureBox1.Location = new Point(420, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(90, 111);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(385, 279);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(101, 29);
            btnGuardar.TabIndex = 9;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(207, 129);
            dtpFecha.Margin = new Padding(3, 2, 3, 2);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(219, 23);
            dtpFecha.TabIndex = 8;
            // 
            // txtContrato
            // 
            txtContrato.Location = new Point(207, 53);
            txtContrato.Margin = new Padding(3, 2, 3, 2);
            txtContrato.Name = "txtContrato";
            txtContrato.Size = new Size(124, 23);
            txtContrato.TabIndex = 7;
            // 
            // txtMontoTotal
            // 
            txtMontoTotal.Location = new Point(207, 191);
            txtMontoTotal.Margin = new Padding(3, 2, 3, 2);
            txtMontoTotal.Name = "txtMontoTotal";
            txtMontoTotal.Size = new Size(124, 23);
            txtMontoTotal.TabIndex = 6;
            // 
            // txtMetodoPago
            // 
            txtMetodoPago.Location = new Point(210, 256);
            txtMetodoPago.Margin = new Padding(3, 2, 3, 2);
            txtMetodoPago.Name = "txtMetodoPago";
            txtMetodoPago.Size = new Size(124, 23);
            txtMetodoPago.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(50, 258);
            label5.Name = "label5";
            label5.Size = new Size(154, 21);
            label5.TabIndex = 4;
            label5.Text = "METODO DE PAGO:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 193);
            label4.Name = "label4";
            label4.Size = new Size(124, 21);
            label4.TabIndex = 3;
            label4.Text = "MONTO TOTAL:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 129);
            label3.Name = "label3";
            label3.Size = new Size(64, 21);
            label3.TabIndex = 2;
            label3.Text = "FECHA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 55);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 1;
            label2.Text = "CONTRATO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(207, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 25);
            label1.TabIndex = 0;
            label1.Text = "FACTURA";
            label1.Click += label1_Click;
            // 
            // facturas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "facturas";
            Text = "facturas";
            Load += facturas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnGuardar;
        private DateTimePicker dtpFecha;
        private TextBox txtContrato;
        private TextBox txtMontoTotal;
        private TextBox txtMetodoPago;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
    }
}