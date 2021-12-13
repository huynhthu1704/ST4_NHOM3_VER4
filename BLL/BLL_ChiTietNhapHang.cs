// Ngọc Thư
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
    public class BLL_ChiTietNhapHang
    {
        DAL_ChiTietNhapHang _dal = new DAL_ChiTietNhapHang();
       
        // Lấy chi tiết danh hóa đơn nhập hàng
        public DataTable LayDS()
        {
            return _dal.HienThi("SP_LayChiTietNhapHang");
        }

        // Thêm chi tiết hóa đơn nhập hàng
        public bool ThemCTNH(ET_ChiTietNH et)
        {
            return _dal.ThemCTNH(et);
        }

        // Sửa chi tiết hóa đơn nhập hàng
        public bool SuaCTNH(ET_ChiTietNH et)
        {
            return _dal.SuaCTNH(et);
        }

        // Xóa chi tiết hóa đơn nhập hàng
        public bool XoaCTNH(string maHD, string maHH)
        {
            return _dal.XoaCTNH(maHD, maHH);
        }

        // Check tồn tại hóa đơn nhập hàng
        public bool CheckTonTai(string maHD, string maHH)
        {
            return _dal.CheckTonTai(maHD, maHH);
        }
    }
}
