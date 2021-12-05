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

        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayHoaDon");
        }

        public DataTable LayHDGiamDan()
        {
            return _dal.HienThiDS("sp_LayHoaDonGiamDan");
        }

        public bool ThemHoaDon(ET_HoaDon et)
        {
            return _dal.ThemHD(et);
        }

        public DataTable LayHDTheoMaHD(string maHD)
        {
            return _dal.LayHDTheoMaHD(maHD);
        }
    }
}
