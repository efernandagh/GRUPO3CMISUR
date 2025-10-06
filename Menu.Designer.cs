namespace INICIO
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            pictureBox2 = new PictureBox();
            Barradetitulo = new Panel();
            btncerrar = new Button();
            Menuvertical = new Panel();
            panel1 = new Panel();
            menuinvent = new Panel();
            btnprovee = new Button();
            btninvent2 = new Button();
            btninvent = new Button();
            menuservi = new Panel();
            btnclien = new Button();
            btnservi2 = new Button();
            btnservi = new Button();
            menupa = new Panel();
            btnproc = new Button();
            btncontr = new Button();
            btnsegui = new Button();
            btnproy3 = new Button();
            btnpro = new Button();
            submenuinvenatario = new Panel();
            btnproveedores = new Button();
            btninventario2 = new Button();
            btninventario = new Button();
            Submenuservicios = new Panel();
            btnclientes = new Button();
            btnservicios2 = new Button();
            btnservicios = new Button();
            Submenuproyectos = new Panel();
            btnprocesos = new Button();
            btncontratos = new Button();
            btnseguimiento = new Button();
            btnproyectoinventario = new Button();
            btnproyectos = new Button();
            Panelcontenedor = new Panel();
            panel9 = new Panel();
            ssubmenuadmin = new Panel();
            btnusuarios = new Button();
            btnroles = new Button();
            btnadmin = new Button();
            submenufacturacion = new Panel();
            btnpagos = new Button();
            btnfacturas = new Button();
            btnfacturacion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Barradetitulo.SuspendLayout();
            Menuvertical.SuspendLayout();
            panel1.SuspendLayout();
            menuinvent.SuspendLayout();
            menuservi.SuspendLayout();
            menupa.SuspendLayout();
            submenuinvenatario.SuspendLayout();
            Submenuservicios.SuspendLayout();
            Submenuproyectos.SuspendLayout();
            panel9.SuspendLayout();
            ssubmenuadmin.SuspendLayout();
            submenufacturacion.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calisto MT", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 12);
            label1.Name = "label1";
            label1.Size = new Size(137, 47);
            label1.TabIndex = 0;
            label1.Text = "MENÚ";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(3, 4);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(79, 93);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // Barradetitulo
            // 
            Barradetitulo.BackColor = Color.SteelBlue;
            Barradetitulo.Controls.Add(btncerrar);
            Barradetitulo.Controls.Add(label1);
            Barradetitulo.Controls.Add(pictureBox2);
            Barradetitulo.Dock = DockStyle.Top;
            Barradetitulo.Location = new Point(0, 0);
            Barradetitulo.Margin = new Padding(3, 4, 3, 4);
            Barradetitulo.Name = "Barradetitulo";
            Barradetitulo.Size = new Size(1027, 79);
            Barradetitulo.TabIndex = 19;
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.SteelBlue;
            btncerrar.BackgroundImage = (Image)resources.GetObject("btncerrar.BackgroundImage");
            btncerrar.FlatAppearance.BorderColor = Color.LightSkyBlue;
            btncerrar.FlatAppearance.BorderSize = 0;
            btncerrar.FlatAppearance.MouseDownBackColor = Color.LightSkyBlue;
            btncerrar.FlatAppearance.MouseOverBackColor = Color.LightSkyBlue;
            btncerrar.FlatStyle = FlatStyle.Flat;
            btncerrar.Location = new Point(978, 16);
            btncerrar.Margin = new Padding(3, 4, 3, 4);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(35, 43);
            btncerrar.TabIndex = 30;
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // Menuvertical
            // 
            Menuvertical.BackColor = Color.CornflowerBlue;
            Menuvertical.Controls.Add(panel1);
            Menuvertical.Controls.Add(submenuinvenatario);
            Menuvertical.Controls.Add(btninventario);
            Menuvertical.Controls.Add(Submenuservicios);
            Menuvertical.Controls.Add(btnservicios);
            Menuvertical.Controls.Add(Submenuproyectos);
            Menuvertical.Controls.Add(btnproyectos);
            Menuvertical.Dock = DockStyle.Left;
            Menuvertical.Location = new Point(0, 79);
            Menuvertical.Margin = new Padding(3, 4, 3, 4);
            Menuvertical.Name = "Menuvertical";
            Menuvertical.Size = new Size(173, 572);
            Menuvertical.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(menuinvent);
            panel1.Controls.Add(btninvent);
            panel1.Controls.Add(menuservi);
            panel1.Controls.Add(btnservi);
            panel1.Controls.Add(menupa);
            panel1.Controls.Add(btnpro);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(173, 572);
            panel1.TabIndex = 27;
            // 
            // menuinvent
            // 
            menuinvent.BackColor = Color.CornflowerBlue;
            menuinvent.Controls.Add(btnprovee);
            menuinvent.Controls.Add(btninvent2);
            menuinvent.Location = new Point(32, 440);
            menuinvent.Margin = new Padding(3, 4, 3, 4);
            menuinvent.Name = "menuinvent";
            menuinvent.Size = new Size(141, 100);
            menuinvent.TabIndex = 26;
            menuinvent.Visible = false;
            // 
            // btnprovee
            // 
            btnprovee.FlatAppearance.BorderSize = 0;
            btnprovee.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnprovee.FlatStyle = FlatStyle.Flat;
            btnprovee.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnprovee.ForeColor = Color.White;
            btnprovee.Location = new Point(14, 48);
            btnprovee.Margin = new Padding(3, 4, 3, 4);
            btnprovee.Name = "btnprovee";
            btnprovee.Size = new Size(105, 31);
            btnprovee.TabIndex = 20;
            btnprovee.Text = "Proveedores";
            btnprovee.UseVisualStyleBackColor = true;
            btnprovee.Click += btnprovee_Click;
            // 
            // btninvent2
            // 
            btninvent2.FlatAppearance.BorderSize = 0;
            btninvent2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btninvent2.FlatStyle = FlatStyle.Flat;
            btninvent2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btninvent2.ForeColor = Color.White;
            btninvent2.Location = new Point(3, 9);
            btninvent2.Margin = new Padding(3, 4, 3, 4);
            btninvent2.Name = "btninvent2";
            btninvent2.Size = new Size(134, 31);
            btninvent2.TabIndex = 19;
            btninvent2.Text = "Inventario";
            btninvent2.UseVisualStyleBackColor = true;
            btninvent2.Click += btninvent2_Click;
            // 
            // btninvent
            // 
            btninvent.BackColor = Color.CornflowerBlue;
            btninvent.FlatAppearance.BorderSize = 0;
            btninvent.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btninvent.FlatStyle = FlatStyle.Flat;
            btninvent.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninvent.ForeColor = Color.White;
            btninvent.Location = new Point(14, 401);
            btninvent.Margin = new Padding(3, 4, 3, 4);
            btninvent.Name = "btninvent";
            btninvent.Size = new Size(103, 31);
            btninvent.TabIndex = 25;
            btninvent.Text = "Inventarios";
            btninvent.UseVisualStyleBackColor = false;
            btninvent.Click += btninvent_Click;
            // 
            // menuservi
            // 
            menuservi.BackColor = Color.CornflowerBlue;
            menuservi.Controls.Add(btnclien);
            menuservi.Controls.Add(btnservi2);
            menuservi.Location = new Point(32, 275);
            menuservi.Margin = new Padding(3, 4, 3, 4);
            menuservi.Name = "menuservi";
            menuservi.Size = new Size(141, 100);
            menuservi.TabIndex = 24;
            menuservi.Visible = false;
            // 
            // btnclien
            // 
            btnclien.FlatAppearance.BorderSize = 0;
            btnclien.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnclien.FlatStyle = FlatStyle.Flat;
            btnclien.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnclien.ForeColor = Color.White;
            btnclien.Location = new Point(22, 48);
            btnclien.Margin = new Padding(3, 4, 3, 4);
            btnclien.Name = "btnclien";
            btnclien.Size = new Size(97, 31);
            btnclien.TabIndex = 20;
            btnclien.Text = "Clientes";
            btnclien.UseVisualStyleBackColor = true;
            btnclien.Click += btnclien_Click;
            // 
            // btnservi2
            // 
            btnservi2.FlatAppearance.BorderSize = 0;
            btnservi2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnservi2.FlatStyle = FlatStyle.Flat;
            btnservi2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnservi2.ForeColor = Color.White;
            btnservi2.Location = new Point(3, 9);
            btnservi2.Margin = new Padding(3, 4, 3, 4);
            btnservi2.Name = "btnservi2";
            btnservi2.Size = new Size(134, 31);
            btnservi2.TabIndex = 19;
            btnservi2.Text = "Servicios";
            btnservi2.UseVisualStyleBackColor = true;
            btnservi2.Click += btnservi2_Click;
            // 
            // btnservi
            // 
            btnservi.BackColor = Color.CornflowerBlue;
            btnservi.FlatAppearance.BorderSize = 0;
            btnservi.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnservi.FlatStyle = FlatStyle.Flat;
            btnservi.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnservi.ForeColor = Color.White;
            btnservi.Location = new Point(14, 236);
            btnservi.Margin = new Padding(3, 4, 3, 4);
            btnservi.Name = "btnservi";
            btnservi.Size = new Size(86, 31);
            btnservi.TabIndex = 23;
            btnservi.Text = "Servicios";
            btnservi.UseVisualStyleBackColor = false;
            btnservi.Click += btnservi_Click;
            // 
            // menupa
            // 
            menupa.BackColor = Color.CornflowerBlue;
            menupa.Controls.Add(btnproc);
            menupa.Controls.Add(btncontr);
            menupa.Controls.Add(btnsegui);
            menupa.Controls.Add(btnproy3);
            menupa.Location = new Point(32, 59);
            menupa.Margin = new Padding(3, 4, 3, 4);
            menupa.Name = "menupa";
            menupa.Size = new Size(141, 169);
            menupa.TabIndex = 22;
            menupa.Visible = false;
            menupa.Paint += panel4_Paint;
            // 
            // btnproc
            // 
            btnproc.FlatAppearance.BorderSize = 0;
            btnproc.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnproc.FlatStyle = FlatStyle.Flat;
            btnproc.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnproc.ForeColor = Color.White;
            btnproc.Location = new Point(18, 125);
            btnproc.Margin = new Padding(3, 4, 3, 4);
            btnproc.Name = "btnproc";
            btnproc.Size = new Size(86, 31);
            btnproc.TabIndex = 22;
            btnproc.Text = "Procesos";
            btnproc.UseVisualStyleBackColor = true;
            btnproc.Click += btnproc_Click;
            // 
            // btncontr
            // 
            btncontr.FlatAppearance.BorderSize = 0;
            btncontr.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btncontr.FlatStyle = FlatStyle.Flat;
            btncontr.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btncontr.ForeColor = Color.White;
            btncontr.Location = new Point(22, 87);
            btncontr.Margin = new Padding(3, 4, 3, 4);
            btncontr.Name = "btncontr";
            btncontr.Size = new Size(86, 31);
            btncontr.TabIndex = 21;
            btncontr.Text = "Contratos";
            btncontr.UseVisualStyleBackColor = true;
            btncontr.Click += btncontr_Click;
            // 
            // btnsegui
            // 
            btnsegui.FlatAppearance.BorderSize = 0;
            btnsegui.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnsegui.FlatStyle = FlatStyle.Flat;
            btnsegui.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnsegui.ForeColor = Color.White;
            btnsegui.Location = new Point(14, 48);
            btnsegui.Margin = new Padding(3, 4, 3, 4);
            btnsegui.Name = "btnsegui";
            btnsegui.Size = new Size(116, 31);
            btnsegui.TabIndex = 20;
            btnsegui.Text = "Seguimiento";
            btnsegui.UseVisualStyleBackColor = true;
            btnsegui.Click += btnsegui_Click;
            // 
            // btnproy3
            // 
            btnproy3.FlatAppearance.BorderSize = 0;
            btnproy3.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnproy3.FlatStyle = FlatStyle.Flat;
            btnproy3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnproy3.ForeColor = Color.White;
            btnproy3.Location = new Point(3, 9);
            btnproy3.Margin = new Padding(3, 4, 3, 4);
            btnproy3.Name = "btnproy3";
            btnproy3.Size = new Size(116, 31);
            btnproy3.TabIndex = 19;
            btnproy3.Text = "Proyecto inventario";
            btnproy3.UseVisualStyleBackColor = true;
            btnproy3.Click += btnproy3_Click;
            // 
            // btnpro
            // 
            btnpro.BackColor = Color.CornflowerBlue;
            btnpro.FlatAppearance.BorderSize = 0;
            btnpro.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnpro.FlatStyle = FlatStyle.Flat;
            btnpro.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnpro.ForeColor = Color.White;
            btnpro.Location = new Point(14, 20);
            btnpro.Margin = new Padding(3, 4, 3, 4);
            btnpro.Name = "btnpro";
            btnpro.Size = new Size(103, 31);
            btnpro.TabIndex = 19;
            btnpro.Text = "Proyectos";
            btnpro.UseVisualStyleBackColor = false;
            btnpro.Click += button11_Click;
            // 
            // submenuinvenatario
            // 
            submenuinvenatario.BackColor = Color.CornflowerBlue;
            submenuinvenatario.Controls.Add(btnproveedores);
            submenuinvenatario.Controls.Add(btninventario2);
            submenuinvenatario.Location = new Point(32, 440);
            submenuinvenatario.Margin = new Padding(3, 4, 3, 4);
            submenuinvenatario.Name = "submenuinvenatario";
            submenuinvenatario.Size = new Size(141, 100);
            submenuinvenatario.TabIndex = 26;
            submenuinvenatario.Visible = false;
            // 
            // btnproveedores
            // 
            btnproveedores.FlatAppearance.BorderSize = 0;
            btnproveedores.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnproveedores.FlatStyle = FlatStyle.Flat;
            btnproveedores.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnproveedores.ForeColor = Color.White;
            btnproveedores.Location = new Point(22, 48);
            btnproveedores.Margin = new Padding(3, 4, 3, 4);
            btnproveedores.Name = "btnproveedores";
            btnproveedores.Size = new Size(97, 31);
            btnproveedores.TabIndex = 20;
            btnproveedores.Text = "Proveedores";
            btnproveedores.UseVisualStyleBackColor = true;
            btnproveedores.Click += btnproveedores_Click;
            // 
            // btninventario2
            // 
            btninventario2.FlatAppearance.BorderSize = 0;
            btninventario2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btninventario2.FlatStyle = FlatStyle.Flat;
            btninventario2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btninventario2.ForeColor = Color.White;
            btninventario2.Location = new Point(3, 9);
            btninventario2.Margin = new Padding(3, 4, 3, 4);
            btninventario2.Name = "btninventario2";
            btninventario2.Size = new Size(144, 31);
            btninventario2.TabIndex = 19;
            btninventario2.Text = "Inventario";
            btninventario2.UseVisualStyleBackColor = true;
            btninventario2.Click += btninventario2_Click;
            // 
            // btninventario
            // 
            btninventario.BackColor = Color.CornflowerBlue;
            btninventario.FlatAppearance.BorderSize = 0;
            btninventario.FlatAppearance.MouseOverBackColor = Color.CornflowerBlue;
            btninventario.FlatStyle = FlatStyle.Flat;
            btninventario.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btninventario.ForeColor = Color.White;
            btninventario.Location = new Point(14, 401);
            btninventario.Margin = new Padding(3, 4, 3, 4);
            btninventario.Name = "btninventario";
            btninventario.Size = new Size(103, 31);
            btninventario.TabIndex = 25;
            btninventario.Text = "Inventarios";
            btninventario.UseVisualStyleBackColor = false;
            btninventario.Click += btninventario_Click;
            // 
            // Submenuservicios
            // 
            Submenuservicios.BackColor = Color.CornflowerBlue;
            Submenuservicios.Controls.Add(btnclientes);
            Submenuservicios.Controls.Add(btnservicios2);
            Submenuservicios.Location = new Point(32, 275);
            Submenuservicios.Margin = new Padding(3, 4, 3, 4);
            Submenuservicios.Name = "Submenuservicios";
            Submenuservicios.Size = new Size(141, 100);
            Submenuservicios.TabIndex = 24;
            Submenuservicios.Visible = false;
            // 
            // btnclientes
            // 
            btnclientes.FlatAppearance.BorderSize = 0;
            btnclientes.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnclientes.FlatStyle = FlatStyle.Flat;
            btnclientes.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnclientes.ForeColor = Color.White;
            btnclientes.Location = new Point(22, 48);
            btnclientes.Margin = new Padding(3, 4, 3, 4);
            btnclientes.Name = "btnclientes";
            btnclientes.Size = new Size(97, 31);
            btnclientes.TabIndex = 20;
            btnclientes.Text = "Clientes";
            btnclientes.UseVisualStyleBackColor = true;
            btnclientes.Click += btnclientes_Click;
            // 
            // btnservicios2
            // 
            btnservicios2.FlatAppearance.BorderSize = 0;
            btnservicios2.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnservicios2.FlatStyle = FlatStyle.Flat;
            btnservicios2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnservicios2.ForeColor = Color.White;
            btnservicios2.Location = new Point(3, 9);
            btnservicios2.Margin = new Padding(3, 4, 3, 4);
            btnservicios2.Name = "btnservicios2";
            btnservicios2.Size = new Size(144, 31);
            btnservicios2.TabIndex = 19;
            btnservicios2.Text = "Servicios";
            btnservicios2.UseVisualStyleBackColor = true;
            btnservicios2.Click += btnservicios2_Click;
            // 
            // btnservicios
            // 
            btnservicios.BackColor = Color.CornflowerBlue;
            btnservicios.FlatAppearance.BorderSize = 0;
            btnservicios.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnservicios.FlatStyle = FlatStyle.Flat;
            btnservicios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnservicios.ForeColor = Color.White;
            btnservicios.Location = new Point(14, 236);
            btnservicios.Margin = new Padding(3, 4, 3, 4);
            btnservicios.Name = "btnservicios";
            btnservicios.Size = new Size(86, 31);
            btnservicios.TabIndex = 23;
            btnservicios.Text = "Servicios";
            btnservicios.UseVisualStyleBackColor = false;
            btnservicios.Click += btnservicios_Click;
            // 
            // Submenuproyectos
            // 
            Submenuproyectos.BackColor = Color.CornflowerBlue;
            Submenuproyectos.Controls.Add(btnprocesos);
            Submenuproyectos.Controls.Add(btncontratos);
            Submenuproyectos.Controls.Add(btnseguimiento);
            Submenuproyectos.Controls.Add(btnproyectoinventario);
            Submenuproyectos.Location = new Point(32, 59);
            Submenuproyectos.Margin = new Padding(3, 4, 3, 4);
            Submenuproyectos.Name = "Submenuproyectos";
            Submenuproyectos.Size = new Size(141, 169);
            Submenuproyectos.TabIndex = 22;
            Submenuproyectos.Visible = false;
            // 
            // btnprocesos
            // 
            btnprocesos.FlatAppearance.BorderSize = 0;
            btnprocesos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnprocesos.FlatStyle = FlatStyle.Flat;
            btnprocesos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnprocesos.ForeColor = Color.White;
            btnprocesos.Location = new Point(18, 125);
            btnprocesos.Margin = new Padding(3, 4, 3, 4);
            btnprocesos.Name = "btnprocesos";
            btnprocesos.Size = new Size(86, 31);
            btnprocesos.TabIndex = 22;
            btnprocesos.Text = "Procesos";
            btnprocesos.UseVisualStyleBackColor = true;
            btnprocesos.Click += btnprocesos_Click;
            // 
            // btncontratos
            // 
            btncontratos.FlatAppearance.BorderSize = 0;
            btncontratos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btncontratos.FlatStyle = FlatStyle.Flat;
            btncontratos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btncontratos.ForeColor = Color.White;
            btncontratos.Location = new Point(22, 87);
            btncontratos.Margin = new Padding(3, 4, 3, 4);
            btncontratos.Name = "btncontratos";
            btncontratos.Size = new Size(86, 31);
            btncontratos.TabIndex = 21;
            btncontratos.Text = "Contratos";
            btncontratos.UseVisualStyleBackColor = true;
            btncontratos.Click += btncontratos_Click;
            // 
            // btnseguimiento
            // 
            btnseguimiento.FlatAppearance.BorderSize = 0;
            btnseguimiento.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnseguimiento.FlatStyle = FlatStyle.Flat;
            btnseguimiento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnseguimiento.ForeColor = Color.White;
            btnseguimiento.Location = new Point(22, 48);
            btnseguimiento.Margin = new Padding(3, 4, 3, 4);
            btnseguimiento.Name = "btnseguimiento";
            btnseguimiento.Size = new Size(97, 31);
            btnseguimiento.TabIndex = 20;
            btnseguimiento.Text = "Seguimiento";
            btnseguimiento.UseVisualStyleBackColor = true;
            btnseguimiento.Click += btnseguimiento_Click;
            // 
            // btnproyectoinventario
            // 
            btnproyectoinventario.FlatAppearance.BorderSize = 0;
            btnproyectoinventario.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnproyectoinventario.FlatStyle = FlatStyle.Flat;
            btnproyectoinventario.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnproyectoinventario.ForeColor = Color.White;
            btnproyectoinventario.Location = new Point(3, 9);
            btnproyectoinventario.Margin = new Padding(3, 4, 3, 4);
            btnproyectoinventario.Name = "btnproyectoinventario";
            btnproyectoinventario.Size = new Size(144, 31);
            btnproyectoinventario.TabIndex = 19;
            btnproyectoinventario.Text = "Proyecto inventario";
            btnproyectoinventario.UseVisualStyleBackColor = true;
            btnproyectoinventario.Click += btnproyectoinventario_Click;
            // 
            // btnproyectos
            // 
            btnproyectos.BackColor = Color.CornflowerBlue;
            btnproyectos.FlatAppearance.BorderSize = 0;
            btnproyectos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnproyectos.FlatStyle = FlatStyle.Flat;
            btnproyectos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnproyectos.ForeColor = Color.White;
            btnproyectos.Location = new Point(14, 20);
            btnproyectos.Margin = new Padding(3, 4, 3, 4);
            btnproyectos.Name = "btnproyectos";
            btnproyectos.Size = new Size(86, 31);
            btnproyectos.TabIndex = 19;
            btnproyectos.Text = "Proyectos";
            btnproyectos.UseVisualStyleBackColor = false;
            btnproyectos.Click += btnproyectos_Click;
            // 
            // Panelcontenedor
            // 
            Panelcontenedor.BackColor = Color.Gray;
            Panelcontenedor.Location = new Point(0, 79);
            Panelcontenedor.Margin = new Padding(3, 4, 3, 4);
            Panelcontenedor.Name = "Panelcontenedor";
            Panelcontenedor.Size = new Size(855, 572);
            Panelcontenedor.TabIndex = 21;
            Panelcontenedor.Paint += Panelcontenedor_Paint;
            // 
            // panel9
            // 
            panel9.BackColor = Color.CornflowerBlue;
            panel9.Controls.Add(ssubmenuadmin);
            panel9.Controls.Add(btnadmin);
            panel9.Controls.Add(submenufacturacion);
            panel9.Controls.Add(btnfacturacion);
            panel9.Location = new Point(855, 79);
            panel9.Margin = new Padding(3, 4, 3, 4);
            panel9.Name = "panel9";
            panel9.Size = new Size(173, 572);
            panel9.TabIndex = 29;
            // 
            // ssubmenuadmin
            // 
            ssubmenuadmin.BackColor = Color.CornflowerBlue;
            ssubmenuadmin.Controls.Add(btnusuarios);
            ssubmenuadmin.Controls.Add(btnroles);
            ssubmenuadmin.Location = new Point(7, 236);
            ssubmenuadmin.Margin = new Padding(3, 4, 3, 4);
            ssubmenuadmin.Name = "ssubmenuadmin";
            ssubmenuadmin.Size = new Size(141, 100);
            ssubmenuadmin.TabIndex = 29;
            ssubmenuadmin.Visible = false;
            // 
            // btnusuarios
            // 
            btnusuarios.FlatAppearance.BorderSize = 0;
            btnusuarios.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnusuarios.FlatStyle = FlatStyle.Flat;
            btnusuarios.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnusuarios.ForeColor = Color.White;
            btnusuarios.Location = new Point(22, 48);
            btnusuarios.Margin = new Padding(3, 4, 3, 4);
            btnusuarios.Name = "btnusuarios";
            btnusuarios.Size = new Size(97, 31);
            btnusuarios.TabIndex = 20;
            btnusuarios.Text = "Usuarios";
            btnusuarios.UseVisualStyleBackColor = true;
            btnusuarios.Click += btnusuarios_Click;
            // 
            // btnroles
            // 
            btnroles.FlatAppearance.BorderSize = 0;
            btnroles.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnroles.FlatStyle = FlatStyle.Flat;
            btnroles.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnroles.ForeColor = Color.White;
            btnroles.Location = new Point(3, 9);
            btnroles.Margin = new Padding(3, 4, 3, 4);
            btnroles.Name = "btnroles";
            btnroles.Size = new Size(134, 31);
            btnroles.TabIndex = 19;
            btnroles.Text = "Roles";
            btnroles.UseVisualStyleBackColor = true;
            btnroles.Click += btnroles_Click;
            // 
            // btnadmin
            // 
            btnadmin.BackColor = Color.CornflowerBlue;
            btnadmin.FlatAppearance.BorderSize = 0;
            btnadmin.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnadmin.FlatStyle = FlatStyle.Flat;
            btnadmin.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnadmin.ForeColor = Color.White;
            btnadmin.Location = new Point(10, 197);
            btnadmin.Margin = new Padding(3, 4, 3, 4);
            btnadmin.Name = "btnadmin";
            btnadmin.Size = new Size(143, 31);
            btnadmin.TabIndex = 29;
            btnadmin.Text = "Administracion";
            btnadmin.UseVisualStyleBackColor = false;
            btnadmin.Click += btnadmin_Click;
            // 
            // submenufacturacion
            // 
            submenufacturacion.BackColor = Color.CornflowerBlue;
            submenufacturacion.Controls.Add(btnpagos);
            submenufacturacion.Controls.Add(btnfacturas);
            submenufacturacion.Location = new Point(3, 59);
            submenufacturacion.Margin = new Padding(3, 4, 3, 4);
            submenufacturacion.Name = "submenufacturacion";
            submenufacturacion.Size = new Size(141, 100);
            submenufacturacion.TabIndex = 28;
            submenufacturacion.Visible = false;
            // 
            // btnpagos
            // 
            btnpagos.FlatAppearance.BorderSize = 0;
            btnpagos.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnpagos.FlatStyle = FlatStyle.Flat;
            btnpagos.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnpagos.ForeColor = Color.White;
            btnpagos.Location = new Point(22, 48);
            btnpagos.Margin = new Padding(3, 4, 3, 4);
            btnpagos.Name = "btnpagos";
            btnpagos.Size = new Size(97, 31);
            btnpagos.TabIndex = 20;
            btnpagos.Text = "Pagos";
            btnpagos.UseVisualStyleBackColor = true;
            btnpagos.Click += btnpagos_Click;
            // 
            // btnfacturas
            // 
            btnfacturas.FlatAppearance.BorderSize = 0;
            btnfacturas.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnfacturas.FlatStyle = FlatStyle.Flat;
            btnfacturas.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            btnfacturas.ForeColor = Color.White;
            btnfacturas.Location = new Point(3, 9);
            btnfacturas.Margin = new Padding(3, 4, 3, 4);
            btnfacturas.Name = "btnfacturas";
            btnfacturas.Size = new Size(134, 31);
            btnfacturas.TabIndex = 19;
            btnfacturas.Text = "Facturas";
            btnfacturas.UseVisualStyleBackColor = true;
            btnfacturas.Click += btnfacturas_Click;
            // 
            // btnfacturacion
            // 
            btnfacturacion.BackColor = Color.CornflowerBlue;
            btnfacturacion.FlatAppearance.BorderSize = 0;
            btnfacturacion.FlatAppearance.MouseOverBackColor = Color.SteelBlue;
            btnfacturacion.FlatStyle = FlatStyle.Flat;
            btnfacturacion.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnfacturacion.ForeColor = Color.White;
            btnfacturacion.Location = new Point(10, 20);
            btnfacturacion.Margin = new Padding(3, 4, 3, 4);
            btnfacturacion.Name = "btnfacturacion";
            btnfacturacion.Size = new Size(118, 31);
            btnfacturacion.TabIndex = 27;
            btnfacturacion.Text = "Facturacion";
            btnfacturacion.UseVisualStyleBackColor = false;
            btnfacturacion.Click += btnfacturacion_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1027, 651);
            Controls.Add(panel9);
            Controls.Add(Menuvertical);
            Controls.Add(Barradetitulo);
            Controls.Add(Panelcontenedor);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Barradetitulo.ResumeLayout(false);
            Barradetitulo.PerformLayout();
            Menuvertical.ResumeLayout(false);
            panel1.ResumeLayout(false);
            menuinvent.ResumeLayout(false);
            menuservi.ResumeLayout(false);
            menupa.ResumeLayout(false);
            submenuinvenatario.ResumeLayout(false);
            Submenuservicios.ResumeLayout(false);
            Submenuproyectos.ResumeLayout(false);
            panel9.ResumeLayout(false);
            ssubmenuadmin.ResumeLayout(false);
            submenufacturacion.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private PictureBox pictureBox2;
        private Panel Barradetitulo;
        private Panel Menuvertical;
        private Panel Panelcontenedor;
        private Button btnproyectos;
        private Button btnproyectoinventario;
        private Panel Submenuproyectos;
        private Button btncontratos;
        private Button btnseguimiento;
        private Button btnprocesos;
        private Panel Submenuservicios;
        private Button btnclientes;
        private Button btnservicios2;
        private Button btnservicios;
        private Panel submenuinvenatario;
        private Button btnproveedores;
        private Button btninventario2;
        private Button btninventario;
        private Panel panel1;
        private Panel menuinvent;
        private Button btnprovee;
        private Button btninvent2;
        private Button btninvent;
        private Panel menuservi;
        private Button btnclien;
        private Button btnservi2;
        private Button btnservi;
        private Panel menupa;
        private Button btnproc;
        private Button btncontr;
        private Button btnsegui;
        private Button btnproy3;
        private Button btnpro;
        private Panel panel9;
        private Panel submenufacturacion;
        private Button btnpagos;
        private Button btnfacturas;
        private Button btnfacturacion;
        private Panel ssubmenuadmin;
        private Button btnusuarios;
        private Button btnroles;
        private Button btnadmin;
        private Button btncerrar;
    }
}