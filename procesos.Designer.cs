namespace INICIO
{
    partial class procesos
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
            Button1 = new Button();
            TextBox4 = new TextBox();
            TextBox3 = new TextBox();
            TextBox2 = new TextBox();
            TextBox1 = new TextBox();
            Label4 = new Label();
            Label3 = new Label();
            Label2 = new Label();
            Label1 = new Label();
            DataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.SteelBlue;
            groupBox1.Controls.Add(Button1);
            groupBox1.Controls.Add(TextBox4);
            groupBox1.Controls.Add(TextBox3);
            groupBox1.Controls.Add(TextBox2);
            groupBox1.Controls.Add(TextBox1);
            groupBox1.Controls.Add(Label4);
            groupBox1.Controls.Add(Label3);
            groupBox1.Controls.Add(Label2);
            groupBox1.Controls.Add(Label1);
            groupBox1.Location = new Point(250, 57);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(425, 320);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesos";
            // 
            // Button1
            // 
            Button1.Location = new Point(150, 259);
            Button1.Margin = new Padding(3, 4, 3, 4);
            Button1.Name = "Button1";
            Button1.Size = new Size(86, 31);
            Button1.TabIndex = 17;
            Button1.Text = "Guardar Proceso";
            Button1.UseVisualStyleBackColor = true;
            // 
            // TextBox4
            // 
            TextBox4.Location = new Point(230, 185);
            TextBox4.Margin = new Padding(3, 4, 3, 4);
            TextBox4.Name = "TextBox4";
            TextBox4.Size = new Size(114, 27);
            TextBox4.TabIndex = 16;
            // 
            // TextBox3
            // 
            TextBox3.Location = new Point(230, 128);
            TextBox3.Margin = new Padding(3, 4, 3, 4);
            TextBox3.Name = "TextBox3";
            TextBox3.Size = new Size(114, 27);
            TextBox3.TabIndex = 15;
            // 
            // TextBox2
            // 
            TextBox2.Location = new Point(230, 79);
            TextBox2.Margin = new Padding(3, 4, 3, 4);
            TextBox2.Name = "TextBox2";
            TextBox2.Size = new Size(114, 27);
            TextBox2.TabIndex = 14;
            // 
            // TextBox1
            // 
            TextBox1.Location = new Point(230, 31);
            TextBox1.Margin = new Padding(3, 4, 3, 4);
            TextBox1.Name = "TextBox1";
            TextBox1.Size = new Size(114, 27);
            TextBox1.TabIndex = 13;
            // 
            // Label4
            // 
            Label4.AutoSize = true;
            Label4.Location = new Point(82, 189);
            Label4.Name = "Label4";
            Label4.Size = new Size(62, 20);
            Label4.TabIndex = 12;
            Label4.Text = "Usuario:";
            // 
            // Label3
            // 
            Label3.AutoSize = true;
            Label3.Location = new Point(82, 139);
            Label3.Name = "Label3";
            Label3.Size = new Size(87, 20);
            Label3.TabIndex = 11;
            Label3.Text = "Descripción";
            // 
            // Label2
            // 
            Label2.AutoSize = true;
            Label2.Location = new Point(82, 89);
            Label2.Name = "Label2";
            Label2.Size = new Size(145, 20);
            Label2.TabIndex = 10;
            Label2.Text = "Nombre del Proceso";
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(82, 41);
            Label1.Name = "Label1";
            Label1.Size = new Size(78, 20);
            Label1.TabIndex = 9;
            Label1.Text = "Id Proceso";
            // 
            // DataGridView1
            // 
            DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            DataGridView1.Location = new Point(203, 423);
            DataGridView1.Margin = new Padding(3, 4, 3, 4);
            DataGridView1.Name = "DataGridView1";
            DataGridView1.RowHeadersWidth = 51;
            DataGridView1.Size = new Size(521, 99);
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
            // procesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(DataGridView1);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "procesos";
            Text = "procesos";
            Load += procesos_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        internal Button Button1;
        internal TextBox TextBox4;
        internal TextBox TextBox3;
        internal TextBox TextBox2;
        internal TextBox TextBox1;
        internal Label Label4;
        internal Label Label3;
        internal Label Label2;
        internal Label Label1;
        internal DataGridView DataGridView1;
        internal DataGridViewTextBoxColumn Column1;
        internal DataGridViewTextBoxColumn Column2;
        internal DataGridViewTextBoxColumn Column3;
        internal DataGridViewTextBoxColumn Column4;
    }
}