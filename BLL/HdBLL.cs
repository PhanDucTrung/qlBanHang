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
    public class HdBLL
    {

        HOADONACESS hda = new HOADONACESS();

        public HOADON hd= new HOADON();
        public string MaHD ;
        public string MaKH;
        public string MaNV;
        public string NgayLapHD;
        public string NgayNhanHang;
        public int state;
        public string search;


        public bool Deletedata(HOADON hd)
        {
            hd.MaHD = int.Parse(MaHD); ;
            return hda.Deletedata(hd);
        }
        public string checkdata()
        {

            try
            {
                int.Parse(MaHD);
            }
            catch (Exception)
            {
                return "no";
            }
            if (MaHD == ""|| MaKH.ToString() == "" || MaNV.ToString() == ""  )
            {
                return "null";
            }
            //if ()
            //{
            //    return "hoi";

            //}
          

       

            //if ( )
            //{
            //    return "yes";
            //}

            //if ((state == 1 & (spa.GetAllItem("select * from SanPham where TenSP= '" + ten + "'").Count > 0 || spa.GetAllItem("select * from SanPham where MaSP= '" + ma + "'").Count > 0) ) || (state == 2 & spa.GetAllItem("select * from SanPham where TenSP= '" + ten + "'").Count > 0))
            //{

            //    return "yes";
            //}
           
            else


                return "ok";
        }
        public bool Insertdata(HOADON hd)
        {
            hd.MaHD = hda.GetAllItem("select * from HOADON").Count + 1;
            hd.MaKH = MaKH;
            hd.MaNV = MaNV;
            hd.NgayLapHD = NgayLapHD;
            //hd.NgayNhanHang=NgayNhanHang;
            return hda.Insertdata(hd);
        }

        public bool UpdateData(SANPHAM sp)
        {
            hd.MaHD = int.Parse(MaHD);
            hd.MaKH = MaKH;
            hd.MaNV = MaNV;
            hd.NgayLapHD = NgayLapHD;
            //hd.NgayNhanHang = NgayNhanHang;
            return hda.UpdateData(hd);
        }
        public List<HOADON> GetAllItem(string sql)
        {

         
            return hda.GetAllItem(sql);
        }

        public List<HOADON> Searchitem()
        {
            string sql = "select HOADON.MaHD,HOADON.MaKH,HOADON.MaNV,HOADON.NgayLapHD from HOADON,NHANVIEN,KHACHANG where HOADON.MaNV = NHANVIEN.MaNV AND HOADON.MaKH=KHACHANG.MaKH AND ( HoTenKH like N'%" + search + "%' or TenNV like N'%" + search + "%' or NgayLapHD like '" + search + "')";
            return hda.GetAllItem(sql);
        }

    }
}
