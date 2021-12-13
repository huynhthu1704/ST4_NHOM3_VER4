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
        //method hiện thị ds giam dần
        public DataTable HienThiDSPhieuDKTheKHGiam()
        {
            return _dal.HienThi("SP_LayPhieuDKTheKHTheoMaGiam");
        }
        //method hiện thị ds phiếu dk thẻ kh
        public DataTable HienThiDSPhieuDKTheKH()
        {
            return _dal.HienThi("SP_LayPhieuDKTheKH");
        }
        //method hiển thị danh sách nhân viên
        public DataTable HienThiDSNV()
        {
            return _dal.HienThi("sp_LayNhanVien");
        }
        //method hiển thị danh sách thẻ khách hàng
        public DataTable HienThiDSTheKH()
        {
            return _dal.HienThi("sp_LaySDChuaKH");
        }
        // method hiện thị dánh sách khach hang
        public DataTable HienThiDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }
        //method thêm phiêu dk thẻ kh
        public bool ThemPhieuDK(ET_PhieuDKTheKH et)
        {
            return _dal.ThemPhieuDK(et);
        }
        //method check mã phiêu dk 
        public bool CheckTonTai(ET_PhieuDKTheKH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
