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
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        HdBLL HdBLL = new HdBLL();
        NvBLL nvBLL = new NvBLL();
        KhBLL KhBLL = new KhBLL();
        private void loadgr()
        {
            List<HOADON> list = HdBLL.GetAllItem("select * from HOADON");
            grHD.DataSource = list;
            List<NHANVIEN> nv = nvBLL.GetAllItem("select * from NHANVIEN");
            cmbNhanVien.DataSource = nv;
            cmbNhanVien.DisplayMember = "TenNV";
            cmbNhanVien.ValueMember = "MaNV";
            List<KHACHHANG> kh = KhBLL.GetAllItem("select * from KHACHANG");
            cmbMaKH.DataSource = kh;
            cmbMaKH.DisplayMember = "HoTenKH";
            cmbMaKH.ValueMember = "MaKH";
            (grHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DataSource = kh;
            (grHD.Columns["MaKH"] as DataGridViewComboBoxColumn).DisplayMember = "HoTenKH";
            (grHD.Columns["MaKH"] as DataGridViewComboBoxColumn).ValueMember = "MaKH";

            (grHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DataSource = nv;
            (grHD.Columns["MaNV"] as DataGridViewComboBoxColumn).DisplayMember = "TenNV";
            (grHD.Columns["MaNV"] as DataGridViewComboBoxColumn).ValueMember = "MaNV";



         
        }
        private void Loaddata()
        {
            int r = grHD.CurrentCell.RowIndex;

            txtHd.Text = grHD.Rows[r].Cells[0].Value.ToString();
            cmbMaKH.SelectedValue = grHD.Rows[r].Cells[1].Value.ToString();
            cmbNhanVien.SelectedValue = grHD.Rows[r].Cells[2].Value.ToString();
            dtNgayLapHD.Text = grHD.Rows[r].Cells[3].Value.ToString();
            //dtNgayNhanHang.Text = grHD.Rows[r].Cells[4].Value.ToString();
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            loadgr();
            Loaddata();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

            HdBLL.search=txtTimKiem.Text.Trim();
            List<HOADON> list = HdBLL.Searchitem();
            grHD.DataSource = list;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInHD_Click(object sender, EventArgs e)
        {

        }
    }
}
