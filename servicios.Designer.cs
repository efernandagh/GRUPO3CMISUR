namespace INICIO
{
    partial class servicios
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
            groupBox1 = new GroupBox();
            txtnombreser = new ComboBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtprec = new NumericUpDown();
            txtdesc = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtprec).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(txtnombreser);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtprec);
            groupBox1.Controls.Add(txtdesc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(187, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(499, 335);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de servicios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtnombreser
            // 
            txtnombreser.FormattingEnabled = true;
            txtnombreser.Items.AddRange(new object[] { "Mantenimiento Industrial ", "Diseño de soluciones mecánicas personalizadas", "Reparación de maquinaria agrícola ", "Servicios técnicos especializados" });
            txtnombreser.Location = new Point(187, 94);
            txtnombreser.Margin = new Padding(3, 2, 3, 2);
            txtnombreser.Name = "txtnombreser";
            txtnombreser.Size = new Size(299, 25);
            txtnombreser.TabIndex = 33;
            txtnombreser.SelectedIndexChanged += txtnombredelservicio_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button3.ForeColor = Color.White;
            button3.Location = new Point(331, 293);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 32;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(219, 293);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 31;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(112, 293);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 30;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtprec
            // 
            txtprec.Location = new Point(196, 203);
            txtprec.Margin = new Padding(3, 2, 3, 2);
            txtprec.Name = "txtprec";
            txtprec.Size = new Size(78, 25);
            txtprec.TabIndex = 29;
            txtprec.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(187, 144);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(169, 25);
            txtdesc.TabIndex = 28;
            txtdesc.TextChanged += txtdesc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label4.ForeColor = Color.White;
            label4.Location = new Point(46, 205);
            label4.Name = "label4";
            label4.Size = new Size(42, 17);
            label4.TabIndex = 26;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label3.ForeColor = Color.White;
            label3.Location = new Point(46, 147);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 25;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            label2.ForeColor = Color.White;
            label2.Location = new Point(46, 94);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 24;
            label2.Text = "Nombre del servicio";
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "servicios";
            Text = "servicios";
            Load += servicios_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtprec).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private NumericUpDown txtprecio;
        private TextBox txtdesc;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox txtnombredelservicio;
        private NumericUpDown txtprec;
        private ComboBox txtnombreser;
    }
}