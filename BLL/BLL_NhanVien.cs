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
        public DataTable LayDS()
        {
            return da.LayDS("sp_LayNhanVien");
        }

        public DataTable LayDSGiamDan()
        {
            return da.LayDS("sp_LayNhanVienGiamDan");
        }
        public bool ThemNhanVien(ET_NhanVien et)
        {
            return da.ThemNhanVien(et);
        }
        public bool SuaNhanVien(ET_NhanVien et)
        {
            return da.SuaNhanVien(et);
        }
        public bool XoaNhanVien(string Ma)
        {
            return da.XoaNhanVien(Ma);
        }
        public bool CheckTonTai(ET_NhanVien et)
        {
            return da.CheckTonTai(et);
        }
        public bool CheckTonTaiMaTK(string et)
        {
            return da.CheckTonTaiMaTK(et);
        }

        public DataTable TimNVTheoTKDN(string maTK)
        {
            return da.TimNVTheoTKDN(maTK);
        }
    }
}
