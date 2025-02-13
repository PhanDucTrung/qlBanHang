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
    public class NHANVIENACESS : Ketnoidulieu
    {
        public List<NHANVIEN> GetAllItem(string sql)
        {
            List<NHANVIEN> dsnv = new List<NHANVIEN>();
            Myopen();
          //  string sql = "select * from NHANVIEN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string manv = dr.GetString(0);
                string honv = dr.GetString(1);
                string tennv = dr.GetString(2);
                bool gioitinh = dr.GetBoolean(3);
                DateTime ngaysinh = dr.GetDateTime(4);
                DateTime vaolam = dr.GetDateTime(8);
                string diachi = dr.GetString(5);
                string dienthoai = dr.GetString(6);
                string trangthai = dr.GetString(7);


                NHANVIEN nv = new NHANVIEN();


                nv.MaNV = manv;
                nv.HoNV = honv;
                nv.TenNV = tennv;
                nv.GioiTinh = gioitinh;
                nv.Ngaysinh = ngaysinh.ToString();
                nv.DiaChi = diachi;
                nv.DienThoai = dienthoai;
                nv.TrangThai = trangthai;
                nv.NgayVaoLam = vaolam.ToString();

                dsnv.Add(nv);
            }
            dr.Close();



            return dsnv;
        }


        public bool Deletedata(NHANVIEN nv)
        {
            Myopen();

            string sql = "delete NHANVIEN where MaNV=@MNV";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@MANV", SqlDbType.VarChar).Value = nv.MaNV;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(NHANVIEN nv)
        {
            Myopen();

            string sql = "insert into NHANVIEN(MaNV, HoNV, TenNV, GioiTinh, NgaySinh, DiaChi, DienThoai, TrangThai,NgayVaoLam) values(@MNV, @HNV, @TNV, @GT, @NS, @DC, @DT, @TT,@NVL)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MNV", SqlDbType.VarChar).Value = nv.MaNV;
            cmd.Parameters.Add("@HNV", SqlDbType.NVarChar).Value = nv.HoNV;
            cmd.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = nv.TenNV;
            cmd.Parameters.Add("@GT", SqlDbType.Bit).Value = nv.GioiTinh;
            cmd.Parameters.Add("@NS", SqlDbType.Date).Value = nv.Ngaysinh;
            cmd.Parameters.Add("@NVL", SqlDbType.Date).Value = nv.NgayVaoLam;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("@DT", SqlDbType.NVarChar).Value = nv.DienThoai;
            cmd.Parameters.Add("@TT", SqlDbType.NVarChar).Value = nv.TrangThai;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;


        }

        public bool UpdateData(NHANVIEN nv)
        {
            string sql3 = "update  NHANVIEN set   HoNV=@HNV, TenNV=@TNV, GioiTinh=@GT, NgaySinh=@NS, DiaChi=@DC, DienThoai=@DT, TrangThai=@TT,NgayVaoLam=@NVL where MaNV=@MNV";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@MNV", SqlDbType.VarChar).Value = nv.MaNV;
            cmd.Parameters.Add("@HNV", SqlDbType.NVarChar).Value = nv.HoNV;
            cmd.Parameters.Add("@TNV", SqlDbType.NVarChar).Value = nv.TenNV;
            cmd.Parameters.Add("@GT", SqlDbType.Bit).Value = nv.GioiTinh;
            cmd.Parameters.Add("@NS", SqlDbType.Date).Value = nv.Ngaysinh;
            cmd.Parameters.Add("@NVL", SqlDbType.Date).Value = nv.NgayVaoLam;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = nv.DiaChi;
            cmd.Parameters.Add("@DT", SqlDbType.NVarChar).Value = nv.DienThoai;
            cmd.Parameters.Add("@TT", SqlDbType.NVarChar).Value = nv.TrangThai;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }

    }
}
