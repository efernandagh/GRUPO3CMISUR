namespace INICIO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            btnguardar = new Button();
            txtnombre = new TextBox();
            txtcontra = new TextBox();
            button2 = new Button();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(237, 16);
            label1.Name = "label1";
            label1.Size = new Size(154, 22);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            label2.Location = new Point(175, 183);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic);
            label5.Location = new Point(175, 237);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 4;
            label5.Text = "Contraseña";
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.SteelBlue;
            btnguardar.FlatAppearance.BorderColor = Color.SteelBlue;
            btnguardar.FlatAppearance.BorderSize = 0;
            btnguardar.FlatAppearance.CheckedBackColor = Color.SteelBlue;
            btnguardar.FlatAppearance.MouseDownBackColor = Color.SteelBlue;
            btnguardar.FlatStyle = FlatStyle.Flat;
            btnguardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic);
            btnguardar.Location = new Point(257, 313);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(124, 29);
            btnguardar.TabIndex = 5;
            btnguardar.Text = "Ingresar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += button1_Click;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(257, 180);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(134, 23);
            txtnombre.TabIndex = 6;
            txtnombre.TextChanged += txtnombre_TextChanged;
            // 
            // txtcontra
            // 
            txtcontra.Location = new Point(257, 234);
            txtcontra.Name = "txtcontra";
            txtcontra.Size = new Size(134, 23);
            txtcontra.TabIndex = 9;
            txtcontra.TextChanged += txtcontra_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.FlatAppearance.BorderColor = Color.LightSkyBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            button2.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(539, 12);
            button2.Name = "button2";
            button2.Size = new Size(31, 32);
            button2.TabIndex = 12;
            button2.Text = "s";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(582, 57);
            panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(69, 64);
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(286, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 73);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(582, 430);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(btnguardar);
            Controls.Add(txtcontra);
            Controls.Add(txtnombre);
            Controls.Add(label5);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label5;
        private Button btnguardar;
        private TextBox txtnombre;
        private TextBox txtcontra;
        private Button button2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
