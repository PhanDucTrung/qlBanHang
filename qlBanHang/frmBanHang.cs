using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using BLL;
using DTO;

namespace qlBanHang
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        BanHangBLL bhbll = new BanHangBLL();
        spBLL spbll = new spBLL();
        NvBLL nvBLL = new NvBLL();
        HdBLL HdBLL = new HdBLL();
        KhBLL khBLL = new KhBLL();
        int a;
        private List<DATABANHANG> spb = new List<DATABANHANG>();
        

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            List<SANPHAM> sans = spbll.GetAllItem("SELECT * from SANPHAM");

            if (comboBox1.SelectedIndex > -1)
            {
                if (txtSl.Text != "hiện có" + sans[comboBox1.SelectedIndex].Soluong.ToString())
                {
                    if (txtSl.Text != "")
                    {
                        bhbll.SoLuong = txtSl.Text;

                        if (bhbll.checksl() == false)
                        {
                            MessageBox.Show("Vượt quá sl hiện có or \n trong sl có chứa kí tự  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSl.Text = sans[comboBox1.SelectedIndex].Soluong.ToString();
                        }
                    }
                }
            }
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            loadgr();
            txtSl.Clear();
        }
        private void loadgr()
        {


            List<SANPHAM> sans = spbll.GetAllItem("SELECT * from SANPHAM");


            comboBox1.DataSource = sans;
            comboBox1.DisplayMember = "TenSP";
            comboBox1.ValueMember = "MaSP";
            comboBox1.SelectedIndex = -1;

            //List<NHANVIEN> nv = nvBLL.GetAllItem("select * from NNHANVIEN");
            //comboBox2.DataSource = nv;
            //comboBox2.DisplayMember = "TenNV";
            //comboBox2.ValueMember = "MaNV";

            //List<KHACHHANG> kh = khBLL.GetAllItem(" select * from KHACHANG");

            //cmbkh.DataSource = kh;
            //cmbkh.DisplayMember = "HoTenKH";
            //cmbkh.ValueMember = "MaKH";
            //cmbkh.SelectedIndex = -1;



        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SANPHAM> sans = spbll.GetAllItem("SELECT * from SANPHAM");
            List<HOADON> hd = HdBLL.GetAllItem("SELECT * FROM HOADON");
            //List<KHACHHANG> kh1 = khBLL.GetAllItem("select * from KHACHANG ");
            //var b = 0;
            //for (int i = 0; i < kh1.Count; i++)
            //{
            //    if (cmbkh.Text == kh1[i].HoTenKH)
            //    {
            //        b++;
            //    }
            //}

            DATABANHANG itemss = new DATABANHANG();
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("chon mawtj hang");
            }
            else
            {


                itemss.MaSP = comboBox1.SelectedValue.ToString();
                itemss.TenSP = comboBox1.Text;

                if ((txtSl.Text == "hiện có" + sans[comboBox1.SelectedIndex].Soluong.ToString() || txtSl.Text == ""))
                {
                    txtSl.Text = "1";

                    itemss.SoLuong = int.Parse(txtSl.Text.Trim());
                }
                else
                {

                    itemss.SoLuong = int.Parse(txtSl.Text.Trim());

                }

                itemss.DonGia = int.Parse(sans[comboBox1.SelectedIndex].DonGia.ToString());
                itemss.DonViTinh = sans[comboBox1.SelectedIndex].DonViTinh.ToString();

                itemss.money = itemss.DonGia * itemss.SoLuong;

                if (txtTenKH.Text != "" )
                {
                    List<KHACHHANG> kh = khBLL.GetAllItem("select * from KHACHANG where HoTenKH='" + txtTenKH.Text + "'");

                    if (kh.Count > 0)
                    {
                        itemss.MaKH = kh[0].MaKH;
                    }
                }

                itemss.TenSP = comboBox1.Text.Trim();
                itemss.MaHD = hd.Count + 1;
                itemss.MaNV = DangNhap.Ma;
                itemss.DiaChi = cmbdc.Text.Trim();
                itemss.DienThoai = cmbdt.Text.Trim();
                itemss.NgayLapHD = dateTimePicker1.Text.Trim();
                //itemss.NgayNhanHang = dateTimePicker1.Text.Trim();
                itemss.HoTenKH = txtTenKH.Text.Trim();

                spb.Add(itemss);
                dataGridView1.DataSource = null;

                dataGridView1.DataSource = spb;
               
                dataGridView1.Columns["NgayLapHD"].Visible = false;
                dataGridView1.Columns["MaSP"].Visible = false;
                dataGridView1.Columns["MaNV"].Visible = false;
                dataGridView1.Columns["MaKH"].Visible = false;
                dataGridView1.Columns["DiaChi"].Visible = false;
                dataGridView1.Columns["DienThoai"].Visible = false;
                dataGridView1.Columns["HoTenKH"].Visible = false;


                textBox4.Text = (spb.Sum(x => x.money)).ToString();

                //textBox1.Text = dataGridView1.RowCount.ToString();

            }
        }

      

        private void txtSl_MouseClick(object sender, MouseEventArgs e)
        {
            txtSl.Clear();
        }

    


      

       

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {


            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                bhbll.DiaChi = spb[i].DiaChi;
                bhbll.HoTenKH = spb[i].HoTenKH;
                bhbll.MaSP = spb[i].MaSP;
                bhbll.SoLuong = spb[i].SoLuong.ToString();

                bhbll.NgayLapHD = spb[i].NgayLapHD;
                bhbll.DienThoai = spb[i].DienThoai;
                bhbll.MaNV = spb[i].MaNV;
                bhbll.MaKH = spb[i].MaKH;
                bhbll.MaHD = spb[i].MaHD;
                bhbll.TenSP = spb[i].TenSP;

                bhbll.Insertdata(bhbll.kh, bhbll.hd, bhbll.cthd);

            }
            MessageBox.Show("them thanh cong");
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
            spb.Clear();
            dataGridView1.DataSource = null;
         
            txtTenKH.Clear();
            textBox4.Clear();
            txtSl.Clear();
            cmbdc.SelectedIndex = -1;
            cmbdt.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var tieude = "Hóa Đon Bán Hàng ";
            var Store = "Demo Store ok bro  ";
            var Addess = "Số 1 VN";
            var Phone = 0398461674;
            var w = printDocument1.DefaultPageSettings.PaperSize.Width;
            var h = printDocument1.DefaultPageSettings.PaperSize.Height;

            //e.Graphics.DrawString("Thời Gian In:" + lbl_gio.Text + label7.Text, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(500, h - 20));
            e.Graphics.DrawString(Store.ToUpper() + h, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(300, 20));
            e.Graphics.DrawString(Addess.ToUpper(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(380, 40));
            e.Graphics.DrawString("DT" + Phone, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(350, 60));

            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, 90), new Point(w - 10, 90));
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, 100), new Point(w - 10, 100));
            e.Graphics.DrawString(tieude, new Font("Courier New", 16, FontStyle.Bold), Brushes.Red, new Point(300, 120));
            var hd = spb[0].MaHD;
            e.Graphics.DrawString(" ng bán: " + DangNhap.Ten, new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(20,150));
            e.Graphics.DrawString("Hóa Đơn Số  " + hd.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(340, 150));
            e.Graphics.DrawString("kh:" + txtTenKH.Text, new Font("Courier New", 12, FontStyle.Bold), Brushes.Black, new Point(20, 180));
            e.Graphics.DrawString("Dc:" + cmbdc.Text, new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(330, 180));
            e.Graphics.DrawString("DT:" + cmbdt.Text, new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(630, 180));

            e.Graphics.DrawString("STT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(20, 220));
            e.Graphics.DrawString("Tên SP", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(60, 220));
            e.Graphics.DrawString("Dơn VT", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(350, 220));
            e.Graphics.DrawString("SL", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(450, 220));
            e.Graphics.DrawString("Đơn Giá ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(530, 220));
            e.Graphics.DrawString("Thành Tiền ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(650, 220));
            var a = 1;
            var y = 240;
            foreach (var item in spb)
            {

                e.Graphics.DrawString(a.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(20, y));
                e.Graphics.DrawString(item.TenSP, new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(60, y));
                e.Graphics.DrawString(item.DonViTinh, new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(350, y));
                e.Graphics.DrawString(item.SoLuong.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(450, y));
                e.Graphics.DrawString(item.DonGia.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(530, y));
                e.Graphics.DrawString(item.money.ToString(), new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(650, y));


                y += 20;
                a++;
            }
            e.Graphics.DrawLine(new Pen(Color.Black, 1), new Point(10, y + 30), new Point(w - 10, y + 30));

            e.Graphics.DrawString("Tổng Tiền : " + (spb.Sum(x => x.money)).ToString() + "VND", new Font("Courier New", 12, FontStyle.Bold), Brushes.Green, new Point(500, y + 50));
            e.Graphics.DrawString("Thank's kiu baby da mua hàng  ", new Font("Courier New", 12, FontStyle.Bold), Brushes.Red, new Point(280, y + 150));
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            bhbll.HoTenKH = txtTenKH.Text.Trim();
            string get = bhbll.checkdata();

            if (get == "hoi")
            {
                label8.Text = "Trong tên đang chứa kí tự số  ";
                label8.ForeColor = Color.Orange;
                label8.Visible = true;
            }
            else label8.Visible = false;

            List<KHACHHANG> kh2 = khBLL.GetAllItem(" select * from KHACHANG where HoTenKH LIKE N'%" + txtTenKH.Text + "%'");
            cmbdt.DataSource = kh2;
            cmbdt.DisplayMember = "DienThoai";
            cmbdc.DataSource = kh2;
            cmbdc.DisplayMember = "DiaChi";
            cmbdt.Enabled = true;
            cmbdc.Enabled = true;
        }

        private void frmBanHang_TextChanged(object sender, EventArgs e)
        {
            if (cmbdt.Text != "")
            {
                bhbll.DienThoai = cmbdt.Text.Trim();
                if (bhbll.checkdt() == false)
                {
                    MessageBox.Show("sdt gồm 10 kí tự số và không có kí tự chữ");
                }
            }
        }

        private void cmbdc_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbdc_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<SANPHAM> sans = spbll.GetAllItem("SELECT * from SANPHAM");

            if (comboBox1.SelectedIndex > -1)
            {
                txtSl.Text = "hiện có" + sans[comboBox1.SelectedIndex].Soluong.ToString();
                txtSl.ForeColor = Color.DimGray;
                bhbll.hienco = sans[comboBox1.SelectedIndex].Soluong;
                txtSl.Enabled = true;
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
