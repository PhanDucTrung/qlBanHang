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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NvBLL NvBLL = new NvBLL();

        int b=0;
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadgr();
            Loaddata();
        }
        private void loadgr()
        {

            List<NHANVIEN> nv = NvBLL.GetAllItem( "select * from NHANVIEN");
            grNhanVien.DataSource = nv;

        }

        private void Loaddata()
        {
            try
            {
                int r = grNhanVien.CurrentCell.RowIndex;

                txtMaNhanVien.Text = grNhanVien.Rows[r].Cells[0].Value.ToString();
                txtHo.Text = grNhanVien.Rows[r].Cells[1].Value.ToString();
                txtTen.Text = grNhanVien.Rows[r].Cells[2].Value.ToString();
                cmbGioiTinh.SelectedIndex = Convert.ToBoolean(grNhanVien.Rows[r].Cells[3].Value.ToString()) == true ? 1 : 0;
                dtNgaySinh.Text = grNhanVien.Rows[r].Cells[4].Value.ToString();
                dtNgayVaoLam.Text = grNhanVien.Rows[r].Cells[8].Value.ToString();
                txtDiaChi.Text = grNhanVien.Rows[r].Cells[5].Value.ToString();
                txtDienThoai.Text = grNhanVien.Rows[r].Cells[6].Value.ToString();
                txtStatus.Text = grNhanVien.Rows[r].Cells[7].Value.ToString();

            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            var a = txtDienThoai.Text.ToArray();
            if (txtDienThoai.Text != "")
            {
                label10.Visible = true;
                label10.Text = a.Length.ToString() + "/10";
                NvBLL.dienthoai = txtDienThoai.Text.Trim();
                if (NvBLL.checkdt() == false)
                {
                    MessageBox.Show("sdt gồm 10 kí tự số và không có kí tự chữ");
                    txtDienThoai.Clear();
                }
                if (a.Length != 10)
                {
                    if (a.Length>10)
                    {
                    txtDienThoai.Clear();


                    }
                    label10.ForeColor = Color.Red;
                    b = 0;
                }
                else
                {
                    label10.ForeColor = Color.Green;
                    b = 1;
                }
            }
            else
            {
                label10.Visible = false;
                b = 0;
            }
        }

        private void cmbGioiTinh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (b>0)
            {
                NvBLL.manv = txtMaNhanVien.Text.Trim();
                NvBLL.honv = txtHo.Text;
                NvBLL.tennv = txtTen.Text;
                NvBLL.gioitinh = Convert.ToBoolean(cmbGioiTinh.SelectedIndex);
                NvBLL.ngaysinh = dtNgaySinh.Text.Trim();
                NvBLL.ngayvl = dtNgayVaoLam.Text.Trim();

                NvBLL.trangthai = txtStatus.Text;
                NvBLL.dienthoai = txtDienThoai.Text;
                NvBLL.diachi = txtDiaChi.Text;
                NvBLL.UpdateData(NvBLL.nv);
                loadgr();
                Loaddata();

            }
            else
            {
                MessageBox.Show("Sai SDT");
            }
        }

        private void grNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Loaddata();
        }

        private void btnXoaHet_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMaNhanVien.Text = "Auto";
            txtHo.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtStatus.Clear();
            cmbGioiTinh.SelectedIndex = -1;
       
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = NvBLL.GetAllItem("select * from NHANVIEN where DienThoai='"+txtDienThoai.Text+"'");
            if (nv.Count>0||cmbGioiTinh.SelectedIndex==-1||txtStatus.Text==""||txtTen.Text=="")
            {
                MessageBox.Show("thiếu or sai tt ");
            }
            else
            {
                NvBLL.honv = txtHo.Text;
                NvBLL.tennv = txtTen.Text;
                NvBLL.gioitinh = Convert.ToBoolean(cmbGioiTinh.SelectedIndex);
                NvBLL.ngaysinh = dtNgaySinh.Text.Trim();
                NvBLL.ngayvl = dtNgayVaoLam.Text.Trim();

                NvBLL.trangthai = txtStatus.Text;
                NvBLL.dienthoai = txtDienThoai.Text;
                NvBLL.diachi = txtDiaChi.Text;
                NvBLL.ThemSanPham(NvBLL.nv);
                loadgr();
                Loaddata();
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            List<NHANVIEN> nv = NvBLL.GetAllItem("select * from NHANVIEN where HoNV like N'%"+txtTimKiem.Text+ "%' or TenNV like N'%" + txtTimKiem.Text + "%' or DienThoai like N'%" + txtTimKiem.Text + "%' or DiaChi like N'%" + txtTimKiem.Text + "%'");
            grNhanVien.DataSource = nv;
        }
    }
}
