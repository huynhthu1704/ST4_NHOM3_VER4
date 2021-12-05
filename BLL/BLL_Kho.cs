/// Đức Trí
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
    public class BLL_Kho
    {
        DAL_Kho da = new DAL_Kho();
        public DataTable LayDS()
        {
            return da.LayDSKho();
        }
        public bool ThemKho(ET_Kho et)
        {
            return da.ThemKho(et);
        }
        public bool SuaKho(ET_Kho et)
        {
            return da.SuaKho(et);
        }
        public bool XoaKho(string Ma)
        {
            return da.XoaKho(Ma);
        }
        public bool CheckTonTai(ET_Kho et)
        {
            return da.CheckTonTai(et);
        }
    }
}
