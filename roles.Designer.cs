namespace INICIO
{
    partial class roles
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
            GroupBox1 = new GroupBox();
            btncancelar = new Button();
            btneliminar = new Button();
            txtdescrip = new TextBox();
            txtnombrerol = new TextBox();
            txtidrol = new TextBox();
            btnguardar = new Button();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            DataGridView1 = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // GroupBox1
            // 
            GroupBox1.BackColor = Color.CornflowerBlue;
            GroupBox1.Controls.Add(btncancelar);
            GroupBox1.Controls.Add(btneliminar);
            GroupBox1.Controls.Add(txtdescrip);
            GroupBox1.Controls.Add(txtnombrerol);
            GroupBox1.Controls.Add(txtidrol);
            GroupBox1.Controls.Add(btnguardar);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GroupBox1.ForeColor = Color.White;
            GroupBox1.Location = new Point(252, 34);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(330, 275);
            GroupBox1.TabIndex = 12;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Roles";
            // 
            // btncancelar
            // 
            btncancelar.BackColor = SystemColors.ActiveBorder;
            btncancelar.FlatAppearance.BorderSize = 0;
            btncancelar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btncancelar.FlatStyle = FlatStyle.Flat;
            btncancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btncancelar.ForeColor = Color.White;
            btncancelar.Location = new Point(226, 223);
            btncancelar.Name = "btncancelar";
            btncancelar.Size = new Size(71, 23);
            btncancelar.TabIndex = 10;
            btncancelar.Text = "Cancelar";
            btncancelar.UseVisualStyleBackColor = false;
            btncancelar.Click += btncancelar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = SystemColors.ActiveBorder;
            btneliminar.FlatAppearance.BorderSize = 0;
            btneliminar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(127, 223);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(71, 23);
            btneliminar.TabIndex = 9;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // txtdescrip
            // 
            txtdescrip.BackColor = SystemColors.ActiveBorder;
            txtdescrip.Location = new Point(127, 131);
            txtdescrip.Name = "txtdescrip";
            txtdescrip.Size = new Size(100, 25);
            txtdescrip.TabIndex = 8;
            // 
            // txtnombrerol
            // 
            txtnombrerol.BackColor = SystemColors.ActiveBorder;
            txtnombrerol.Location = new Point(127, 78);
            txtnombrerol.Name = "txtnombrerol";
            txtnombrerol.Size = new Size(100, 25);
            txtnombrerol.TabIndex = 7;
            // 
            // txtidrol
            // 
            txtidrol.BackColor = SystemColors.ActiveBorder;
            txtidrol.Location = new Point(127, 32);
            txtidrol.Name = "txtidrol";
            txtidrol.Size = new Size(100, 25);
            txtidrol.TabIndex = 6;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = SystemColors.ActiveBorder;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.ForeColor = Color.White;
            btnguardar.Location = new Point(6, 223);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(80, 23);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Guardar ";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Label3.ForeColor = Color.White;
            Label3.Location = new Point(22, 139);
            Label3.Name = "Label3";
            Label3.Size = new Size(80, 17);
            Label3.TabIndex = 2;
            Label3.Text = "Descripción:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Label2.ForeColor = Color.White;
            Label2.Location = new Point(20, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(84, 17);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre Rol:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            Label1.ForeColor = Color.White;
            Label1.Location = new Point(31, 32);
            Label1.Name = "Label1";
            Label1.Size = new Size(43, 17);
            Label1.TabIndex = 0;
            Label1.Text = "Id rol:";
            // 
            // DataGridView1
            // 
            DataGridView1.AllowUserToOrderColumns = true;
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido, Descripcion });
            DataGridView1.Location = new Point(252, 325);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.Size = new Size(344, 74);
            DataGridView1.TabIndex = 14;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "ID ROL";
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "NOMBRE ROL";
            Apellido.Name = "Apellido";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "DESCRIPCION";
            Descripcion.Name = "Descripcion";
            // 
            // roles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView1);
            Controls.Add(GroupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "roles";
            Text = "roles";
            Load += roles_Load;
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox GroupBox1;
        internal TextBox txtdescrip;
        internal TextBox txtnombrerol;
        internal TextBox txtidrol;
        internal Button btnguardar;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Apellido;
        internal DataGridViewTextBoxColumn Descripcion;
        internal Button btncancelar;
        internal Button btneliminar;
    }
}