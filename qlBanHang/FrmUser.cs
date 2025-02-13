using BLL;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
using System.Collections.Generic;


namespace qlBanHang
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }
        LoginBLL LoginBLL = new LoginBLL();
        NvBLL nvBLL = new NvBLL();

        private void FrmUser_Load(object sender, EventArgs e)
        {
                loadgr();
            //cmbQuyen.SelectedIndex = 0;
            Loaddata();
        }
        private void loadgr()
        {

            List<LOGIN> login = LoginBLL.getAllitems(" SELECT * FROM  dbo.USERS");
            dataGridView1.DataSource = login;
            List<permission> per = LoginBLL.GetPer("select * from PERMISSION");
            cmbQuyen.DataSource = per;
            cmbQuyen.DisplayMember = "Name_permission";
            cmbQuyen.ValueMember = "id_permission"; 
            List<NHANVIEN> nv = nvBLL.GetAllItem("select * from NHANVIEN ");
            cmbNhanVien.DataSource = nv;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = nv;
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "TenNV";
            (dataGridView1.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";

            (dataGridView1.Columns["Quyen"] as DataGridViewComboBoxColumn).DataSource = per;
            (dataGridView1.Columns["Quyen"] as DataGridViewComboBoxColumn).DisplayMember = "Name_permission";
            (dataGridView1.Columns["Quyen"] as DataGridViewComboBoxColumn).ValueMember = "id_permission";

        }

        private void Loaddata()
        {
            try
            {
                int r = dataGridView1.CurrentCell.RowIndex;

                txtidu.Text = dataGridView1.Rows[r].Cells[0].Value.ToString();
           
                txtuname.Text = dataGridView1.Rows[r].Cells[1].Value.ToString();
                txtpass.Text = dataGridView1.Rows[r].Cells[2].Value.ToString();
                cmbQuyen.SelectedValue = dataGridView1.Rows[r].Cells[3].Value;
                cmbNhanVien.SelectedValue = dataGridView1.Rows[r].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoginBLL.idu=txtidu.Text.Trim();
            LoginBLL.username=txtuname.Text.Trim();
            LoginBLL.password=txtpass.Text.Trim();
            LoginBLL.idper=cmbQuyen.SelectedIndex+1;
            LoginBLL.MaNV = cmbNhanVien.SelectedValue.ToString();
            try
            {
                LoginBLL.Insertdata(LoginBLL.lg);
                loadgr();
            }
            catch (Exception)
            {
                
                //throw;
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("ban co muon xoa khong ?", "thong bao ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                LoginBLL.idu = txtidu.Text.Trim();
                LoginBLL.Deletedata(LoginBLL.lg);
                loadgr();
                Loaddata();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoginBLL.idu = txtidu.Text.Trim();
            LoginBLL.username = txtuname.Text.Trim();
            LoginBLL.password = txtpass.Text.Trim();
            LoginBLL.idper = cmbQuyen.SelectedIndex + 1;
            LoginBLL.MaNV = cmbNhanVien.SelectedValue.ToString();

            LoginBLL.UpdateData(LoginBLL.lg);
            loadgr();
        }
    }
}
