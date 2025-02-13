using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CHITIETHDACESS:Ketnoidulieu
    {
        public List<CHITIETHD> GetAllItem(string sql)
        {
            List<CHITIETHD> dscthd = new List<CHITIETHD>();
            Myopen();
           // string sql = "select * from CHITIETHD";//sua 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                int mahd = dr.GetInt32(0);
                string masp = dr.GetString(1);
                int sl = dr.GetInt32(2);

                CHITIETHD cthd = new CHITIETHD();


                cthd.MaHD = mahd;
                cthd.MaSP = masp;
                cthd.SoLuong = sl;
                /////
                dscthd.Add(cthd);
            }
            dr.Close();



            return dscthd;
        }


        public bool Deletedata(CHITIETHD hd)
        {
            Myopen();

            string sql = "delete CHITIETHD where MaHD=@MHD and MaSP=@MSP";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MHD", SqlDbType.Int).Value = hd.MaHD;
            command.Parameters.Add("@MSP", SqlDbType.VarChar).Value = hd.MaSP;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(CHITIETHD cthd)
        {
            Myopen();

            string sql = "insert into CHITIETHD(MaHD, MaSP, SoLuong) values(@MHD, @MSP, @SL)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MHD", SqlDbType.Int).Value = cthd.MaHD;
            cmd.Parameters.Add("@MSP", SqlDbType.VarChar).Value = cthd.MaSP;
            cmd.Parameters.Add("@SL", SqlDbType.Int).Value = cthd.SoLuong;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;


        }

        //public bool UpdateData(CHITIETHD cthd)
        //{
        //    string sql3 = "update  CHITIETHD set   MaSP=@MSP,SoLuong=@SL where MaHD=@MHD";
        //    SqlCommand cmd = new SqlCommand(sql3, conn);
        //    cmd.Parameters.Add("@MHD", SqlDbType.Int).Value = cthd.MaHD;
        //    cmd.Parameters.Add("@MSP", SqlDbType.VarChar).Value = cthd.MaSP;
        //    cmd.Parameters.Add("@SL", SqlDbType.Int).Value = cthd.SoLuong;
        //    int kg = cmd.ExecuteNonQuery();

        //    return kg > 0;
        //}
        public List<CHITIETHD> GetSL(string sql)
        {
            List<CHITIETHD> dscthd = new List<CHITIETHD>();
            Myopen();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string masp = dr.GetString(0);
                int tsl = dr.GetInt32(1);
                CHITIETHD cthd = new CHITIETHD();
                cthd.MaSP = masp;
                cthd.TongSL = tsl;
                dscthd.Add(cthd);
            }
            dr.Close();



            return dscthd;
        }

        public List<DOANHSO> GetMoney()
        {
            string sql = "SELECT MONTH(dbo.HOADON.NgayLapHD),SUM(CHITIETHD.SoLuong),SUM(dbo.CHITIETHD.SoLuong*dbo.SANPHAM.DonGia) FROM dbo.CHITIETHD,dbo.HOADON,dbo.SANPHAM WHERE dbo.CHITIETHD.MaHD=dbo.HOADON.MaHD AND	dbo.CHITIETHD.MaSP=dbo.SANPHAM.MaSP GROUP BY MONTH(dbo.HOADON.NgayLapHD)";
            List<DOANHSO> dsmoney = new List<DOANHSO>();
            Myopen();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int ngay = dr.GetInt32(0);
                int TSl = dr.GetInt32(1);
                int tien = dr.GetInt32(2);


                DOANHSO ds = new DOANHSO();
                ds.NgayLapHD = ngay;

                ds.tien = tien;

                ds.SoLuong = TSl;
                dsmoney.Add(ds);
            }
            dr.Close();



            return dsmoney;
        }
        public List<DOANHSO> GetTime()
        {
            List<DOANHSO> time = new List<DOANHSO>();
            Myopen();
            string sql=" SELECT YEAR(dbo.HOADON.NgayLapHD), MONTH(dbo.HOADON.NgayLapHD) FROM dbo.HOADON GROUP BY YEAR(dbo.HOADON.NgayLapHD), MONTH(dbo.HOADON.NgayLapHD)";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int ngay = dr.GetInt32(1);
                int year = dr.GetInt32(0);
              

                DOANHSO ds = new DOANHSO();
                ds.NgayLapHD = ngay;
            
                ds.year = year;
              
                time.Add(ds);
            }
            dr.Close();



            return time;
        }

        public List<DOANHSO> Getsp()
        {
            List<DOANHSO> sp = new List<DOANHSO>();
            Myopen();
            string sql = " SELECT dbo.SANPHAM.TenSP,SUM(CHITIETHD.SoLuong) AS so_sp,SUM(dbo.CHITIETHD.SoLuong*dbo.SANPHAM.DonGia) FROM dbo.CHITIETHD,dbo.HOADON,dbo.SANPHAM WHERE dbo.CHITIETHD.MaHD=dbo.HOADON.MaHD AND	dbo.CHITIETHD.MaSP=dbo.SANPHAM.MaSP AND	 MONTH(dbo.HOADON.NgayLapHD)=10 GROUP BY dbo.SANPHAM.TenSP";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string ten = dr.GetString(0);
                int TSl = dr.GetInt32(1);
                int tien = dr.GetInt32(2);


                DOANHSO ds = new DOANHSO();
                ds.TenSP = ten;

                ds.tien = tien;

                ds.SoLuong = TSl;
                sp.Add(ds);
            }
            dr.Close();



            return sp;
        }
    }
}
