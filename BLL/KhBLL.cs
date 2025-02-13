using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using DAL;
namespace BLL
{
    public class KhBLL
    {
        KHACHHANGACESS khass = new KHACHHANGACESS();

        public KHACHHANG kh = new KHACHHANG();
        public string MaKH;
        public string HoTenKH;
        public string DiaChi;
        public string DienThoai;
        public string search;

    public int state;


        public bool Deletedata(KHACHHANG kh)
        {
            kh.MaKH = MaKH;
            return khass.Deletedata(kh);
        }
        public string checkdata()
        {
            if (MaKH == "" || HoTenKH.ToString() == "")
            {
                return "null";
            }
            if (DiaChi.ToString() == "" || DienThoai=="")
            {
                return "hoi";

            }
            //try
            //{

            //    int.Parse(gia);
            //    int.Parse(sl);
            //}
            //catch (Exception)
            //{
            //    return "no";
            //}

            List<KHACHHANG> sans = khass.GetAllItem("select * from SanPham where MaKH= '" + MaKH + "'");
        
            if (state == 1 & (sans[0] != null ))
            {
                return "yes";
            }
            else


                return "ok";
        }
        public bool checkdt()
        {
           
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

        public bool Insertdata(KHACHHANG kh)
        {
            kh.MaKH ="KH"+ (khass.GetAllItem(" select * from KHACHANG").Count+1).ToString();
            kh.HoTenKH = HoTenKH;
            kh.DienThoai = DienThoai;
            kh.DiaChi= DiaChi;
            return khass.Insertdata(kh);
        }

        public bool UpdateData(KHACHHANG kh)
        {
            kh.MaKH = MaKH;
            kh.HoTenKH = HoTenKH;
            kh.DienThoai = DienThoai;
            kh.DiaChi = DiaChi;
            return khass.UpdateData(kh);
        }
        public List<KHACHHANG> GetAllItem(string sql)
        {

            //sql = "select * from KHACHANG";
            return khass.GetAllItem(sql);
        }
        public List<KHACHHANG> Searchitem()
        {
            string sql = "SELECT * FROM	dbo.KHACHANG WHERE (HoTenKH LIKE N'%"+search+ "%' OR DiaChi LIKE N'%" + search + "%' OR DienThoai LIKE '%" + search + "%')";
            return khass.GetAllItem(sql);
        }

    }
}
