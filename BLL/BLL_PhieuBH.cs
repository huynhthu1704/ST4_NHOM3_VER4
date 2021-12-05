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
    public class BLL_PhieuBH
    {
        private DAL_PhieuBH _dal;
        public BLL_PhieuBH()
        {
            _dal = new DAL_PhieuBH();
        }

        public DataTable HienThiDSPhieuBH()
        {
            return _dal.HienThi("sp_LayPhieuBaoHanh");
        }
        public DataTable HienThiDSHH()
        {
            return _dal.HienThi("sp_LayHangHoa");
        }
        public DataTable HienThiDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }
        public bool ThemPhieuBH(ET_PhieuBH et)
        {
            return _dal.ThemPhieuBH(et);
        }
        public bool XoaPhieuBH(ET_PhieuBH et)
        {
            return _dal.XoaPhieuBH(et);
        }

        public bool SuaPhieuBH(ET_PhieuBH et)
        {
            return _dal.Sua(et);
        }
        public bool CheckTonTai(ET_PhieuBH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
