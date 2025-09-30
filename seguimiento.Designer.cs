namespace INICIO
{
    partial class seguimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seguimiento));
            groupBox1 = new GroupBox();
            btnGuardar = new Button();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnLimpiar = new Button();
            btnNuevo = new Button();
            btnCancelar = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(231, 63);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(465, 379);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Seccion de seguimiento";
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(132, 305);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 31);
            btnGuardar.TabIndex = 18;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(189, 225);
            comboBox2.Margin = new Padding(3, 4, 3, 4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(187, 31);
            comboBox2.TabIndex = 17;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(189, 173);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 30);
            textBox1.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 120);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 30);
            dateTimePicker1.TabIndex = 15;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 65);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 31);
            comboBox1.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 213);
            label4.Name = "label4";
            label4.Size = new Size(131, 46);
            label4.TabIndex = 13;
            label4.Text = "NIVEL\r\nSATISFACTORIO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 176);
            label3.Name = "label3";
            label3.Size = new Size(116, 23);
            label3.TabIndex = 12;
            label3.Text = "DESCRIPCIÓN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 113);
            label2.Name = "label2";
            label2.Size = new Size(117, 46);
            label2.TabIndex = 11;
            label2.Text = "FECHA DE\r\nSEGUIMIENTO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 69);
            label1.Name = "label1";
            label1.Size = new Size(99, 23);
            label1.TabIndex = 10;
            label1.Text = "CONTRATO";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(288, 450);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(354, 144);
            dataGridView1.TabIndex = 19;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 55);
            panel1.TabIndex = 20;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 61);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(241, 305);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 31);
            btnLimpiar.TabIndex = 19;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(23, 305);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 31);
            btnNuevo.TabIndex = 20;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(350, 305);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // seguimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(914, 600);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "seguimiento";
            Text = "seguimiento";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Button btnGuardar;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnLimpiar;
        private Button btnCancelar;
        private Button btnNuevo;
    }
}