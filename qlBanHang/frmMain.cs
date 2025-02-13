using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace qlBanHang
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private void adForm(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            panel2.Controls.Clear();
            panel2.Controls.Add(f);
             f.Dock = DockStyle.Fill;
            f.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var f = new FrmNhacungcap();
            adForm(f);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            var f = new frmChiTiet();
            adForm(f);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var f = new FrmSanPham();
            adForm(f);
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            var f = new FrmHoaDon();
            adForm(f);
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            var f = new FrmKhachhang();
            adForm(f);
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            var f = new frmNhanVien();
            adForm(f);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            var f =new FrmUser();
            adForm(f);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var f  =new frmThongKe();
            adForm(f);
        }
    }
}
