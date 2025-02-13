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
    public partial class frmHangNhap : Form
    {
        public frmHangNhap()
        {
            InitializeComponent();
        }
        NhapHangBLL NhapHangBLL=new NhapHangBLL();
        spBLL spBLL=new spBLL();
        private void panel10_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void frmHangNhap_Load(object sender, EventArgs e)
        {
            loadgr();
            Loaddata();

        }
        private void loadgr()
        {

            List<NHACUNGCAP> ncc = NhapHangBLL.listcc("select * from NHACUNGCAP");
            cmbIDNCC.DataSource = ncc;
            cmbIDNCC.DisplayMember = "TenNCC";
            cmbIDNCC.ValueMember = "MaNCC";

            (grHangNhap.Columns["MaNCC"] as DataGridViewComboBoxColumn).DataSource = ncc;
            (grHangNhap.Columns["MaNCC"] as DataGridViewComboBoxColumn).DisplayMember = "TenNCC";
            (grHangNhap.Columns["MaNCC"] as DataGridViewComboBoxColumn).ValueMember = "MaNCC";

            List<HANGNHAP> hn = NhapHangBLL.GetAllItem("select * from HANGNHAP");
            grHangNhap.DataSource = hn;
            grHangNhap.Columns["TongSLN"].Visible = false;






        }

        private void Loaddata()
        {
            try
            {
                int r = grHangNhap.CurrentCell.RowIndex;

                txtTenSP.Text = grHangNhap.Rows[r].Cells[1].Value.ToString();
                cmbDv.SelectedValue = grHangNhap.Rows[r].Cells[2].Value.ToString();
                txtSoLuongNhap.Text = grHangNhap.Rows[r].Cells[3].Value.ToString();
                txtDonGia.Text = grHangNhap.Rows[r].Cells[4].Value.ToString();
                cmbIDNCC.Text = grHangNhap.Rows[r].Cells[5].Value.ToString();
                dtNgayNhap.Text = grHangNhap.Rows[r].Cells[6].Value.ToString();
                txtMaNhanVien.Text = grHangNhap.Rows[r].Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }
        private void btnclear_Click(object sender, EventArgs e)
        {
            txtTenSP.Clear();
          
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            NhapHangBLL.TenSP=txtTenSP.Text;
            NhapHangBLL.SoLuongNhap=txtSoLuongNhap.Text;
            NhapHangBLL.DonViTinh=cmbDv.Text;
            NhapHangBLL.DonGiaNhap=txtDonGia.Text;
            NhapHangBLL.NgayNhapHang=dtNgayNhap.Text;
            NhapHangBLL.MaNCC=cmbIDNCC.SelectedValue.ToString();
            NhapHangBLL.MaNV = DangNhap.Ma;

            NhapHangBLL.Insertdata(NhapHangBLL.sp,NhapHangBLL.hn,NhapHangBLL.ncc);
            MessageBox.Show("Them Thành công");
            loadgr();



        }

        private void txtTenSP_TextChanged(object sender, EventArgs e)
        {
            List<SANPHAM> sans = spBLL.GetAllItem("select * from SANPHAM where TenSP LIKE '%"+txtTenSP.Text+"%'");

            cmbDv.DataSource = sans;
            cmbDv.DisplayMember = "DonViTinh";
            cmbDv.ValueMember = "MaSP";

         
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grHangNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {
            if (txtDonGia.Text != "")
            {
                NhapHangBLL.DonGiaNhap = txtDonGia.Text;

                if (NhapHangBLL.CheckGia() == false)
                {
                    MessageBox.Show("ko dc có kí tự ở đây", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDonGia.Clear();
                }
            }
        }

        private void txtSoLuongNhap_TextChanged(object sender, EventArgs e)
        {
            if (txtSoLuongNhap.Text != "")
            {
                NhapHangBLL.SoLuongNhap = txtSoLuongNhap.Text;

                if (NhapHangBLL.checksl() == false)
                {
                    MessageBox.Show("ko dc có kí tự ở đây", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoLuongNhap.Clear();
                }
            }
        }
    }
}
