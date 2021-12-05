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
    public class BLL_HDNH
    {
        private DAL_HDNH _dal;
        public BLL_HDNH()
        {
            _dal = new DAL_HDNH();
        }

        public DataTable HienThiDS()
        {
            return _dal.LayDS("sp_LayHDNH");
        }

        public bool ThemHDNH(ET_HDNH et)
        {
            return _dal.ThemHDNH(et);
        }

        public bool XoaHDNH(ET_HDNH et)
        {
            return _dal.XoaHDNH(et);
        }

        public bool SuaHDNH(ET_HDNH et)
        {
            return _dal.SuaHDNH(et);
        }

        public bool CheckTonTai(string maHD)
        {
            return _dal.CheckTonTai(maHD);
        }

    }
}
