using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ketnoidulieu
    {
        public string strconn = "Data Source=trung;Initial Catalog=QLBanHangPro;Integrated Security=True";
        public SqlConnection conn = null;


        public void Myopen()
        {
            if (conn == null) conn = new SqlConnection(strconn);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void Myclosed()
        {
            if (conn != null) conn.Close();
            if (conn.State == ConnectionState.Open) conn.Close();
        }
    }
}
