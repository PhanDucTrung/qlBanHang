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
    public partial class FrmKhachhang : Form
    {
        public FrmKhachhang()
        {
            InitializeComponent();
        }
        KhBLL KhBLL = new KhBLL();

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void loadgr()
        {

            List<KHACHHANG> kh = KhBLL.GetAllItem("select * from KHACHANG");
            grKH.DataSource = kh;

        }

        private void Loaddata()
        {
            try
            {
                int r = grKH.CurrentCell.RowIndex;

                txtMaKH.Text = grKH.Rows[r].Cells[0].Value.ToString();
                txtHotenKH.Text = grKH.Rows[r].Cells[1].Value.ToString();
                txtDiaChi.Text = grKH.Rows[r].Cells[2].Value.ToString();
                txtDienThoai.Text = grKH.Rows[r].Cells[3].Value.ToString();



            }
            catch
            {
                MessageBox.Show("chọn vùng không có thông tin");
            }

        }

        private void FrmKhachhang_Load(object sender, EventArgs e)
        {
            try
            {
                loadgr();
                Loaddata();
            }
            catch (Exception)
            {
                MessageBox.Show("không có data");
            }
        }

        private void txtDienThoai_TextChanged(object sender, EventArgs e)
        {
            var a = txtDienThoai.Text.ToArray();
            if (txtDienThoai.Text != "")
            {
                label5.Visible = true;
                label5.Text = a.Length.ToString() + "/10";
                KhBLL.DienThoai = txtDienThoai.Text.Trim();
                if (KhBLL.checkdt() == false)
                {
                    MessageBox.Show("sdt gồm 10 kí tự số và không có kí tự chữ");
                    txtDienThoai.Clear();
                }
                if (a.Length != 10)
                {
                    label5.ForeColor = Color.Red;
                }
                else
                {
                    label5.ForeColor = Color.Green;
                }
            }
            else
            {
                label5.Visible = false;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhBLL.MaKH = txtMaKH.Text.Trim();
            KhBLL.HoTenKH = txtHotenKH.Text.Trim();
            KhBLL.DienThoai = txtDienThoai.Text.Trim();
            KhBLL.DiaChi = txtDiaChi.Text.Trim();

            KhBLL.UpdateData(KhBLL.kh);
            loadgr();
            Loaddata();
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            KhBLL.search = txtTimKiem.Text.Trim();
            List<KHACHHANG> kh = KhBLL.Searchitem();
            grKH.DataSource = kh;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
