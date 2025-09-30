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
            checkedListBox1 = new CheckedListBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox3 = new ComboBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Button1
            // 
            Button1.FlatAppearance.BorderSize = 0;
            Button1.FlatAppearance.MouseOverBackColor = SystemColors.ActiveBorder;
            Button1.FlatStyle = FlatStyle.Flat;
            Button1.Location = new Point(165, 230);
            Button1.Name = "Button1";
            Button1.Size = new Size(75, 23);
            Button1.TabIndex = 8;
            Button1.Text = "Guardar";
            Button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.CornflowerBlue;
            label3.Location = new Point(18, 120);
            label3.Name = "label3";
            label3.Size = new Size(101, 17);
            label3.TabIndex = 7;
            label3.Text = "Fecha de ingreso";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.CornflowerBlue;
            groupBox1.Controls.Add(Button1);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(comboBox3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(179, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(434, 259);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Inventario";
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Activo", "Inactivo" });
            checkedListBox1.Location = new Point(124, 150);
            checkedListBox1.Margin = new Padding(3, 2, 3, 2);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(104, 24);
            checkedListBox1.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(141, 120);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(239, 25);
            dateTimePicker1.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(146, 197);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(137, 25);
            comboBox3.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Metros", "Centimetros", "Milimetros" });
            comboBox1.Location = new Point(145, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 25);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(146, 42);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(136, 25);
            textBox1.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 197);
            label5.Name = "label5";
            label5.Size = new Size(64, 17);
            label5.TabIndex = 4;
            label5.Text = "Proveedor";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 150);
            label4.Name = "label4";
            label4.Size = new Size(48, 17);
            label4.TabIndex = 3;
            label4.Text = "Estado ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 83);
            label2.Name = "label2";
            label2.Size = new Size(110, 17);
            label2.TabIndex = 1;
            label2.Text = "Unidad de medida";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 44);
            label1.Name = "label1";
            label1.Size = new Size(108, 17);
            label1.TabIndex = 0;
            label1.Text = "Nombre Producto";
            // 
            // inventario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
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
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private CheckedListBox checkedListBox1;
    }
}