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
    public class BLL_HangHoa
    {
        private DAL_HangHoa _dal;
        public BLL_HangHoa()
        {
            _dal = new DAL_HangHoa();
        }

        public DataTable HienThiDSHH()
        {
            return _dal.HienThi("SP_LayHangHoa");
        }
        public DataTable HienThiDSDVT()
        {
            return _dal.HienThi("sp_LayDonViTinh");
        }
        public DataTable HienThiDSDM()
        {
            return _dal.HienThi("sp_LayDanhMucHH");
        }
        public DataTable LayTT(string maHH)
        {
            return _dal.LayTT(maHH);
        }

        public DataTable HienThiDSKM()
        {
            return _dal.HienThi("sp_DSKM");
        }
        public bool ThemHH(ET_HangHoa et)
        {
            return _dal.ThemHH(et);
        }
        public bool CheckTonTai(string maHH)
        {
            return _dal.CheckTonTai(maHH);
        }
        public bool XoaHH(ET_HangHoa et)
        {
            return _dal.XoaHH(et);
        }
        public bool SuaHH(ET_HangHoa et)
        {
            return _dal.Sua(et);
        }
    }
}
