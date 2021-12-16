// Đức Trí
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ET;
using DAL;
namespace BLL
{
     public class BLL_NhanVien
    {
        DAL_NhanVien da = new DAL_NhanVien();

        // Lấy danh sách nhân viên
        public DataTable LayDS()
        {
            return da.LayDS("sp_LayNhanVien");
        }

        // Lấy danh sách nhân viên theo mã giảm dần
        public DataTable LayDSGiamDan()
        {
            return da.LayDS("sp_LayNhanVienGiamDan");
        }

        // Tìm nhân viên theo tài khoản đăng nhập
        public DataTable TimNVTheoTKDN(string maTk)
        {
            return da.TimNVTheoTKDN(maTk);
        }

        // Thêm nhân viên
        public bool ThemNhanVien(ET_NhanVien et)
        {
            return da.ThemNhanVien(et);
        }
        

        // Sửa nhân viên
        public bool SuaNhanVien(ET_NhanVien et)
        {
            return da.SuaNhanVien(et);
        }
        // Xóa nhân viên
        public bool XoaNhanVien(string Ma)
        {
            return da.XoaNhanVien(Ma);
        }

        // Check tồn tại
        public bool CheckTonTai(ET_NhanVien et)
        {
            return da.CheckTonTai(et);
        }

        // Check tồn tại theo mã tài khoản đăng nhập
        public bool CheckTonTaiMaTK(string et)
        {
            return da.CheckTonTaiMaTK(et);
        }

    }
}
