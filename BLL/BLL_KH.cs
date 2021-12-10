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

        public DataTable LayDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }

        public DataTable LayDSGiamDan()
        {
            return _dal.HienThi("sp_LayKhachHangGiamDan");
        }

        public DataSet LayDSKHChoRP()
        {
            return _dal.LayDSChoRP();
        }
        public bool ThemKH(ET_KH et)
        {
            return _dal.ThemKH(et);
        }
        public bool CheckTonTai(ET_KH et)
        {
            return _dal.CheckTonTai(et);
        }
        public bool XoaKH(ET_KH et)
        {
            return _dal.XoaKH(et);
        }
        public bool SuaKH(ET_KH et)
        {
            return _dal.Sua(et);
        }

        public bool SuaTheKH(string maKH, string maThe)
        {
            return _dal.SuaTheKH(maKH, maThe);
        }
    }
}
