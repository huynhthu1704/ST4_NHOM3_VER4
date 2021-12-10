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
    public class BLL_KH
    {
        private DAL_KH _dal;
        public BLL_KH()
        {
            _dal = new DAL_KH();
        }
        //method lấy dánh sách khách hàng
        public DataTable LayDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }
        //method lấy danh sách khách hàng theo giảm dần
        public DataTable LayDSGiamDan()
        {
            return _dal.HienThi("sp_LayKhachHangGiamDan");
        }
        //method thêm khách hàng
        public bool ThemKH(ET_KH et)
        {
            return _dal.ThemKH(et);
        }
        //method check mã kh
        public bool CheckTonTai(ET_KH et)
        {
            return _dal.CheckTonTai(et);
        }
        //method xóa khách hàng
        public bool XoaKH(ET_KH et)
        {
            return _dal.XoaKH(et);
        }
        //method sửa khách hàng
        public bool SuaKH(ET_KH et)
        {
            return _dal.Sua(et);
        }
        //method sửa thẻ khách hàng
        public bool SuaTheKH(string maKH, string maThe)
        {
            return _dal.SuaTheKH(maKH, maThe);
        }
    }
}
