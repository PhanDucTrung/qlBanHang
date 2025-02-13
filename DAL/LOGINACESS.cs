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
    public class LOGINACESS:Ketnoidulieu

    {
        public List<LOGIN> GetAllItem(string sql)
        {
            List<LOGIN> login = new List<LOGIN>();
            Myopen();
            // string sql = "select * from CHITIETHD";//sua 
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///
             
                string idu = dr.GetString(0);
             
                string uname = dr.GetString(1);
                string pass = dr.GetString(2);
                string MaNV = dr.GetString(4);
                int id_permission = dr.GetInt32(3);

                LOGIN lg= new LOGIN();


               lg.ID_USER=idu;
               lg.id_permission = id_permission;
               lg.UserName=uname;
              
               lg.Pass=pass;
               lg.MaNV=MaNV;

                login.Add(lg);
            }
            dr.Close();
            return login;
        }

        public List<permission> Getper(string sql)
        {
            List<permission> permissions = new List<permission>();
            Myopen();
           
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {///

                int idper = dr.GetInt32(0);
                string nameper = dr.GetString(1);
                string Describe = dr.GetString(2);


                permission per = new permission();
                per.id_permission = idper;
                per.Name_permission = nameper;
                per.Describe = Describe;




                permissions.Add(per);
            }
            dr.Close();
            return permissions;
        }

        public bool Deletedata(LOGIN lg)
        {
            Myopen();

            string sql = "delete USERS where ID_USER=@IDU";

            SqlCommand command = new SqlCommand(sql, conn);
            command.Parameters.Add("@IDU", SqlDbType.VarChar).Value = lg.ID_USER;

            int kg = command.ExecuteNonQuery();

            return kg > 0;

        }


        public bool Insertdata(LOGIN lg)
        {
            Myopen();

            string sql = "insert into USERS (ID_USER, UserName, Pass,id_permission,MaNV) values(@IDU, @UN, @PASS,@IDPER,@MNV)";

            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.Add("@IDU", SqlDbType.VarChar).Value = lg.ID_USER;
        
            cmd.Parameters.Add("@UN", SqlDbType.VarChar).Value = lg.UserName;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = lg.Pass;
            cmd.Parameters.Add("@IDPER", SqlDbType.Int).Value = lg.id_permission;
            cmd.Parameters.Add("@MNV", SqlDbType.VarChar).Value = lg.MaNV;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;


        }

        public bool UpdateData(LOGIN lg)
        {
            string sql3 = "update  USERS set UserName=@UN, Pass=@PASS,id_permission=@IDPER,MaNV=@MNV where ID_USER=@IDU";
            SqlCommand cmd = new SqlCommand(sql3, conn);
            cmd.Parameters.Add("@IDU", SqlDbType.VarChar).Value = lg.ID_USER;
         
            cmd.Parameters.Add("@UN", SqlDbType.VarChar).Value = lg.UserName;
            cmd.Parameters.Add("@PASS", SqlDbType.VarChar).Value = lg.Pass;
            cmd.Parameters.Add("@IDPER", SqlDbType.Int).Value = lg.id_permission;
            cmd.Parameters.Add("@MNV", SqlDbType.VarChar).Value = lg.MaNV;
            int kg = cmd.ExecuteNonQuery();

            return kg > 0;
        }

    }
}
