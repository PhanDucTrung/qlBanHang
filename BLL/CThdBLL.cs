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
    public class CThdBLL
    {

        CHITIETHDACESS cthd = new CHITIETHDACESS();

        public CHITIETHD ct = new CHITIETHD();
        public string MaHD;
        public string MaSP;
        public string SoLuong;
        public int state;
        public int month;
        public string search;


        public bool Deletedata(CHITIETHD ct)
        {
            ct.MaHD = int.Parse(MaHD); 
            return cthd.Deletedata(ct);
        }
        public string checkdata()
        {   
            if (MaHD == "" || MaSP.ToString() == "")
            {
                return "null";
            }
            if (SoLuong.ToString() == "")
            {
                return "hoi";

            }
            try
            {

                int.Parse(MaHD);
                int.Parse(SoLuong);
            }
            catch (Exception)
            {
                return "no";
            }

            List<CHITIETHD> check = cthd.GetAllItem("select * from CHITIETHOADON where MaSP= '" + MaHD + "' and  MaSP= '" + MaSP + "'");
       

            //if ( )
            //{
            //    return "yes";
            //}

            //if ((state == 1 & (spa.GetAllItem("select * from SanPham where TenSP= '" + ten + "'").Count > 0 || spa.GetAllItem("select * from SanPham where MaSP= '" + ma + "'").Count > 0) ) || (state == 2 & spa.GetAllItem("select * from SanPham where TenSP= '" + ten + "'").Count > 0))
            //{

            //    return "yes";
            //}
            if (state == 1 & check.Count>0 )
            {
                return "yes";
            }


            else


                return "ok";
        }
        public bool Insertdata(CHITIETHD ct)
        {
            ct.MaHD = int.Parse(MaHD);
            ct.MaSP = MaSP;
            ct.SoLuong = int.Parse(SoLuong);
            return cthd.Insertdata(ct);
        }

        //public bool UpdateData(CHITIETHD ct)
        //{
        //    ct.MaHD = int.Parse(MaHD);
        //    ct.MaSP = MaSP;
        //    ct.SoLuong = int.Parse(SoLuong);
        //    return cthd.UpdateData(ct);
        //}
        public List<CHITIETHD> GetAllItem( string sql)
        {

            return cthd.GetAllItem(sql);
        }
        public List<CHITIETHD> Searchitem()
        {
         string   sql = "select CHITIETHD.MaHD,CHITIETHD.MaSP,CHITIETHD.SoLuong from CHITIETHD,SANPHAM where CHITIETHD.MaSP = SANPHAM.MaSP AND  TenSP like N'%" + search + "%' or CHITIETHD.SoLuong like '" + search+"' GROUP BY MaHD,CHITIETHD.MaSP,CHITIETHD.SoLuong";
            return cthd.GetAllItem(sql);
        }

        public List<CHITIETHD> SL()
        {

            string sql = "SELECT MaSP,SUM(SoLuong) FROM	dbo.CHITIETHD GROUP BY MaSP";
            return cthd.GetAllItem(sql);
        }
        public List<DOANHSO> money()
        {      
            return cthd.GetMoney();
        }
       

        public List<DOANHSO> time()
        {
            return cthd.GetTime();
        }

        public List<DOANHSO> sp()
        {
            return cthd.Getsp();
        }
    }
}
