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
    public class SANPHAMACESS:Ketnoidulieu
    { 
        public List<SANPHAM> GetAllItem(string sql)
        {   
            
            List<SANPHAM> dssp = new List<SANPHAM>();
            Myopen();
            //string sql = "select * from SANPHAM";
            //sql = "select * from SANPHAM";
            SqlCommand cmd = new SqlCommand(sql,conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                string ma = dr.GetString(0);
                string ten = dr.GetString(1);
                int gia = dr.GetInt32(3);
                string dv = dr.GetString(2);
                int sl= dr.GetInt32(4);

                SANPHAM sp = new SANPHAM();


                sp.DonGia = gia;
                sp.TenSP = ten;
                sp.MaSP = ma;
                sp.DonViTinh = dv;
                sp.Soluong = sl;
                /////
                dssp.Add(sp);
            }
            dr.Close();



            return dssp;
        }
     
      
        
        public bool Deletedata(SANPHAM sp)
        {
            Myopen();

            string sql = "delete SANPHAM where MaSP=@SP";


            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@SP", SqlDbType.VarChar).Value = sp.MaSP;

            int kg = cmd.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(SANPHAM sp)
        {
            Myopen();

            string sql = "insert into SANPHAM(MaSP, TenSP, DonViTinh, DonGia ,Soluong) values(@SP, @TSP, @DV, @GIA ,@SL)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@SP", SqlDbType.VarChar).Value = sp.MaSP;
            cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = sp.TenSP;
            cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = sp.DonViTinh;
            cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = sp.DonGia;
            cmd.Parameters.Add("@SL", SqlDbType.Int).Value = sp.Soluong;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;


        }

        public bool UpdateData(SANPHAM sp)
        {
            string sql3 = "update  SANPHAM set   TenSP=@TSP,DonViTinh=@DV, DonGia=@GIA,SoLuong=@SL  where MaSP=@SP ";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@SP", SqlDbType.VarChar).Value = sp.MaSP;
            cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = sp.TenSP;
            cmd.Parameters.Add("@DV", SqlDbType.NVarChar).Value = sp.DonViTinh;
            cmd.Parameters.Add("@GIA", SqlDbType.Int).Value = sp.DonGia;
            cmd.Parameters.Add("@SL", SqlDbType.Int).Value = sp.Soluong;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }
        public bool Update(SANPHAM sp)
        {
            string sql3 = "update  SANPHAM set SoLuong=@SL  where TenSP=@TSP ";
            SqlCommand cmd = new SqlCommand(sql3, conn);
          
            cmd.Parameters.Add("@TSP", SqlDbType.NVarChar).Value = sp.TenSP;
            cmd.Parameters.Add("@SL", SqlDbType.Int).Value = sp.Soluong;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }
        }
}
