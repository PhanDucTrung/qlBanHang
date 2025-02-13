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
    public partial class frmChiTiet : Form
    {
        public frmChiTiet()
        {
            InitializeComponent();
        }
        CThdBLL CThdBLL = new CThdBLL();
        spBLL spBLL = new spBLL();
        HdBLL hdBLL = new HdBLL();  
        private void frmChiTiet_Load(object sender, EventArgs e)
        {
            
            loadgr();
            Loaddata();
        }
        private void loadgr()
        {
            List<SANPHAM> sp = spBLL.GetAllItem("select * from SANPHAM");
            cmbSP.DataSource = sp;
            cmbSP.DisplayMember = "TenSP";
            cmbSP.ValueMember = "MaSP";
            (grChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DataSource = sp;
            (grChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).DisplayMember = "TenSP";
            (grChiTietHD.Columns["MaSP"] as DataGridViewComboBoxColumn).ValueMember = "MaSP";
            List<CHITIETHD> kh = CThdBLL.GetAllItem("select * from CHITIETHD");
            grChiTietHD.DataSource = kh;
            
           

        }

        private void Loaddata()
        {
            try
            {
                int r = grChiTietHD.CurrentCell.RowIndex;

                txtHd.Text = grChiTietHD.Rows[r].Cells[0].Value.ToString();
                cmbSP.SelectedValue = grChiTietHD.Rows[r].Cells[1].Value.ToString();
                txtSoLuong.Text = grChiTietHD.Rows[r].Cells[2].Value.ToString();
            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            CThdBLL.search=txtTimKiem.Text.Trim(); 
            List<CHITIETHD> kh = CThdBLL.Searchitem();
            grChiTietHD.DataSource = kh;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
         
        }
    }
}
