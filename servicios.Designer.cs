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
            groupBox1.Controls.Add(txtnombreser);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtprec);
            groupBox1.Controls.Add(txtdesc);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(144, 49);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(593, 447);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de servicios";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txtnombreser
            // 
            txtnombreser.FormattingEnabled = true;
            txtnombreser.Items.AddRange(new object[] { "Mantenimiento Industrial ", "Diseño de soluciones mecánicas personalizadas", "Reparación de maquinaria agrícola ", "Servicios técnicos especializados" });
            txtnombreser.Location = new Point(214, 125);
            txtnombreser.Name = "txtnombreser";
            txtnombreser.Size = new Size(341, 28);
            txtnombreser.TabIndex = 33;
            txtnombreser.SelectedIndexChanged += txtnombredelservicio_SelectedIndexChanged;
            // 
            // button3
            // 
            button3.Location = new Point(378, 391);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 31);
            button3.TabIndex = 32;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(250, 391);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(86, 31);
            button2.TabIndex = 31;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(128, 391);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 30;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtprec
            // 
            txtprec.Location = new Point(186, 273);
            txtprec.Margin = new Padding(3, 4, 3, 4);
            txtprec.Name = "txtprec";
            txtprec.Size = new Size(102, 27);
            txtprec.TabIndex = 29;
            txtprec.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // txtdesc
            // 
            txtdesc.Location = new Point(189, 196);
            txtdesc.Margin = new Padding(3, 4, 3, 4);
            txtdesc.Name = "txtdesc";
            txtdesc.Size = new Size(193, 27);
            txtdesc.TabIndex = 28;
            txtdesc.TextChanged += txtdesc_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(53, 273);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 26;
            label4.Text = "Precio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(53, 196);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 25;
            label3.Text = "Descripcion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 125);
            label2.Name = "label2";
            label2.Size = new Size(143, 20);
            label2.TabIndex = 24;
            label2.Text = "Nombre del servicio";
            // 
            // servicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
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