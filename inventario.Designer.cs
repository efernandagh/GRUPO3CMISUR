namespace INICIO
{
    partial class inventario
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
            Button1 = new Button();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtidpro = new TextBox();
            txtestado = new TextBox();
            label7 = new Label();
            txtidinventario = new TextBox();
            txtcantidad = new TextBox();
            label6 = new Label();
            dtpfecha = new DateTimePicker();
            txtnombrepro = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbunidad = new ComboBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(196, 456);
            Button1.Margin = new Padding(3, 4, 3, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(86, 31);
            Button1.TabIndex = 8;
            Button1.Text = "Guardar";
            Button1.UseVisualStyleBackColor = true;
            Button1.Click += Button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Location = new Point(38, 281);
            label3.Name = "label3";
            label3.Size = new Size(110, 23);
            label3.TabIndex = 7;
            label3.Text = "Fecha Ingreso";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(cmbunidad);
            groupBox1.Controls.Add(txtidpro);
            groupBox1.Controls.Add(txtestado);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtidinventario);
            groupBox1.Controls.Add(txtcantidad);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(Button1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dtpfecha);
            groupBox1.Controls.Add(txtnombrepro);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(181, 13);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(506, 536);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // txtidpro
            // 
            txtidpro.Location = new Point(196, 399);
            txtidpro.Name = "txtidpro";
            txtidpro.Size = new Size(156, 29);
            txtidpro.TabIndex = 16;
            // 
            // txtestado
            // 
            txtestado.Location = new Point(197, 337);
            txtestado.Name = "txtestado";
            txtestado.Size = new Size(155, 29);
            txtestado.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 61);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 14;
            label7.Text = "ID INVENTARIO";
            // 
            // txtidinventario
            // 
            txtidinventario.Location = new Point(197, 61);
            txtidinventario.Name = "txtidinventario";
            txtidinventario.Size = new Size(155, 29);
            txtidinventario.TabIndex = 13;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(196, 169);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(156, 29);
            txtcantidad.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(71, 169);
            label6.Name = "label6";
            label6.Size = new Size(77, 23);
            label6.TabIndex = 11;
            label6.Text = "Cantidad";
            // 
            // dtpfecha
            // 
            dtpfecha.Location = new Point(196, 281);
            dtpfecha.Margin = new Padding(3, 4, 3, 4);
            dtpfecha.Name = "dtpfecha";
            dtpfecha.Size = new Size(273, 29);
            dtpfecha.TabIndex = 9;
            // 
            // txtnombrepro
            // 
            txtnombrepro.Location = new Point(197, 115);
            txtnombrepro.Margin = new Padding(3, 4, 3, 4);
            txtnombrepro.Name = "txtnombrepro";
            txtnombrepro.Size = new Size(155, 29);
            txtnombrepro.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(38, 399);
            label5.Name = "label5";
            label5.Size = new Size(127, 23);
            label5.TabIndex = 4;
            label5.Text = "ID PROVEEDOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(90, 337);
            label4.Name = "label4";
            label4.Size = new Size(58, 23);
            label4.TabIndex = 3;
            label4.Text = "Estado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 226);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 1;
            label2.Text = "Unidad de medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 115);
            label1.Name = "label1";
            label1.Size = new Size(140, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombre Producto";
            // 
            // cmbunidad
            // 
            cmbunidad.FormattingEnabled = true;
            cmbunidad.Location = new Point(196, 226);
            cmbunidad.Name = "cmbunidad";
            cmbunidad.Size = new Size(156, 29);
            cmbunidad.TabIndex = 17;
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "inventario";
            Text = "inventario";
            Load += inventario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        internal Button Button1;
        private Label label3;
        private GroupBox groupBox1;
        private DateTimePicker dtpfecha;
        private TextBox txtnombrepro;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private Label label7;
        private TextBox txtidinventario;
        private TextBox txtcantidad;
        private Label label6;
        private TextBox txtidpro;
        private TextBox txtestado;
        private ComboBox cmbunidad;
    }
}