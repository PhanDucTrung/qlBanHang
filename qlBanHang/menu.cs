using Guna.UI2.WinForms;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;


namespace qlBanHang
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }
        bool Thanhben = false;
        int x = 520, y = 133, z = 400, g = 200, a = 1;
        
        private void menu_Load(object sender, EventArgs e)
        {
            label2.Text = DangNhap.Ten;

            // pq
            switch (DangNhap.quyen)
            {
                case"nhanvien": btnmanage.Enabled=false;
                    break;
            }

        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            menuTransityon.Start();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtwel_Click(object sender, EventArgs e)
        {

        }
        private void sidebarTimer_Tick(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thunho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timeText_Tick(object sender, EventArgs e)
        {
            //try
            //{
            //    x += a;
            //    txtwel.Location = new Point(x, y);
            //    if (x >= 850)
            //    {
            //        a = -1;
            //    }
            //    if (x <= 520)
            //    {
            //        a = +1;
            //    }

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }

        private void timertxt2_Tick_1(object sender, EventArgs e)
        {
            //try
            //{
            //    z += a;
            //    txtsales.Location = new Point(z, g);
            //    if (z >= 800)
            //    {
            //        a = -1;
            //    }
            //    if (z <= 300)
            //    {
            //        a = +1;
            //    }

            //}
            //catch (Exception)
            //{
            //    throw;
            //}
        }


        private void btnHome_Click_1(object sender, EventArgs e)
        {
            Form frm = new menu();
            this.Hide();
            frm.ShowDialog();
            //this.Show();

        }

        private void txtsales_Click(object sender, EventArgs e)
        {

        }

        private void txtwel_Click_1(object sender, EventArgs e)
        {

        }

        private void btnmanage_Click(object sender, EventArgs e)
        {
            //Form frm = new Main();
            //this.Hide();
            //frm.ShowDialog();
            //this.Show();
            var f = new frmMain();
            adForm(f);
            panel1.Visible = true;

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

        }
        private void adForm(Form f)
        {
            f.FormBorderStyle= FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            f.TopMost = true;
            f.StartPosition = FormStartPosition.CenterParent;
            panel1.Controls.Clear();
            panel1.Controls.Add(f);
            f.Show();
        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btngoods_Click(object sender, EventArgs e)
        {
            var f=new frmInport();
            adForm(f);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void sidebarTimer_Tick_1(object sender, EventArgs e)
        {
            if (Thanhben)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    Thanhben = false;
                    menuTransityon.Stop();

                    btnHome.Width = sidebar.Width;
                    btnmanage.Width = sidebar.Width;
                    btngoods.Width = sidebar.Width;
                    btnAbout.Width = sidebar.Width;
                    btnHelp.Width = sidebar.Width;
                    btnDangXuat.Width = sidebar.Width;
                    btnHome.Width = sidebar.Width;
                    btnmanage.Width = sidebar.Width;
                    btngoods.Width = sidebar.Width;
                    btnAbout.Width = sidebar.Width;
                    btnHelp.Width = sidebar.Width;
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    Thanhben = true;
                    menuTransityon.Stop();

                    btnHome.Width = sidebar.Width;
                    btnmanage.Width = sidebar.Width;
                    btngoods.Width = sidebar.Width;
                    btnAbout.Width = sidebar.Width;
                    btnHelp.Width = sidebar.Width;
                    btnDangXuat.Width = sidebar.Width;
                    btnHome.Width = sidebar.Width;
                    btnmanage.Width = sidebar.Width;
                    btngoods.Width = sidebar.Width;
                    btnAbout.Width = sidebar.Width;
                    btnHelp.Width = sidebar.Width;
                }
            }
        }

        private void pbx_Click_1(object sender, EventArgs e)
        {
            pbx.Visible = false;
            button.Visible = true;
            menuTransityon.Start();
        }

        private void button_Click_1(object sender, EventArgs e)
        {
            button.Visible = false;
            pbx.Visible = true;
            menuTransityon.Start();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DangNhap frm = new DangNhap();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
