namespace qlBanHang
{
    partial class FrmHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHoaDon));
            this.btnInHD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grHD = new System.Windows.Forms.DataGridView();
            this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtNgayLapHD = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbNhanVien = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbMaKH = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlControl = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoaHet = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtHd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grHD)).BeginInit();
            this.pnlControl.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInHD
            // 
            this.btnInHD.AutoRoundedCorners = true;
            this.btnInHD.BorderRadius = 25;
            this.btnInHD.BorderThickness = 2;
            this.btnInHD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInHD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInHD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInHD.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnInHD.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.ForeColor = System.Drawing.Color.Black;
            this.btnInHD.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnInHD.Location = new System.Drawing.Point(439, 17);
            this.btnInHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(157, 52);
            this.btnInHD.TabIndex = 10;
            this.btnInHD.Text = "In hoá đơn";
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 40;
            this.guna2Elipse1.TargetControl = this.grHD;
            // 
            // grHD
            // 
            this.grHD.AllowUserToResizeColumns = false;
            this.grHD.AllowUserToResizeRows = false;
            this.grHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.grHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grHD.ColumnHeadersHeight = 80;
            this.grHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.MaNV,
            this.NgayLapHD});
            this.grHD.EnableHeadersVisualStyles = false;
            this.grHD.GridColor = System.Drawing.Color.DarkGray;
            this.grHD.Location = new System.Drawing.Point(37, 111);
            this.grHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grHD.Name = "grHD";
            this.grHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grHD.RowHeadersWidth = 51;
            this.grHD.RowTemplate.Height = 24;
            this.grHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grHD.Size = new System.Drawing.Size(624, 446);
            this.grHD.TabIndex = 11;
            // 
            // MaHD
            // 
            this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaHD.DataPropertyName = "MaHD";
            this.MaHD.HeaderText = "Mã hoá đơn";
            this.MaHD.MinimumWidth = 6;
            this.MaHD.Name = "MaHD";
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã nhân viên";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            this.MaNV.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.MaNV.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // NgayLapHD
            // 
            this.NgayLapHD.DataPropertyName = "NgayLapHD";
            this.NgayLapHD.HeaderText = "Ngày lập hoá đơn";
            this.NgayLapHD.MinimumWidth = 6;
            this.NgayLapHD.Name = "NgayLapHD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(45, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Ngày lập hoá đơn:";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gray;
            this.panel9.Location = new System.Drawing.Point(49, 242);
            this.panel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(168, 2);
            this.panel9.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(49, 114);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 2);
            this.panel4.TabIndex = 10;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn1.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dtNgayLapHD
            // 
            this.dtNgayLapHD.AutoRoundedCorners = true;
            this.dtNgayLapHD.BackColor = System.Drawing.Color.Transparent;
            this.dtNgayLapHD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.dtNgayLapHD.BorderRadius = 17;
            this.dtNgayLapHD.Checked = true;
            this.dtNgayLapHD.CustomFormat = "dd/MM/yyyy";
            this.dtNgayLapHD.FillColor = System.Drawing.Color.White;
            this.dtNgayLapHD.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dtNgayLapHD.ForeColor = System.Drawing.Color.Black;
            this.dtNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapHD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtNgayLapHD.Location = new System.Drawing.Point(49, 213);
            this.dtNgayLapHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtNgayLapHD.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtNgayLapHD.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtNgayLapHD.Name = "dtNgayLapHD";
            this.dtNgayLapHD.Size = new System.Drawing.Size(168, 36);
            this.dtNgayLapHD.TabIndex = 15;
            this.dtNgayLapHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dtNgayLapHD.Value = new System.DateTime(2023, 10, 23, 22, 13, 0, 456);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(321, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID nhân viên";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(304, 114);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 2);
            this.panel2.TabIndex = 13;
            // 
            // cmbNhanVien
            // 
            this.cmbNhanVien.AutoRoundedCorners = true;
            this.cmbNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.cmbNhanVien.BorderColor = System.Drawing.Color.Black;
            this.cmbNhanVien.BorderRadius = 17;
            this.cmbNhanVien.BorderThickness = 0;
            this.cmbNhanVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanVien.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbNhanVien.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhanVien.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNhanVien.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNhanVien.ForeColor = System.Drawing.Color.Black;
            this.cmbNhanVien.ItemHeight = 30;
            this.cmbNhanVien.Items.AddRange(new object[] {
            "ehejhe"});
            this.cmbNhanVien.Location = new System.Drawing.Point(300, 70);
            this.cmbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbNhanVien.Name = "cmbNhanVien";
            this.cmbNhanVien.Size = new System.Drawing.Size(139, 36);
            this.cmbNhanVien.TabIndex = 12;
            this.cmbNhanVien.SelectedIndexChanged += new System.EventHandler(this.cmbNhanVien_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(65, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID khách hàng";
            // 
            // cmbMaKH
            // 
            this.cmbMaKH.AutoRoundedCorners = true;
            this.cmbMaKH.BackColor = System.Drawing.Color.Transparent;
            this.cmbMaKH.BorderColor = System.Drawing.Color.Black;
            this.cmbMaKH.BorderRadius = 17;
            this.cmbMaKH.BorderThickness = 0;
            this.cmbMaKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMaKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.cmbMaKH.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbMaKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbMaKH.ForeColor = System.Drawing.Color.Black;
            this.cmbMaKH.ItemHeight = 30;
            this.cmbMaKH.Items.AddRange(new object[] {
            "hbehe36j6"});
            this.cmbMaKH.Location = new System.Drawing.Point(52, 73);
            this.cmbMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbMaKH.Name = "cmbMaKH";
            this.cmbMaKH.Size = new System.Drawing.Size(139, 36);
            this.cmbMaKH.TabIndex = 9;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlControl.BorderColor = System.Drawing.Color.Black;
            this.pnlControl.BorderRadius = 30;
            this.pnlControl.BorderThickness = 1;
            this.pnlControl.Controls.Add(this.btnXoaHet);
            this.pnlControl.Controls.Add(this.btnThem);
            this.pnlControl.Controls.Add(this.btnXoa);
            this.pnlControl.Controls.Add(this.btnSua);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(91, 284);
            this.pnlControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(308, 146);
            this.pnlControl.TabIndex = 8;
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.AutoRoundedCorners = true;
            this.btnXoaHet.BorderRadius = 22;
            this.btnXoaHet.BorderThickness = 2;
            this.btnXoaHet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaHet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaHet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaHet.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnXoaHet.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHet.ForeColor = System.Drawing.Color.Black;
            this.btnXoaHet.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaHet.Image")));
            this.btnXoaHet.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoaHet.ImageSize = new System.Drawing.Size(25, 25);
            this.btnXoaHet.Location = new System.Drawing.Point(171, 90);
            this.btnXoaHet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(121, 46);
            this.btnXoaHet.TabIndex = 3;
            this.btnXoaHet.Text = "Clear";
            this.btnXoaHet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 22;
            this.btnThem.BorderThickness = 2;
            this.btnThem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnThem.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnThem.Location = new System.Drawing.Point(24, 17);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 46);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 22;
            this.btnXoa.BorderThickness = 2;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnXoa.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnXoa.Location = new System.Drawing.Point(24, 90);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 46);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Del";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 22;
            this.btnSua.BorderThickness = 2;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSua.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Location = new System.Drawing.Point(171, 17);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 46);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Edit";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.panel1);
            this.guna2Panel1.Controls.Add(this.txtHd);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.panel9);
            this.guna2Panel1.Controls.Add(this.dtNgayLapHD);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.panel2);
            this.guna2Panel1.Controls.Add(this.cmbNhanVien);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.panel4);
            this.guna2Panel1.Controls.Add(this.cmbMaKH);
            this.guna2Panel1.Controls.Add(this.pnlControl);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Panel1.Location = new System.Drawing.Point(739, 95);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(463, 462);
            this.guna2Panel1.TabIndex = 9;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(268, 190);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Mã Hóa Đơn ";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(265, 242);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 2);
            this.panel1.TabIndex = 19;
            // 
            // txtHd
            // 
            this.txtHd.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHd.AutoRoundedCorners = true;
            this.txtHd.BackColor = System.Drawing.Color.Transparent;
            this.txtHd.BorderColor = System.Drawing.Color.Black;
            this.txtHd.BorderRadius = 22;
            this.txtHd.BorderThickness = 0;
            this.txtHd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHd.DefaultText = "";
            this.txtHd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHd.Enabled = false;
            this.txtHd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.txtHd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHd.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHd.ForeColor = System.Drawing.Color.Black;
            this.txtHd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHd.Location = new System.Drawing.Point(261, 199);
            this.txtHd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHd.Name = "txtHd";
            this.txtHd.PasswordChar = '\0';
            this.txtHd.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtHd.PlaceholderText = "";
            this.txtHd.SelectedText = "";
            this.txtHd.Size = new System.Drawing.Size(183, 46);
            this.txtHd.TabIndex = 18;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BorderColor = System.Drawing.Color.Black;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimKiem.DefaultText = "";
            this.txtTimKiem.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTimKiem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTimKiem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTimKiem.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.txtTimKiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTimKiem.IconRight = ((System.Drawing.Image)(resources.GetObject("txtTimKiem.IconRight")));
            this.txtTimKiem.IconRightOffset = new System.Drawing.Point(10, 0);
            this.txtTimKiem.Location = new System.Drawing.Point(37, 17);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PasswordChar = '\0';
            this.txtTimKiem.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "Tìm kiếm";
            this.txtTimKiem.SelectedText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(311, 49);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.TextOffset = new System.Drawing.Point(5, -1);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1235, 570);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnInHD);
            this.Controls.Add(this.grHD);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHoaDon";
            this.Text = "FrmHoaDon";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grHD)).EndInit();
            this.pnlControl.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2Button btnXoaHet;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnInHD;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridView grHD;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtNgayLapHD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNhanVien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cmbMaKH;
        private Guna.UI2.WinForms.Guna2Panel pnlControl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewComboBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtHd;
    }
}