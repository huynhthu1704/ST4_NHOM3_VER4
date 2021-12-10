//Đức Trí
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
    public class BLL_NCC
    {
        DAL_NCC da = new DAL_NCC();
        public DataTable LayDS()
        {
            return da.LayDS("sp_DSNCC");
        }

        public DataTable LayDSGiamDan()
        {
            return da.LayDS("sp_DSNCCGiamDan");
        }

        public bool ThemNCC(ET_NCC et)
        {
            return da.ThemNCC(et);
        }
        public bool SuaNCC(ET_NCC et)
        {
            return da.SuaNCC(et);
        }
        public bool XoaNCC(string Ma)
        {
            return da.XoaNCC(Ma);
        }
        public bool CheckTonTai(ET_NCC et)
        {
            return da.CheckTonTai(et);
        }
    }
}
