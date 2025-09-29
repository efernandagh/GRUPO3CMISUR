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
            TextBox3 = new TextBox();
            TextBox2 = new TextBox();
            TextBox1 = new TextBox();
            Button1 = new Button();
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
            GroupBox1.Controls.Add(TextBox3);
            GroupBox1.Controls.Add(TextBox2);
            GroupBox1.Controls.Add(TextBox1);
            GroupBox1.Controls.Add(Button1);
            GroupBox1.Controls.Add(Label3);
            GroupBox1.Controls.Add(Label2);
            GroupBox1.Controls.Add(Label1);
            GroupBox1.Location = new Point(252, 34);
            GroupBox1.Name = "GroupBox1";
            GroupBox1.Size = new Size(330, 275);
            GroupBox1.TabIndex = 12;
            GroupBox1.TabStop = false;
            GroupBox1.Text = "Roles";
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(127, 131);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(100, 23);
            TextBox3.TabIndex = 8;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(127, 78);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(100, 23);
            TextBox2.TabIndex = 7;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(127, 29);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(100, 23);
            TextBox1.TabIndex = 6;
            // 
            // Button1
            // 
            Button1.Location = new Point(101, 206);
            Button1.Name = "Button1";
            Button1.Size = new Size(112, 23);
            Button1.TabIndex = 5;
            Button1.Text = "Guardar rol";
            Button1.UseVisualStyleBackColor = true;
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(22, 139);
            Label3.Name = "Label3";
            Label3.Size = new Size(72, 15);
            Label3.TabIndex = 2;
            Label3.Text = "Descripción:";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(20, 86);
            Label2.Name = "Label2";
            Label2.Size = new Size(74, 15);
            Label2.TabIndex = 1;
            Label2.Text = "Nombre Rol:";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(31, 32);
            Label1.Name = "Label1";
            Label1.Size = new Size(37, 15);
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
            ClientSize = new Size(800, 450);
            Controls.Add(DataGridView1);
            Controls.Add(GroupBox1);
            Name = "roles";
            Text = "roles";
            GroupBox1.ResumeLayout(false);
            GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        internal GroupBox GroupBox1;
        internal TextBox TextBox3;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal Button Button1;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Nombre;
        internal DataGridViewTextBoxColumn Apellido;
        internal DataGridViewTextBoxColumn Descripcion;
    }
}