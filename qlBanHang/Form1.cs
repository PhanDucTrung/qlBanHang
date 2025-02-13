using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;

namespace qlBanHang
   
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
      
        LoginBLL LoginBLL = new LoginBLL();
        NvBLL NvBLL = new NvBLL();
        public static string Ten;
        public static string Ma;
        public static string quyen  ;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

         
           
            if (txtMatKhau.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show("ko dc để trống thông tin");
                return;
            }
            LoginBLL.password=txtMatKhau.Text;
            LoginBLL.username=txtTen.Text;
            List<LOGIN> list = LoginBLL.datalogin();
            List<NHANVIEN> nv = NvBLL.GetAllItem("SELECT * FROM NHANVIEN");


            if (list.Count > 0)
            {

                List<permission> per = LoginBLL.GetPer("  select * from PERMISSION where id_permission=" + list[0].id_permission + "");

                Ten = nv[0].TenNV;
                Ma = nv[0].MaNV;
                quyen = per[0].Name_permission;
                MessageBox.Show("wellcome " + quyen+"\t" +Ma);
                menu frm = new menu();
                this.Hide();
                frm.ShowDialog();
                //this.Show();
            }
            else
            {
                lbThongbao.Visible = true;
                txtTen.ResetText();
                txtMatKhau.ResetText();
            }


        }
        private void lbThongbao_Click(object sender, EventArgs e)
        {

        }
    }
}
