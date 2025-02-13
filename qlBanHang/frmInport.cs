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
    public partial class frmInport : Form
    {
        public frmInport()
        {
            InitializeComponent();
        }
        private void adForm(Form f)
        {
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            f.StartPosition = FormStartPosition.CenterParent;
            panel3.Controls.Clear();
            panel3.Controls.Add(f);
            f.Show();
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            var f= new frmBanHang();
            adForm(f);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var f = new frmHangNhap();
            adForm(f);

        }
    }
}
