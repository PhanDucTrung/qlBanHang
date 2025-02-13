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
    public partial class FrmNhacungcap : Form
    {
        public FrmNhacungcap()
        {
            InitializeComponent();
        }
        NhapHangBLL NhapHangBLL = new NhapHangBLL();

        private void FrmNhacungcap_Load(object sender, EventArgs e)
        {
            loadgr();
            Loaddata();
        }
        private void loadgr()
        {

            List<NHACUNGCAP> ncc = NhapHangBLL.listcc("select * from NHACUNGCAP");
            grNhaCungCap.DataSource = ncc;




        }

        private void Loaddata()
        {
            try
            {
                
            int r = grNhaCungCap.CurrentCell.RowIndex;

                txtMaKH.Text = grNhaCungCap.Rows[r].Cells[0].Value.ToString();
                txtHoTenKH.Text = grNhaCungCap.Rows[r].Cells[1].Value.ToString();
                txtDiaChi.Text = grNhaCungCap.Rows[r].Cells[2].Value.ToString();
                txtDienThoai.Text = grNhaCungCap.Rows[r].Cells[3].Value.ToString();


            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            //NhapHangBLL.MaNCC = txtMaKH.Text;
            NhapHangBLL.TenNCC = txtHoTenKH.Text;
            NhapHangBLL.DiaChi = txtDiaChi.Text;
            NhapHangBLL.LienHe = txtDienThoai.Text;

            NhapHangBLL.AddNCC(NhapHangBLL.ncc);
            loadgr();
            Loaddata();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMaKH.Clear();
            txtHoTenKH.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhapHangBLL.MaNCC = txtMaKH.Text;
            NhapHangBLL.TenNCC = txtHoTenKH.Text;
            NhapHangBLL.DiaChi = txtDiaChi.Text;
            NhapHangBLL.LienHe = txtDienThoai.Text;
            NhapHangBLL.update(NhapHangBLL.ncc);
            loadgr();
            Loaddata();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NHACUNGCAP> ncc = NhapHangBLL.listcc("select * from NHACUNGCAP where TenNCC like N'%" + txtTimKiem.Text + "%'");
            grNhaCungCap.DataSource = ncc;
        }

        private void grNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }
    }
}
