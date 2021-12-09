// Ngọc Thư
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
    public class BLL_HoaDon
    {
        private DAL_HoaDon _dal;
        public BLL_HoaDon()
        {
            _dal = new DAL_HoaDon();
        }

        // Hiển thị hóa đơn nhập hàng
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayHoaDon");
        }

        // Lấy hóa đơn giảm dần
        public DataTable LayHDGiamDan()
        {
            return _dal.HienThiDS("sp_LayHoaDonGiamDan");
        }

        // Thêm hóa đơn 
        public bool ThemHoaDon(ET_HoaDon et)
        {
            return _dal.ThemHD(et);
        }

        // Lấy hóa đơn theo mã hóa đơn
        public DataTable LayHDTheoMaHD(string maHD)
        {
            return _dal.LayHDTheoMaHD(maHD);
        }
    }
}
