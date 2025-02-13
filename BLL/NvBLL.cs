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
    public class NvBLL
    {
        NHANVIENACESS nva = new NHANVIENACESS();

        public NHANVIEN nv = new NHANVIEN();
        public string manv;
        public string honv;
        public string tennv;
        public bool gioitinh;
        public string ngaysinh;
        public string ngayvl;
        public string diachi;
        public string dienthoai;
        public string trangthai;
        public  int state;

        
        public bool XoaSanPhan(NHANVIEN nv)
        {
            nv.MaNV = manv; ;
            return nva.Deletedata(nv);
        }
        public string checkdata()
        {
            if (manv == "" || tennv.ToString() == ""||honv.ToString()=="")
            {
                return "null";
            }
            if (ngaysinh.ToString() == ""||diachi==""||dienthoai=="")
            {
                return "hoi";

            }
            //try
            //{

            //    int.Parse(dienthoai);

            //}
            //catch (Exception)
            //{
            //    return "no";
            //}

            //List<NHANVIEN> sans = nva.GetAllItem("select * from SanPham where MaSP= '" + ma + "'");

            //if (true )
            //{
            //    return "yes";
            //}

            if (state == 1 & nva.GetAllItem("select * from SanPham where MaNV= '" + manv + "'").Count > 0)
            {

                return "yes";
            }



            else


                return "ok";
        }
        public bool ThemSanPham(NHANVIEN nv)
        {
            nv.MaNV = "00"+(nva.GetAllItem("select * from NHANVIEN ").Count+1).ToString();
            nv.HoNV= honv;
            nv.TenNV = tennv;
            nv.GioiTinh = gioitinh;
            nv.Ngaysinh = ngaysinh;
            nv.DiaChi = diachi;
            nv.DienThoai = dienthoai;
            nv.NgayVaoLam = ngayvl;
            nv.TrangThai = trangthai;
            return nva.Insertdata(nv);
        }

        public bool UpdateData(NHANVIEN nv)
        {
            nv.MaNV = manv;
            nv.HoNV = honv;
            nv.TenNV = tennv;
            nv.GioiTinh = gioitinh;
            nv.Ngaysinh = ngaysinh;
            nv.DiaChi = diachi;
            nv.DienThoai = dienthoai;
            nv.NgayVaoLam = ngayvl;
            nv.TrangThai = trangthai;
            return nva.UpdateData(nv);
        }
        public List<NHANVIEN> GetAllItem(string sql)
        {

            
            return nva.GetAllItem(sql);
        }

        public bool checkdt()
        {

            try
            {
                double.Parse(dienthoai);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}
