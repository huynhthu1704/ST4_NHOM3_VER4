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
    public class BLL_BoPhan
    {
        DAL_BoPhan daBoPhan = new DAL_BoPhan();
        public DataTable LayDS()
        {
            return daBoPhan.LayDSBoPhan("sp_DSBoPhan");
        }

        public DataTable LayDSGiamDan()
        {
            return daBoPhan.LayDSBoPhan("sp_DSBoPhanGiamDan");
        }
        public bool ThemBoPhan(ET_BoPhan et)
        {
            return daBoPhan.ThemBoPhan(et);
        }
        public bool SuaBoPhan(ET_BoPhan et)
        {
            return daBoPhan.SuaBoPhan(et);
        }
        public bool XoaBoPhan(string Ma)
        {
            return daBoPhan.XoaBoPhan(Ma);
        }
        public bool CheckTonTai(ET_BoPhan et)
        {
            return daBoPhan.CheckTonTai(et);
        }
    }
}
