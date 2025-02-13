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
    public class spBLL
    {

        SANPHAMACESS spa = new SANPHAMACESS();

        public SANPHAM sp = new SANPHAM();
          public  string ma;
          public   string ten;
          public  string gia;
          public   string dv;
        public string sl;
        public int state;


        public bool Deletedata(SANPHAM sp)
        {
            sp.MaSP = ma; ;
            return spa.Deletedata(sp);
        }
        public string checkdata()
        {
            for (int i = 0; i < ten.ToArray().Length; i++)
            {
                try
                {
                    int.Parse(ten.ToArray()[i].ToString());
                    return "hoi";
                }
                catch (Exception)
                {
                }
            }

            if (ma=="" )
            {
                return "null";
            }
            if (dv.ToString() == "" || ten.ToString() == "")
            {
                return "hoi";
            }
            try
            { 
                int.Parse(gia);
                int.Parse(sl);
            }
            catch (Exception)
            {
                return "no";
            }
            
            List<SANPHAM> sans = spa.GetAllItem("select * from SanPham where MaSP= '" + ma + "'");
            List<SANPHAM> tensp = spa.GetAllItem("select * from SanPham where TenSP= '" + ten + "'");

            if ((state == 1 & (sans.Count>0||tensp.Count>0))|| state ==2 & tensp.Count>0)
            {
                return "yes";
            }

            else
                

                return "ok";
        }
        public bool checksl()
        {

            try
            {
                int.Parse(sl);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool checkgia()
        {

            try
            {
                int.Parse(gia);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public bool Insertdata(SANPHAM sp)
        {
            sp.DonGia = int.Parse(gia); ;
            sp.TenSP = ten;
            sp.MaSP = "SP" + (spa.GetAllItem("select * from SANPHAM").Count + 1).ToString();
            sp.DonViTinh = dv;
            sp.Soluong = int.Parse(sl);
            return spa.Insertdata(sp);
        }
       
        public bool UpdateData(SANPHAM sp)
        {
            
            sp.DonGia = int.Parse(gia); ;
            sp.TenSP = ten;
            sp.MaSP = ma; 
            sp.DonViTinh = dv;
            sp.Soluong = int.Parse(sl);
            return spa.UpdateData(sp);
        }
        public  List<SANPHAM> GetAllItem(string sql)
        {
            return spa.GetAllItem(sql);}

   
             }   

    }
