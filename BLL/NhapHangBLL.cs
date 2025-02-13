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
    public class NhapHangBLL
    {
        SANPHAMACESS spa=new SANPHAMACESS();
        NCCACESS ncca=new NCCACESS();
        CHITIETHDACESS cthda =new CHITIETHDACESS();
        HANGNHAPACESS hna=new HANGNHAPACESS();
     public   NHACUNGCAP ncc=new NHACUNGCAP();
     public   SANPHAM sp=new SANPHAM();
     public   HANGNHAP hn=new HANGNHAP();
   
        public string MaNCC;
        public string TenNCC;
        public string DiaChi;
        public string LienHe;

        public string MaNV;
        public string MaSP;
        public string TenSP;
        public string DonGiaNhap;
        public string DonViTinh;
        public string SoLuongNhap;
        public string NgayNhapHang;
        public int TongSL;

        public int MaHD;
        public int SoLuongBan;
        public int Giaban;
        public bool Insertdata(SANPHAM sp,HANGNHAP hn,NHACUNGCAP ncc)
        {
            List<SANPHAM> slsp = spa.GetAllItem("SELECT * FROM dbo.SANPHAM WHERE TenSP=N'" + TenSP + "'");
            MaSP = slsp[0].MaSP;
            List<CHITIETHD> tsp = cthda.GetSL("SELECT MaSP,SUM(SoLuong) FROM dbo.CHITIETHD WHERE MaSP='" + MaSP + "'GROUP BY MaSP ");
            SoLuongBan = tsp[0].TongSL;
            List<NHACUNGCAP> cc = ncca.GetAllItem("select * from NHACUNGCAP WHERE MaNCC='" + MaNCC + "'");
            MaNCC = cc[0].MaNCC;

            if (slsp.Count == 0)
            {
                sp.MaSP = "SP" + (spa.GetAllItem("select * from SANPHAM").Count + 1).ToString();
                sp.TenSP = TenSP;
                sp.DonGia = int.Parse(DonGiaNhap)+ int.Parse(DonGiaNhap)/10;
                sp.DonViTinh= DonViTinh;
                sp.Soluong = int.Parse(SoLuongNhap);              
                spa.Insertdata(sp);
                MaSP = sp.MaSP;
            }
            if (cc.Count==0)
            {
                ncc.MaNCC = "NCC" + (ncca.GetAllItem("select * from NHACUNGCAP").Count +1).ToString();
                ncc.TenNCC = TenNCC;
                ncc.DiaChi = DiaChi;
                ncc.LienHe = LienHe;
                ncca.Insertdata(ncc);
                MaNCC = ncc.MaNCC;
            }

            hn.MaSP = MaSP;
            hn.TenSP = TenSP;
            hn.MaNCC= MaNCC;
            hn.DonGiaNhap = int.Parse(DonGiaNhap);
            hn.DonViTinh = DonViTinh;
            hn.NgayNhapHang = NgayNhapHang;
            hn.SoLuongNhap= int.Parse(SoLuongNhap);
            hn.MaNV = MaNV;
            hna.Insertdata(hn);
        
            List<HANGNHAP> hangnhap = hna.GetSlN("SELECT MaSP,TenSP,SUM(SoLuongNhap) FROM dbo.HANGNHAP WHERE TenSP='" + TenSP + "' GROUP BY TenSP,MaSP ");
            List<HANGNHAP> dongia = hna.GetSlN("SELECT MaSP,TenSP,DonGiaNhap FROM dbo.HANGNHAP WHERE MaSP='"+MaSP+"' ORDER BY DonGiaNhap DESC");
            TongSL = hangnhap[0].TongSLN;
            sp.TenSP = TenSP;
            sp.Soluong = TongSL - SoLuongBan;
            sp.DonGia = dongia[0].DonGiaNhap*110/100;
            return spa.Update(sp);
         
        }


        public bool checksl()
        {
            try
            {
                int.Parse(SoLuongNhap);
            }
            catch (Exception)
            {

                return false;
            }
         
            return true;

        }

        public bool CheckGia()
        {
            try
            {
                int.Parse(DonGiaNhap);
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }


        public bool checkgiaban()
        {
            List<SANPHAM> slsp = spa.GetAllItem("SELECT * FROM dbo.SANPHAM WHERE TenSP=N'" + TenSP + "'");
            Giaban = slsp[0].DonGia;

            if (int.Parse(DonGiaNhap) > Giaban)
            {
                return false;
            }
            return true;

        }
        public List<NHACUNGCAP> listcc(string sql)
        {
            
            return ncca.GetAllItem(sql);
        }
        public bool AddNCC(NHACUNGCAP ncc)
        {
            ncc.MaNCC = "NCC" + (ncca.GetAllItem("select * from NHACUNGCAP").Count + 1).ToString();
            ncc.TenNCC = TenNCC;
            ncc.DiaChi = DiaChi;
            ncc.LienHe = LienHe;
            return ncca.Insertdata(ncc);

        }
        public bool update(NHACUNGCAP ncc)
        {
            ncc.MaNCC = MaNCC;
            ncc.TenNCC = TenNCC;
            ncc.DiaChi = DiaChi;
            ncc.LienHe = LienHe;
            return ncca.UpdateData(ncc);

        }

        public List<HANGNHAP> GetAllItem(string sql)
        {
            return hna.GetAllItem(sql);
        }

        }
}
