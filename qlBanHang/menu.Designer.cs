namespace qlBanHang
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menu));
            this.menuTransityon = new System.Windows.Forms.Timer(this.components);
            this.timertxt2 = new System.Windows.Forms.Timer(this.components);
            this.txtsales = new System.Windows.Forms.Label();
            this.txtwel = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnDangXuat = new Guna.UI2.WinForms.Guna2Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.btnAbout = new Guna.UI2.WinForms.Guna2Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHelp = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btngoods = new Guna.UI2.WinForms.Guna2Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnmanage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button = new System.Windows.Forms.PictureBox();
            this.pbx = new System.Windows.Forms.PictureBox();
            this.timeText = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.thunho = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).BeginInit();
            this.sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunho)).BeginInit();
            this.SuspendLayout();
            // 
            // menuTransityon
            // 
            this.menuTransityon.Interval = 10;
            this.menuTransityon.Tick += new System.EventHandler(this.sidebarTimer_Tick_1);
            // 
            // timertxt2
            // 
            this.timertxt2.Enabled = true;
            this.timertxt2.Interval = 10;
            this.timertxt2.Tick += new System.EventHandler(this.timertxt2_Tick_1);
            // 
            // txtsales
            // 
            this.txtsales.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtsales.AutoSize = true;
            this.txtsales.BackColor = System.Drawing.Color.Transparent;
            this.txtsales.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtsales.Location = new System.Drawing.Point(305, 159);
            this.txtsales.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtsales.Name = "txtsales";
            this.txtsales.Size = new System.Drawing.Size(590, 39);
            this.txtsales.TabIndex = 19;
            this.txtsales.Text = "SALES MANAGEMENT SOFTWARE";
            this.txtsales.Click += new System.EventHandler(this.txtsales_Click);
            // 
            // txtwel
            // 
            this.txtwel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtwel.AutoSize = true;
            this.txtwel.BackColor = System.Drawing.Color.Transparent;
            this.txtwel.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtwel.Location = new System.Drawing.Point(437, 83);
            this.txtwel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtwel.Name = "txtwel";
            this.txtwel.Size = new System.Drawing.Size(314, 39);
            this.txtwel.TabIndex = 20;
            this.txtwel.Text = "WELCOME TO MY";
            this.txtwel.Click += new System.EventHandler(this.txtwel_Click_1);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Black;
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 637);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1121, 2);
            this.panel9.TabIndex = 23;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(1121, 2);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 637);
            this.panel8.TabIndex = 22;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Black;
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 0);
            this.panel11.Margin = new System.Windows.Forms.Padding(2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1131, 2);
            this.panel11.TabIndex = 21;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnDangXuat);
            this.panel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel6.ForeColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(2, 532);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(267, 75);
            this.panel6.TabIndex = 3;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.BorderColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDangXuat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDangXuat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDangXuat.FillColor = System.Drawing.Color.Black;
            this.btnDangXuat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.ImageOffset = new System.Drawing.Point(2, 0);
            this.btnDangXuat.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDangXuat.Location = new System.Drawing.Point(1, -6);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnDangXuat.PressedColor = System.Drawing.Color.Transparent;
            this.btnDangXuat.Size = new System.Drawing.Size(277, 87);
            this.btnDangXuat.TabIndex = 5;
            this.btnDangXuat.Text = "LOGOUT";
            this.btnDangXuat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.btnAbout);
            this.panel10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel10.ForeColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(2, 453);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(267, 75);
            this.panel10.TabIndex = 3;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Transparent;
            this.btnAbout.BorderColor = System.Drawing.Color.Transparent;
            this.btnAbout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAbout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAbout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAbout.FillColor = System.Drawing.Color.Black;
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAbout.ImageSize = new System.Drawing.Size(35, 35);
            this.btnAbout.Location = new System.Drawing.Point(1, -6);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnAbout.PressedColor = System.Drawing.Color.Transparent;
            this.btnAbout.Size = new System.Drawing.Size(277, 87);
            this.btnAbout.TabIndex = 5;
            this.btnAbout.Text = "ABOUT";
            this.btnAbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHelp);
            this.panel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel5.ForeColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(2, 374);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(267, 75);
            this.panel5.TabIndex = 3;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.BorderColor = System.Drawing.Color.Transparent;
            this.btnHelp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHelp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHelp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHelp.FillColor = System.Drawing.Color.Black;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHelp.Location = new System.Drawing.Point(1, -6);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(2);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHelp.PressedColor = System.Drawing.Color.Transparent;
            this.btnHelp.Size = new System.Drawing.Size(277, 87);
            this.btnHelp.TabIndex = 5;
            this.btnHelp.Text = "HELP";
            this.btnHelp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btngoods);
            this.panel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(2, 295);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(267, 75);
            this.panel4.TabIndex = 3;
            // 
            // btngoods
            // 
            this.btngoods.BackColor = System.Drawing.Color.Transparent;
            this.btngoods.BorderColor = System.Drawing.Color.Transparent;
            this.btngoods.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btngoods.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btngoods.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btngoods.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btngoods.FillColor = System.Drawing.Color.Black;
            this.btngoods.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btngoods.ForeColor = System.Drawing.Color.White;
            this.btngoods.Image = ((System.Drawing.Image)(resources.GetObject("btngoods.Image")));
            this.btngoods.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btngoods.ImageSize = new System.Drawing.Size(35, 35);
            this.btngoods.Location = new System.Drawing.Point(1, -6);
            this.btngoods.Margin = new System.Windows.Forms.Padding(2);
            this.btngoods.Name = "btngoods";
            this.btngoods.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btngoods.PressedColor = System.Drawing.Color.Transparent;
            this.btngoods.Size = new System.Drawing.Size(277, 87);
            this.btngoods.TabIndex = 5;
            this.btngoods.Text = "IMPORT";
            this.btngoods.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btngoods.Click += new System.EventHandler(this.btngoods_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnmanage);
            this.panel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(2, 216);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 75);
            this.panel3.TabIndex = 3;
            // 
            // btnmanage
            // 
            this.btnmanage.BackColor = System.Drawing.Color.Transparent;
            this.btnmanage.BorderColor = System.Drawing.Color.Transparent;
            this.btnmanage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmanage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmanage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmanage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmanage.FillColor = System.Drawing.Color.Black;
            this.btnmanage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmanage.ForeColor = System.Drawing.Color.White;
            this.btnmanage.Image = ((System.Drawing.Image)(resources.GetObject("btnmanage.Image")));
            this.btnmanage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmanage.ImageSize = new System.Drawing.Size(35, 35);
            this.btnmanage.Location = new System.Drawing.Point(1, -6);
            this.btnmanage.Margin = new System.Windows.Forms.Padding(2);
            this.btnmanage.Name = "btnmanage";
            this.btnmanage.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnmanage.PressedColor = System.Drawing.Color.Transparent;
            this.btnmanage.Size = new System.Drawing.Size(277, 87);
            this.btnmanage.TabIndex = 5;
            this.btnmanage.Text = "MANAGE";
            this.btnmanage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmanage.Click += new System.EventHandler(this.btnmanage_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(2, 131);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(420, 2);
            this.guna2Panel1.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnHome);
            this.panel7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel7.ForeColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(2, 137);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(267, 75);
            this.panel7.TabIndex = 2;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Black;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHome.Location = new System.Drawing.Point(1, -6);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnHome.PressedColor = System.Drawing.Color.White;
            this.btnHome.Size = new System.Drawing.Size(277, 87);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "HOME";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.button);
            this.panel2.Controls.Add(this.pbx);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 125);
            this.panel2.TabIndex = 2;
            // 
            // button
            // 
            this.button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button.Image = ((System.Drawing.Image)(resources.GetObject("button.Image")));
            this.button.Location = new System.Drawing.Point(9, 26);
            this.button.Margin = new System.Windows.Forms.Padding(2);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(45, 49);
            this.button.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.button.TabIndex = 0;
            this.button.TabStop = false;
            this.button.Click += new System.EventHandler(this.button_Click_1);
            // 
            // pbx
            // 
            this.pbx.Image = ((System.Drawing.Image)(resources.GetObject("pbx.Image")));
            this.pbx.Location = new System.Drawing.Point(11, 39);
            this.pbx.Margin = new System.Windows.Forms.Padding(2);
            this.pbx.Name = "pbx";
            this.pbx.Size = new System.Drawing.Size(34, 37);
            this.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx.TabIndex = 3;
            this.pbx.TabStop = false;
            this.pbx.Click += new System.EventHandler(this.pbx_Click_1);
            // 
            // timeText
            // 
            this.timeText.Enabled = true;
            this.timeText.Interval = 10;
            this.timeText.Tick += new System.EventHandler(this.timeText_Tick);
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.Black;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.guna2Panel1);
            this.sidebar.Controls.Add(this.panel7);
            this.sidebar.Controls.Add(this.panel3);
            this.sidebar.Controls.Add(this.panel4);
            this.sidebar.Controls.Add(this.panel5);
            this.sidebar.Controls.Add(this.panel10);
            this.sidebar.Controls.Add(this.panel6);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 2);
            this.sidebar.Margin = new System.Windows.Forms.Padding(2);
            this.sidebar.MaximumSize = new System.Drawing.Size(268, 1056);
            this.sidebar.MinimumSize = new System.Drawing.Size(69, 1056);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(73, 1056);
            this.sidebar.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Location = new System.Drawing.Point(78, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1038, 569);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1069, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exit
            // 
            this.exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit.BackColor = System.Drawing.Color.White;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(1358, 7);
            this.exit.Margin = new System.Windows.Forms.Padding(2);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(26, 28);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit.TabIndex = 17;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // thunho
            // 
            this.thunho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.thunho.BackColor = System.Drawing.Color.White;
            this.thunho.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thunho.Image = ((System.Drawing.Image)(resources.GetObject("thunho.Image")));
            this.thunho.Location = new System.Drawing.Point(1327, 7);
            this.thunho.Margin = new System.Windows.Forms.Padding(2);
            this.thunho.Name = "thunho";
            this.thunho.Size = new System.Drawing.Size(26, 28);
            this.thunho.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thunho.TabIndex = 18;
            this.thunho.TabStop = false;
            this.thunho.Click += new System.EventHandler(this.thunho_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(97, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1131, 639);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.thunho);
            this.Controls.Add(this.txtsales);
            this.Controls.Add(this.txtwel);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.menu_Load);
            this.panel6.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.button)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx)).EndInit();
            this.sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thunho)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer menuTransityon;
        private System.Windows.Forms.Timer timertxt2;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox thunho;
        private System.Windows.Forms.Label txtsales;
        private System.Windows.Forms.Label txtwel;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel11;
        private Guna.UI2.WinForms.Guna2Button btnDangXuat;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2Button btnAbout;
        private System.Windows.Forms.Panel panel10;
        private Guna.UI2.WinForms.Guna2Button btnHelp;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btngoods;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2Button btnmanage;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox button;
        private System.Windows.Forms.PictureBox pbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Timer timeText;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}