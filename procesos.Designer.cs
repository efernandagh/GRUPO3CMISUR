namespace INICIO
{
    partial class Procesos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Procesos));
            groupBox1 = new GroupBox();
            cbUsuario = new ComboBox();
            btnCancelar = new Button();
            btnNuevo = new Button();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtdescr = new TextBox();
            txtNomb = new TextBox();
            txtIdPro = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            TextBox4 = new TextBox();
            DataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(cbUsuario);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNuevo);
            groupBox1.Controls.Add(btnLimpiar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtdescr);
            groupBox1.Controls.Add(txtNomb);
            groupBox1.Controls.Add(txtIdPro);
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(250, 57);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(474, 358);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesos";
            // 
            // cbUsuario
            // 
            cbUsuario.FormattingEnabled = true;
            cbUsuario.Location = new Point(266, 181);
            cbUsuario.Name = "cbUsuario";
            cbUsuario.Size = new Size(114, 31);
            cbUsuario.TabIndex = 26;
            // 
            // btnCancelar
            // 
            btnCancelar.ForeColor = Color.CadetBlue;
            btnCancelar.Location = new Point(349, 284);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(103, 31);
            btnCancelar.TabIndex = 25;
            btnCancelar.Text = "SALIR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.ForeColor = Color.CadetBlue;
            btnNuevo.Location = new Point(22, 284);
            btnNuevo.Margin = new Padding(3, 4, 3, 4);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(103, 31);
            btnNuevo.TabIndex = 24;
            btnNuevo.Text = "+ NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.ForeColor = Color.CadetBlue;
            btnLimpiar.Location = new Point(240, 284);
            btnLimpiar.Margin = new Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(103, 31);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.ForeColor = Color.CadetBlue;
            btnGuardar.Location = new Point(132, 284);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(103, 31);
            btnGuardar.TabIndex = 22;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtdescr
            // 
            txtdescr.Location = new Point(266, 128);
            txtdescr.Margin = new Padding(3, 4, 3, 4);
            txtdescr.Name = "txtdescr";
            txtdescr.Size = new Size(114, 30);
            txtdescr.TabIndex = 15;
            // 
            // txtNomb
            // 
            txtNomb.Location = new Point(266, 79);
            txtNomb.Margin = new Padding(3, 4, 3, 4);
            txtNomb.Name = "txtNomb";
            txtNomb.Size = new Size(114, 30);
            txtNomb.TabIndex = 14;
            // 
            // txtIdPro
            // 
            txtIdPro.BackColor = SystemColors.ControlLight;
            txtIdPro.Location = new Point(266, 31);
            txtIdPro.Margin = new Padding(3, 4, 3, 4);
            txtIdPro.Name = "txtIdPro";
            txtIdPro.Size = new Size(114, 30);
            txtIdPro.TabIndex = 13;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(82, 189);
            Label4.Name = "Label4";
            Label4.Size = new Size(85, 23);
            Label4.TabIndex = 12;
            Label4.Text = "USUARIO:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(82, 139);
            Label3.Name = "Label3";
            Label3.Size = new Size(116, 23);
            Label3.TabIndex = 11;
            Label3.Text = "DESCRIPCIÓN";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(82, 73);
            Label2.Name = "Label2";
            Label2.Size = new Size(116, 46);
            Label2.TabIndex = 10;
            Label2.Text = "NOMBRE DEL \r\nPROCESO";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(82, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(105, 23);
            Label1.TabIndex = 9;
            Label1.Text = "ID PROCESO";
            // 
            // TextBox4
            // 
            TextBox4.BackColor = SystemColors.ActiveBorder;
            TextBox4.BorderStyle = BorderStyle.None;
            TextBox4.Location = new Point(115, 289);
            TextBox4.Margin = new Padding(3, 4, 3, 4);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(114, 20);
            TextBox4.TabIndex = 16;
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DataGridView1.Location = new Point(830, 530);
            DataGridView1.Margin = new Padding(3, 4, 3, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(10, 47);
            DataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID PROCESO";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "NOMBRE PROCESO";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "DESCRIPCION";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "USUARIO";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 55);
            panel1.TabIndex = 21;
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
            // Procesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(993, 503);
            Controls.Add(panel1);
            Controls.Add(DataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(TextBox4);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Procesos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "procesos";
            Load += procesos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        internal TextBox TextBox4;
        internal TextBox txtdescr;
        internal TextBox txtNomb;
        internal TextBox txtIdPro;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnCancelar;
        private Button btnNuevo;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ComboBox cbUsuario;
    }
}