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
    public class HANGNHAPACESS:Ketnoidulieu
    {
        public List<HANGNHAP> GetAllItem(string sql)
        {
            List<HANGNHAP> dshn = new List<HANGNHAP>();
            Myopen();
           
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                string masp = dr.GetString(0);
                string tensp = dr.GetString(1);
                string dv = dr.GetString(2);
                int sl = dr.GetInt32(3);
                int dg = dr.GetInt32(4);
                string macc = dr.GetString(5);
                DateTime ngay = dr.GetDateTime(6);
                string manv = dr.GetString(7);




                HANGNHAP hn = new HANGNHAP();
                hn.MaSP=masp;
                hn.TenSP=tensp;
                hn.DonViTinh = dv;
                hn.SoLuongNhap = sl;
                hn.DonGiaNhap = dg;
                hn.MaNCC = macc;
                hn.NgayNhapHang = ngay.ToString();
                hn.MaNV = manv;
                dshn.Add(hn);
            }
            dr.Close();



            return dshn;
        }


        //public bool Deletedata(HANGNHAP hn)
        //{
        //    Myopen();

        //    string sql = "delete HANGNHAP where MaHD=@HD";

        //    SqlCommand command = new SqlCommand(sql, conn);
        //    command.Parameters.Add("@HD", SqlDbType.Int).Value = hd.MaHD;

        //    int kg = command.ExecuteNonQuery();

        //    return kg > 0;

        //}


        public bool Insertdata(HANGNHAP hn)
        {
            Myopen();

            string sql = "insert into HANGNHAP(MaSP,TenSP,DonViTinh,SoLuongNhap,DonGiaNhap,MaNCC,NgayNhapHang,MaNV) values(@MSP, @TSP, @DV, @SL, @DG,@MNCC,@NGAY,@MNV)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MSP", SqlDbType.VarChar).Value = hn.MaSP;
            cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = hn.TenSP;
            cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = hn.DonViTinh;
            cmd.Parameters.Add("@SL", SqlDbType.NVarChar).Value = hn.SoLuongNhap;
            cmd.Parameters.Add("@DG", SqlDbType.NVarChar).Value = hn.DonGiaNhap;
            cmd.Parameters.Add("@MNCC", SqlDbType.NVarChar).Value = hn.MaNCC;
            cmd.Parameters.Add("@NGAY", SqlDbType.DateTime).Value = hn.NgayNhapHang;
            cmd.Parameters.Add("@MNV", SqlDbType.VarChar).Value = hn.MaNV;


            int kg = cmd.ExecuteNonQuery();

            return kg > 0;

        }

        //public bool UpdateData(HANGNHAP hn)
        //{
        //    string sql3 = "update  HOADON set   MaKH=@MKH, MaNV=@MNV, NgayLapHD=@NLHD, NgayNhanHang=@NNH  where MaHD=@MHD";
        //    SqlCommand cmd = new SqlCommand(sql3, conn);
        //    cmd.Parameters.Add("@MSP", SqlDbType.VarChar).Value = hn.MaSP;
        //    cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = hn.TenSP;
        //    cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = hn.DonViTinh;
        //    cmd.Parameters.Add("@SL", SqlDbType.NVarChar).Value = hn.SoLuongNhap;
        //    cmd.Parameters.Add("@DG", SqlDbType.NVarChar).Value = hn.DonGiaNhap;
        //    cmd.Parameters.Add("@MNCC", SqlDbType.NVarChar).Value = hn.MaNCC;
        //    cmd.Parameters.Add("@NGAY", SqlDbType.DateTime).Value = hn.NgayNhapHang;
        //    int kg = cmd.ExecuteNonQuery();

        //    return kg > 0;
        //}
        public List<HANGNHAP> GetSlN(string sql)
        {
            List<HANGNHAP> dshn = new List<HANGNHAP>();
            Myopen();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                string masp = dr.GetString(0);
                string tensp = dr.GetString(1);
                    int tsln=dr.GetInt32(2);
                int dongia = dr.GetInt32(2);
                HANGNHAP hn = new HANGNHAP();
                hn.MaSP = masp;
                hn.TenSP = tensp;
                hn.TongSLN = tsln;
                hn.DonGiaNhap = dongia;
                dshn.Add(hn);
            }
            dr.Close();



            return dshn;
        }

  
    }
}
