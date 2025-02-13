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
    public partial class Load : Form
    {
        public Load()
        {
            InitializeComponent();
        }
        int start = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            start += 1;
            guna2ProgressBar1.Value = start;
            if (guna2ProgressBar1.Value == 100)
            {
                guna2ProgressBar1.Value = 0;
                timer1.Stop();
                DangNhap frm = new DangNhap();
                this.Hide();
                frm.ShowDialog();

            }
        }

        private void Load_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
