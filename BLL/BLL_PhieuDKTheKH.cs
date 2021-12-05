//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
using ET;

namespace BLL
{
    public class BLL_PhieuDKTheKH
    {
        private DAL_PhieuDKTheKH _dal;
        public BLL_PhieuDKTheKH()
        {
            _dal = new DAL_PhieuDKTheKH();
        }

        public DataTable HienThiDSPhieuDKTheKH()
        {
            return _dal.HienThi("SP_LayPhieuDKTheKH");
        }
        public DataTable HienThiDSNV()
        {
            return _dal.HienThi("sp_LayNhanVien");
        }
        public DataTable HienThiDSTheKH()
        {
            return _dal.HienThi("sp_LayTheKhachHang");
        }
        public DataTable HienThiDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }
        public bool ThemPhieuDK(ET_PhieuDKTheKH et)
        {
            return _dal.ThemPhieuDK(et);
        }
        public bool XoaPhieuDK(ET_PhieuDKTheKH et)
        {
            return _dal.XoaPhieuDK(et);
        }
        public bool SuaPhieuDK(ET_PhieuDKTheKH et)
        {
            return _dal.Sua(et);
        }
        public bool CheckTonTai(ET_PhieuDKTheKH et)
        {
            return _dal.CheckTonTai(et);
        }
        public bool CapNhatTKH(string et)
        {
            return _dal.CapNhatTKH(et);
        }
    }
}
