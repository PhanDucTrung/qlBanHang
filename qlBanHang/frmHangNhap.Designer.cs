namespace qlBanHang
{
    partial class frmHangNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grHangNhap = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayNhapHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnclear = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbIDNCC = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtTenSP = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtNgayNhap = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMaNhanVien = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSoLuongNhap = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDonGia = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbDv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grHangNhap)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grHangNhap
            // 
            this.grHangNhap.AllowUserToAddRows = false;
            this.grHangNhap.AllowUserToDeleteRows = false;
            this.grHangNhap.AllowUserToResizeColumns = false;
            this.grHangNhap.AllowUserToResizeRows = false;
            this.grHangNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grHangNhap.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.grHangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grHangNhap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grHangNhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grHangNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grHangNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.DonViTinh,
            this.SoLuongNhap,
            this.DonGiaNhap,
            this.MaNCC,
            this.NgayNhapHang,
            this.MaNV});
            this.grHangNhap.EnableHeadersVisualStyles = false;
            this.grHangNhap.GridColor = System.Drawing.Color.DarkGray;
            this.grHangNhap.Location = new System.Drawing.Point(11, 256);
            this.grHangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.grHangNhap.Name = "grHangNhap";
            this.grHangNhap.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grHangNhap.RowHeadersWidth = 51;
            this.grHangNhap.RowTemplate.Height = 24;
            this.grHangNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grHangNhap.Size = new System.Drawing.Size(744, 201);
            this.grHangNhap.TabIndex = 14;
            this.grHangNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grHangNhap_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "ID";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DonViTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.DataPropertyName = "DonGiaNhap";
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            // 
            // NgayNhapHang
            // 
            this.NgayNhapHang.DataPropertyName = "NgayNhapHang";
            this.NgayNhapHang.HeaderText = "Ngày nhập hàng";
            this.NgayNhapHang.MinimumWidth = 6;
            this.NgayNhapHang.Name = "NgayNhapHang";
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã Nhân Viên";
            this.MaNV.Name = "MaNV";
            // 
            // pnlControl
            // 
            this.pnlControl.BorderColor = System.Drawing.Color.Black;
            this.pnlControl.BorderRadius = 30;
            this.pnlControl.BorderThickness = 1;
            this.pnlControl.Controls.Add(this.btnclear);
            this.pnlControl.Controls.Add(this.btnthem);
            this.pnlControl.Controls.Add(this.btnSua);
            this.pnlControl.Location = new System.Drawing.Point(493, 26);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(2);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(224, 166);
            this.pnlControl.TabIndex = 8;
            // 
            // btnclear
            // 
            this.btnclear.AutoRoundedCorners = true;
            this.btnclear.BorderRadius = 17;
            this.btnclear.BorderThickness = 2;
            this.btnclear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnclear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnclear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnclear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnclear.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.Color.Black;
            this.btnclear.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnclear.ImageSize = new System.Drawing.Size(25, 25);
            this.btnclear.Location = new System.Drawing.Point(14, 98);
            this.btnclear.Margin = new System.Windows.Forms.Padding(2);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(91, 37);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "Clear";
            this.btnclear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnthem
            // 
            this.btnthem.AutoRoundedCorners = true;
            this.btnthem.BorderRadius = 17;
            this.btnthem.BorderThickness = 2;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnthem.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.ForeColor = System.Drawing.Color.Black;
            this.btnthem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnthem.Location = new System.Drawing.Point(14, 35);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(91, 37);
            this.btnthem.TabIndex = 3;
            this.btnthem.Text = "Add";
            this.btnthem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 17;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.Enabled = false;
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSua.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Location = new System.Drawing.Point(121, 63);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Edit";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(20, 161);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID NCC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(170, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày nhập hàng:";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gray;
            this.panel8.Location = new System.Drawing.Point(80, 138);
            this.panel8.Margin = new System.Windows.Forms.Padding(2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(122, 2);
            this.panel8.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Location = new System.Drawing.Point(265, 138);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(135, 2);
            this.panel7.TabIndex = 6;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(164, 205);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(149, 2);
            this.panel9.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(23, 205);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(94, 2);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(281, 67);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(106, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(80, 67);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(170, 2);
            this.panel2.TabIndex = 5;
            // 
            // cmbIDNCC
            // 
            this.cmbIDNCC.BackColor = System.Drawing.Color.Transparent;
            this.cmbIDNCC.BorderColor = System.Drawing.Color.Black;
            this.cmbIDNCC.BorderThickness = 0;
            this.cmbIDNCC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbIDNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDNCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbIDNCC.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbIDNCC.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbIDNCC.ForeColor = System.Drawing.Color.Black;
            this.cmbIDNCC.ItemHeight = 30;
            this.cmbIDNCC.Location = new System.Drawing.Point(22, 170);
            this.cmbIDNCC.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIDNCC.Name = "cmbIDNCC";
            this.cmbIDNCC.Size = new System.Drawing.Size(96, 36);
            this.cmbIDNCC.TabIndex = 2;
            // 
            // txtTenSP
            // 
            this.txtTenSP.AutoRoundedCorners = true;
            this.txtTenSP.BackColor = System.Drawing.Color.Transparent;
            this.txtTenSP.BorderColor = System.Drawing.Color.Black;
            this.txtTenSP.BorderRadius = 17;
            this.txtTenSP.BorderThickness = 0;
            this.txtTenSP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenSP.DefaultText = "";
            this.txtTenSP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenSP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenSP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenSP.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtTenSP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtTenSP.ForeColor = System.Drawing.Color.Black;
            this.txtTenSP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenSP.Location = new System.Drawing.Point(80, 37);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.PasswordChar = '\0';
            this.txtTenSP.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtTenSP.PlaceholderText = "Tên sản phẩm";
            this.txtTenSP.SelectedText = "";
            this.txtTenSP.Size = new System.Drawing.Size(170, 37);
            this.txtTenSP.TabIndex = 1;
            this.txtTenSP.TextChanged += new System.EventHandler(this.txtTenSP_TextChanged);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.AutoRoundedCorners = true;
            this.dtNgayNhap.BackColor = System.Drawing.Color.Transparent;
            this.dtNgayNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtNgayNhap.BorderRadius = 13;
            this.dtNgayNhap.Checked = true;
            this.dtNgayNhap.CustomFormat = "yyyy/MM/dd";
            this.dtNgayNhap.FillColor = System.Drawing.Color.White;
            this.dtNgayNhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtNgayNhap.ForeColor = System.Drawing.Color.Black;
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtNgayNhap.Location = new System.Drawing.Point(163, 178);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayNhap.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayNhap.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(149, 29);
            this.dtNgayNhap.TabIndex = 0;
            this.dtNgayNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dtNgayNhap.Value = new System.DateTime(2023, 10, 23, 22, 13, 0, 456);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 40;
            this.guna2Elipse2.TargetControl = this.grHangNhap;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.txtMaNhanVien);
            this.guna2Panel1.Controls.Add(this.pnlControl);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel8);
            this.guna2Panel1.Controls.Add(this.panel7);
            this.guna2Panel1.Controls.Add(this.panel9);
            this.guna2Panel1.Controls.Add(this.panel4);
            this.guna2Panel1.Controls.Add(this.panel3);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.cmbIDNCC);
            this.guna2Panel1.Controls.Add(this.txtSoLuongNhap);
            this.guna2Panel1.Controls.Add(this.txtDonGia);
            this.guna2Panel1.Controls.Add(this.txtTenSP);
            this.guna2Panel1.Controls.Add(this.dtNgayNhap);
            this.guna2Panel1.Controls.Add(this.cmbDv);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Panel1.Location = new System.Drawing.Point(11, 11);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(744, 224);
            this.guna2Panel1.TabIndex = 12;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(350, 161);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "MaNV:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(353, 204);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(67, 2);
            this.panel1.TabIndex = 10;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.AutoRoundedCorners = true;
            this.txtMaNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.txtMaNhanVien.BorderColor = System.Drawing.Color.Black;
            this.txtMaNhanVien.BorderRadius = 17;
            this.txtMaNhanVien.BorderThickness = 0;
            this.txtMaNhanVien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaNhanVien.DefaultText = "";
            this.txtMaNhanVien.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaNhanVien.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaNhanVien.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaNhanVien.Enabled = false;
            this.txtMaNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtMaNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtMaNhanVien.ForeColor = System.Drawing.Color.Black;
            this.txtMaNhanVien.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaNhanVien.Location = new System.Drawing.Point(353, 174);
            this.txtMaNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.PasswordChar = '\0';
            this.txtMaNhanVien.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMaNhanVien.PlaceholderText = "ID";
            this.txtMaNhanVien.SelectedText = "";
            this.txtMaNhanVien.Size = new System.Drawing.Size(67, 37);
            this.txtMaNhanVien.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(79, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(264, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số Lượng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(279, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "đơn vị Tính ";
            // 
            // txtSoLuongNhap
            // 
            this.txtSoLuongNhap.AutoRoundedCorners = true;
            this.txtSoLuongNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuongNhap.BorderColor = System.Drawing.Color.Black;
            this.txtSoLuongNhap.BorderRadius = 17;
            this.txtSoLuongNhap.BorderThickness = 0;
            this.txtSoLuongNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuongNhap.DefaultText = "";
            this.txtSoLuongNhap.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSoLuongNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSoLuongNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSoLuongNhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtSoLuongNhap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtSoLuongNhap.ForeColor = System.Drawing.Color.Black;
            this.txtSoLuongNhap.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSoLuongNhap.Location = new System.Drawing.Point(268, 111);
            this.txtSoLuongNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoLuongNhap.Name = "txtSoLuongNhap";
            this.txtSoLuongNhap.PasswordChar = '\0';
            this.txtSoLuongNhap.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtSoLuongNhap.PlaceholderText = "";
            this.txtSoLuongNhap.SelectedText = "";
            this.txtSoLuongNhap.Size = new System.Drawing.Size(135, 37);
            this.txtSoLuongNhap.TabIndex = 1;
            this.txtSoLuongNhap.TextChanged += new System.EventHandler(this.txtSoLuongNhap_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.AutoRoundedCorners = true;
            this.txtDonGia.BackColor = System.Drawing.Color.Transparent;
            this.txtDonGia.BorderColor = System.Drawing.Color.Black;
            this.txtDonGia.BorderRadius = 17;
            this.txtDonGia.BorderThickness = 0;
            this.txtDonGia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonGia.DefaultText = "";
            this.txtDonGia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDonGia.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDonGia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDonGia.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtDonGia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtDonGia.ForeColor = System.Drawing.Color.Black;
            this.txtDonGia.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDonGia.Location = new System.Drawing.Point(80, 110);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.PasswordChar = '\0';
            this.txtDonGia.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtDonGia.PlaceholderText = "";
            this.txtDonGia.SelectedText = "";
            this.txtDonGia.Size = new System.Drawing.Size(119, 37);
            this.txtDonGia.TabIndex = 1;
            this.txtDonGia.TextChanged += new System.EventHandler(this.txtDonGia_TextChanged);
            // 
            // cmbDv
            // 
            this.cmbDv.AutoRoundedCorners = true;
            this.cmbDv.BackColor = System.Drawing.Color.Transparent;
            this.cmbDv.BorderColor = System.Drawing.Color.Black;
            this.cmbDv.BorderRadius = 17;
            this.cmbDv.BorderThickness = 0;
            this.cmbDv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDv.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbDv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDv.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDv.ForeColor = System.Drawing.Color.Black;
            this.cmbDv.ItemHeight = 30;
            this.cmbDv.Items.AddRange(new object[] {
            "hbehe36j6"});
            this.cmbDv.Location = new System.Drawing.Point(282, 39);
            this.cmbDv.Margin = new System.Windows.Forms.Padding(2);
            this.cmbDv.Name = "cmbDv";
            this.cmbDv.Size = new System.Drawing.Size(105, 36);
            this.cmbDv.TabIndex = 12;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 0;
            this.guna2Elipse1.TargetControl = this;
            // 
            // frmHangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(782, 468);
            this.Controls.Add(this.grHangNhap);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHangNhap";
            this.Text = "frmHangNhap";
            this.Load += new System.EventHandler(this.frmHangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grHangNhap)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grHangNhap;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2Button btnclear;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbIDNCC;
        private Guna.UI2.WinForms.Guna2TextBox txtTenSP;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayNhap;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtMaNhanVien;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaNhap;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhapHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private Guna.UI2.WinForms.Guna2TextBox txtSoLuongNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtDonGia;
    }
}