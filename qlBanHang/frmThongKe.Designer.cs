namespace qlBanHang
{
    partial class frmThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.plSlandMoney = new System.Windows.Forms.Panel();
            this.chartmoney = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNam = new System.Windows.Forms.ComboBox();
            this.cmbThang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnXoaHet = new Guna.UI2.WinForms.Guna2Button();
            this.btnThem = new Guna.UI2.WinForms.Guna2Button();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.plSlandMoney.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartmoney)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSP)).BeginInit();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // plSlandMoney
            // 
            this.plSlandMoney.AutoSize = true;
            this.plSlandMoney.Controls.Add(this.chartmoney);
            this.plSlandMoney.Location = new System.Drawing.Point(12, 285);
            this.plSlandMoney.Name = "plSlandMoney";
            this.plSlandMoney.Size = new System.Drawing.Size(629, 207);
            this.plSlandMoney.TabIndex = 0;
            // 
            // chartmoney
            // 
            chartArea1.Name = "ChartArea1";
            this.chartmoney.ChartAreas.Add(chartArea1);
            this.chartmoney.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartmoney.Legends.Add(legend1);
            this.chartmoney.Location = new System.Drawing.Point(0, 0);
            this.chartmoney.Name = "chartmoney";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartmoney.Series.Add(series1);
            this.chartmoney.Size = new System.Drawing.Size(629, 207);
            this.chartmoney.TabIndex = 0;
            this.chartmoney.Text = "chart1";
            // 
            // chartSP
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSP.ChartAreas.Add(chartArea2);
            this.chartSP.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartSP.Legends.Add(legend2);
            this.chartSP.Location = new System.Drawing.Point(0, 0);
            this.chartSP.Name = "chartSP";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartSP.Series.Add(series2);
            this.chartSP.Size = new System.Drawing.Size(325, 276);
            this.chartSP.TabIndex = 0;
            this.chartSP.Text = "chart2";
            this.chartSP.Click += new System.EventHandler(this.chartSP_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.chartSP);
            this.panel1.Location = new System.Drawing.Point(12, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 276);
            this.panel1.TabIndex = 1;
            // 
            // cmbNam
            // 
            this.cmbNam.FormattingEnabled = true;
            this.cmbNam.Location = new System.Drawing.Point(104, 15);
            this.cmbNam.Name = "cmbNam";
            this.cmbNam.Size = new System.Drawing.Size(121, 21);
            this.cmbNam.TabIndex = 2;
            // 
            // cmbThang
            // 
            this.cmbThang.FormattingEnabled = true;
            this.cmbThang.Location = new System.Drawing.Point(104, 76);
            this.cmbThang.Name = "cmbThang";
            this.cmbThang.Size = new System.Drawing.Size(121, 21);
            this.cmbThang.TabIndex = 2;
            this.cmbThang.SelectedIndexChanged += new System.EventHandler(this.cmbThang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "năm";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.cmbNam);
            this.guna2Panel1.Controls.Add(this.cmbThang);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.guna2Panel1.Location = new System.Drawing.Point(346, 20);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(295, 242);
            this.guna2Panel1.TabIndex = 10;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderRadius = 30;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnXoaHet);
            this.guna2Panel2.Controls.Add(this.btnThem);
            this.guna2Panel2.Controls.Add(this.btnXoa);
            this.guna2Panel2.Controls.Add(this.btnSua);
            this.guna2Panel2.Enabled = false;
            this.guna2Panel2.Location = new System.Drawing.Point(33, 108);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(231, 119);
            this.guna2Panel2.TabIndex = 8;
            // 
            // btnXoaHet
            // 
            this.btnXoaHet.AutoRoundedCorners = true;
            this.btnXoaHet.BorderRadius = 17;
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
            this.btnXoaHet.Location = new System.Drawing.Point(128, 73);
            this.btnXoaHet.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoaHet.Name = "btnXoaHet";
            this.btnXoaHet.Size = new System.Drawing.Size(91, 37);
            this.btnXoaHet.TabIndex = 3;
            this.btnXoaHet.Text = "Clear";
            this.btnXoaHet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnThem
            // 
            this.btnThem.AutoRoundedCorners = true;
            this.btnThem.BorderRadius = 17;
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
            this.btnThem.Location = new System.Drawing.Point(18, 14);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(91, 37);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Add";
            this.btnThem.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 17;
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
            this.btnXoa.Location = new System.Drawing.Point(18, 73);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(91, 37);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Del";
            this.btnXoa.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnSua.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnSua.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Black;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSua.Location = new System.Drawing.Point(128, 14);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 37);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Edit";
            this.btnSua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(648, 512);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.plSlandMoney);
            this.Name = "frmThongKe";
            this.Text = "frmThongKe";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            this.plSlandMoney.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartmoney)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSP)).EndInit();
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel plSlandMoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartmoney;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSP;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNam;
        private System.Windows.Forms.ComboBox cmbThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button btnXoaHet;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
    }
}