// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET;
using DAL;

namespace BLL
{
     public class BLL_ChiTietHoaDon
    {
        private DAL_ChiTietHD _dal;
        public BLL_ChiTietHoaDon()
        {
            _dal = new DAL_ChiTietHD();
        }

        // Thêm chi tiết hóa đơn
        public bool ThemCTHD(ET_ChiTietHD et)
        {
            return _dal.ThemCTHD(et);
        }

        // Lấy chi tiết hóa đơn
        public DataTable LayCTHDTheoMaHD(string ma)
        {
            return _dal.LayCTHDTheoMaHD(ma);
        }
    }
}
