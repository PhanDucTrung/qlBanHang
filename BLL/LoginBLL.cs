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
    public class LoginBLL
    {
        public string username;
        public string password;
        public string idu;
        public int idper;
        public string MaNV;
        LOGINACESS lgass =new LOGINACESS();
        public LOGIN lg=new LOGIN();
        public List<LOGIN> datalogin()
        {

            string sql = " SELECT * FROM  dbo.USERS WHERE  UserName='" + username+"' AND Pass='"+password+"'";
            return lgass.GetAllItem(sql);
        }
        public List<LOGIN> getAllitems(string sql)
        {

          
            return lgass.GetAllItem(sql);
        }
        public List<permission> GetPer(string sql)
        {
         

            return lgass.Getper(sql);
        }

        public bool Insertdata(LOGIN lg)
        {
            lg.ID_USER = "user" + (lgass.GetAllItem(" select * from USERS").Count + 1).ToString();
                lg.UserName = username;
                lg.Pass = password;
                lg.id_permission = idper;
                lg.MaNV = MaNV;
            return lgass.Insertdata(lg);
        }

        public bool UpdateData(LOGIN lg)
        {
            lg.ID_USER = idu;
            lg.UserName = username;
            lg.Pass = password;
            lg.id_permission = idper;
            lg.MaNV = MaNV;
            return lgass.UpdateData(lg);
        }
        public bool Deletedata(LOGIN lg)
        {
            lg.ID_USER = idu;

            return lgass.Deletedata(lg);
        }
    }
}
