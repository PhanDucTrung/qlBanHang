using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BLL
{
    public class BanHangBLL
    {   
        KHACHHANGACESS kha = new KHACHHANGACESS();
        HOADONACESS hda = new HOADONACESS();
        CHITIETHDACESS cthda = new CHITIETHDACESS();
        NHANVIENACESS nva = new NHANVIENACESS();
        SANPHAMACESS spa = new SANPHAMACESS();
        public string MaKH;
        public string HoTenKH;
        public string DiaChi;
        public string DienThoai;

        public int MaHD;
        public string MaNV;
        public string NgayLapHD;
        public string NgayNhanHang;

        public string MaSP;
        public string SoLuong;


        public string TenNV;

        public string TenSP;
        public string DonGia;
        public string DonViTinh;
        public int items;

        public int hienco;

        public int TongSL;
        public int SoLuongBan;
        public KHACHHANG kh = new KHACHHANG();
        public HOADON hd = new HOADON();
        public CHITIETHD cthd = new CHITIETHD();
        public HANGNHAPACESS hna = new HANGNHAPACESS();
        public SANPHAM sp=new SANPHAM();
        //public BANHANG bh = new BANHANG();
        public bool Insertdata(KHACHHANG kh, HOADON hd, CHITIETHD cthd)
        {
            if (HoTenKH == "")
            {
               HoTenKH = "Khách Lẻ";
            }
            List<KHACHHANG> slk = kha.GetAllItem("select * from KHACHANG where HoTenKH=N'" + HoTenKH + "' and DienThoai='" + DienThoai + "'");
            if (slk.Count==0)
            {
                kh.MaKH = "KH" + (kha.GetAllItem("select * from KHACHANG").Count + 1).ToString();

                kh.HoTenKH = HoTenKH;
                kh.DienThoai = DienThoai;
                kh.DiaChi = DiaChi;
                kha.Insertdata(kh);
                MaKH = kh.MaKH;
            }
            else
            {
                MaKH = slk[0].MaKH;
            }
            if (hda.GetAllItem("select * from HOADON where MaHD='"+MaHD+"'").Count==0)
            {
                hd.MaHD = hda.GetAllItem("select * from HOADON").Count + 1;
                hd.MaKH = MaKH;
                hd.MaNV = MaNV;
                hd.NgayLapHD = NgayLapHD;
                //hd.NgayNhanHang = NgayNhanHang;
                hda.Insertdata(hd);
                MaHD=hd.MaHD;
            }
           


            cthd.MaHD = hd.MaHD;
            cthd.MaSP = MaSP;
            cthd.SoLuong = int.Parse(SoLuong);

            List<SANPHAM> sl=  spa.GetAllItem("select * from SANPHAM WHERE MaSP='"+MaSP+"'");
            List<HANGNHAP> hangnhap = hna.GetSlN("SELECT MaSP,TenSP,SUM(SoLuongNhap) FROM dbo.HANGNHAP WHERE TenSP='" + TenSP + "' GROUP BY TenSP,MaSP ");
         
            if (hangnhap.Count==0)
            {
                TongSL = sl[0].Soluong;

            }
            else { TongSL = hangnhap[0].TongSLN; }

            
            sp.TenSP = TenSP;
            sp.Soluong = TongSL - cthd.SoLuong;
         
         spa.Update(sp);
            return   cthda.Insertdata(cthd);
        }

        public List<SANPHAM> Getitem()
        {
            string sql = "select * from SANPHAM where TenSP= '" + TenSP + "' ";
            return spa.GetAllItem(sql);
        }

        public string checkdata()
        {
            var a = HoTenKH.ToArray();
            int b=0;
            for (int i = 0; i <a.Length; i++)
            {
                try
                {
                    Convert.ToInt32(HoTenKH.ToArray()[i].ToString());
                    b++;
                }
                catch (Exception)
                {
                
                }
                if (b>0)
                {
                    return "hoi";

                }
             
            }
          

            return "ok";
        }
        public bool checkdt()
        {
            if (DienThoai.Length>10)
            {
                return false;
            }
            try
            {
                int.Parse(DienThoai);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool checksl()
        {
            try
            {
                int.Parse(SoLuong);
            }
            catch (Exception)
            {

                return false;
            }
                if (int.Parse(SoLuong) > hienco)
                {
                    return false;
                }
                return true;
            
           
        }
        //public List<BANHANG> shopping()
        //{
        //    List<BANHANG> banhangg = new List<BANHANG>();
  
        //    bh.DonGia = int.Parse(DonGia);
        //    bh.MaHD = hda.GetAllItem("select * from HOADON").Count + 1;
        //    bh.TenSP = TenSP;
        //    bh.DonViTinh = DonViTinh;
        //    bh.SoLuong = int.Parse(SoLuong);
        //    bh.money = bh.SoLuong * bh.DonGia;
        //    banhangg.Add(bh);
        //    return banhangg;

        //}


       

    }

   
}
