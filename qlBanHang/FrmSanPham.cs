using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace qlBanHang
{
    public partial class FrmSanPham : Form
    {
        public FrmSanPham()
        {
            InitializeComponent();
        }
        spBLL spbLL = new spBLL();
        public bool a;
        private void loadgr()
        {

            List<SANPHAM> sans = spbLL.GetAllItem("select * from SANPHAM");
            grSanPham.DataSource = sans;
            cmbMaHD.DataSource = sans;
            cmbMaHD.ValueMember = "MaSP";

        }

        private void Loaddata()
        {
            try
            {
                int r = grSanPham.CurrentCell.RowIndex;

                cmbMaHD.SelectedValue = grSanPham.Rows[r].Cells[0].Value.ToString();
                txtTen.Text = grSanPham.Rows[r].Cells[1].Value.ToString();
                txtDonVI.Text = grSanPham.Rows[r].Cells[2].Value.ToString();
                txtDonGia.Text = grSanPham.Rows[r].Cells[3].Value.ToString();
                txtSoLuong.Text = grSanPham.Rows[r].Cells[4].Value.ToString();

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            spbLL.ma = cmbMaHD.Text.Trim();
            spbLL.ten = txtTen.Text.Trim();
            spbLL.gia = txtDonGia.Text.Trim();
            spbLL.dv = txtDonVI.Text.Trim();
            spbLL.sl = txtSoLuong.Text.Trim();

            spbLL.Insertdata(spbLL.sp);
            loadgr();
            Loaddata();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            spbLL.ma = cmbMaHD.Text.Trim();
            spbLL.ten = txtTen.Text.Trim();
            spbLL.gia = txtDonGia.Text.Trim();
            spbLL.dv = txtDonVI.Text.Trim();
            spbLL.sl = txtSoLuong.Text.Trim();

            spbLL.UpdateData(spbLL.sp);
            loadgr();
            Loaddata();
          
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
            {
                spbLL.gia = txtDonGia.Text.Trim();
                if (spbLL.checkgia() == false)
                {
                    MessageBox.Show("gia ko dc có kí tự");
                }
            }
        }

        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            loadgr();
            Loaddata();
        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

            if (txtSoLuong.Text != "")
            {
                spbLL.sl = txtSoLuong.Text.Trim();
                if (spbLL.checksl() == false)
                {
                    MessageBox.Show("sl ko dc có kí tự");
                }
            }
        }

        private void grSanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<SANPHAM> sans = spbLL.GetAllItem("select * from SANPHAM where TenSP like N'%" + txtTimKiem.Text + "%' or DonGia like N'%" + txtTimKiem.Text + "%'");
            grSanPham.DataSource = sans;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("ban co muon xoa khong ?", "thong bao ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                spbLL.ma = cmbMaHD.Text.Trim();
                spbLL.Deletedata(spbLL.sp);
                loadgr();
                Loaddata();
            }

        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtDonGia.Clear();
            txtDonVI.Clear();
            txtSoLuong.Clear();
            txtTen.Clear();
        }
    }
}
