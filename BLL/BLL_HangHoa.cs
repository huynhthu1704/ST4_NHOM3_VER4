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
        //method hiên thị ds hh
        public DataTable HienThiDSHH()
        {
            return _dal.HienThi("SP_LayHangHoa");
        }
        //method hiển thị ds dvt
        public DataTable HienThiDSDVT()
        {
            return _dal.HienThi("sp_LayDonViTinh");
        }
        //method hiển thị ds danh mục hh
        public DataTable HienThiDSDM()
        {
            return _dal.HienThi("sp_LayDanhMucHH");
        }
        //method lấy thông tin
        public DataTable LayTT(string maHH)
        {
            return _dal.LayTT(maHH);
        }
        //method hiển thị ds khuyến mãi
        public DataTable HienThiDSKM()
        {
            return _dal.HienThi("sp_DSKM");
        }
        //method thêm
        public bool ThemHH(ET_HangHoa et)
        {
            return _dal.ThemHH(et);
        }
        //method ckech mã
        public bool CheckTonTai(string maHH)
        {
            return _dal.CheckTonTai(maHH);
        }
        //method xóa
        public bool XoaHH(ET_HangHoa et)
        {
            return _dal.XoaHH(et);
        }
        //method sửa
        public bool SuaHH(ET_HangHoa et)
        {
            return _dal.Sua(et);
        }
    }
}
