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
    public class KHACHHANGACESS:Ketnoidulieu
    {
        public List<KHACHHANG> GetAllItem(string sql)
        {
            List<KHACHHANG> dskh = new List<KHACHHANG>();
            Myopen();
          //  string sql = "select * from KHACHHANG";//sua 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                string makh = dr.GetString(0);
                string hotenkh = dr.GetString(1);
                string diachi = dr.GetString(2);
                string dienthoai = dr.GetString(3);
                //int thd = dr.GetInt32(4);

                KHACHHANG kh = new KHACHHANG();


                kh.MaKH = makh;
                kh.HoTenKH = hotenkh;
                kh.DiaChi = diachi;
                kh.DienThoai = dienthoai;
                //kh.SLDH = thd;
                /////
                dskh.Add(kh);
            }
            dr.Close();



            return dskh;
        }


        public bool Deletedata(KHACHHANG kh)
        {
            Myopen();

            string sql = "delete KHACHANG where MaKH=@MKH";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MKH", SqlDbType.VarChar).Value = kh.MaKH;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(KHACHHANG kh)
        {
            Myopen();

            string sql = "insert into KHACHANG(MaKH, HoTenKH, DiaChi, DienThoai) values(@MKH, @HTKH, @DC, @DT)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MKH", SqlDbType.VarChar).Value = kh.MaKH;
            cmd.Parameters.Add("@HTKH", SqlDbType.NVarChar).Value = kh.HoTenKH;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = kh.DiaChi;
            cmd.Parameters.Add("@DT", SqlDbType.NVarChar).Value = kh.DienThoai;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;


        }

        public bool UpdateData(KHACHHANG kh)
        {
            string sql3 = "update  KHACHANG set   HoTenKH=@HTKH,DiaChi=@DC, DienThoai=@DT  where MaKH=@MKH";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@MKH", SqlDbType.VarChar).Value = kh.MaKH;
            cmd.Parameters.Add("@HTKH", SqlDbType.NVarChar).Value = kh.HoTenKH;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = kh.DiaChi;
            cmd.Parameters.Add("@DT", SqlDbType.NVarChar).Value = kh.DienThoai;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }

    }
}
