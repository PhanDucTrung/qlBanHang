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
    public class NCCACESS:Ketnoidulieu
    {
        public List<NHACUNGCAP> GetAllItem(string sql)
        {
            List<NHACUNGCAP> dsncc = new List<NHACUNGCAP>();
            Myopen();
           
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
                string mancc = dr.GetString(0);
                string tenncc = dr.GetString(1);
                string diachi = dr.GetString(2);
                string lienhe = dr.GetString(3);
           

                NHACUNGCAP ncc = new NHACUNGCAP();
                ncc.DiaChi = diachi;
                ncc.MaNCC = mancc;
                ncc.TenNCC= tenncc;
                ncc.LienHe = lienhe;



                /////
                dsncc.Add(ncc);
            }
            dr.Close();



            return dsncc;
        }


        public bool Deletedata(NHACUNGCAP ncc)
        {
            Myopen();

            string sql = "delete NHACUNGCAP where MaNCC=@CC";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@CC", SqlDbType.VarChar).Value = ncc.MaNCC;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(NHACUNGCAP ncc)
        {
            Myopen();

            string sql = "insert into NHACUNGCAP(MaNCC,TenNCC, DiaChi, LienHe) values(@MNCC, @TNCC, @DC, @LH)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@MNCC", SqlDbType.VarChar).Value = ncc.MaNCC;
            cmd.Parameters.Add("@TNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = ncc.DiaChi;
            cmd.Parameters.Add("@LH", SqlDbType.NVarChar).Value = ncc.LienHe;

            int kg = cmd.ExecuteNonQuery();

            return kg > 0;

        }

        public bool UpdateData(NHACUNGCAP ncc)
        {
            string sql3 = "update  NHACUNGCAP set TenNCC=@TNCC,DiaChi=@DC,LienHe=@LH where MaNCC=@MNCC";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@MNCC", SqlDbType.VarChar).Value = ncc.MaNCC;
            cmd.Parameters.Add("@TNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
            cmd.Parameters.Add("@DC", SqlDbType.NVarChar).Value = ncc.DiaChi;
            cmd.Parameters.Add("@LH", SqlDbType.NVarChar).Value = ncc.LienHe;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }

    }
}
