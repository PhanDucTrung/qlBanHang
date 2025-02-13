using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class HOADONACESS:Ketnoidulieu
    {
        public List<HOADON> GetAllItem(string sql)
        {
            List<HOADON> dshd = new List<HOADON>();
            Myopen();
            //string sql = "select * from HOADON";//sua 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                int mahd = dr.GetInt32(0);
                string makh = dr.GetString(1);
                string manv = dr.GetString(2);
                DateTime ngaylaphd = dr.GetDateTime(3);
                //DateTime ngaynhanhang = dr.GetDateTime(4);


                HOADON hd = new HOADON();


                hd.MaHD = mahd;
                hd.MaKH = makh;
                hd.MaNV = manv;
                hd.NgayLapHD = ngaylaphd.ToString();
                //hd.NgayNhanHang = ngaynhanhang.ToString();

                /////
                dshd.Add(hd);
            }
            dr.Close();



            return dshd;
        }


        public bool Deletedata(HOADON hd)
        {
            Myopen();

            string sql = "delete HOADON where MaHD=@HD";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@HD", SqlDbType.Int).Value = hd.MaHD;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(HOADON hd)
        {
            Myopen();

            string sql = "insert into HOADON(MaHD, MaKH, MaNV, NgayLapHD) values(@MHD, @MKH, @MNV, @NLHD)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MHD", SqlDbType.Int).Value = hd.MaHD;
            cmd.Parameters.Add("@MKH", SqlDbType.NVarChar).Value = hd.MaKH;
            cmd.Parameters.Add("@MNV", SqlDbType.NVarChar).Value = hd.MaNV;
            cmd.Parameters.Add("@NLHD", SqlDbType.Date).Value = hd.NgayLapHD;
            //cmd.Parameters.Add("@NNH", SqlDbType.DateTime).Value = hd.NgayNhanHang;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;

        }

        public bool UpdateData(HOADON hd)
        {
            string sql3 = "update  HOADON set   MaKH=@MKH, MaNV=@MNV, NgayLapHD=@NLHD where MaHD=@MHD";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@MHD", SqlDbType.Int).Value = hd.MaHD;
            cmd.Parameters.Add("@MKH", SqlDbType.NVarChar).Value = hd.MaKH;
            cmd.Parameters.Add("@MNV", SqlDbType.NVarChar).Value = hd.MaNV;
            cmd.Parameters.Add("@NLHD", SqlDbType.DateTime).Value = hd.NgayLapHD;
            //cmd.Parameters.Add("@NNH", SqlDbType.DateTime).Value = hd.NgayNhanHang;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }

    }
}
