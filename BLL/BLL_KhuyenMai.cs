// Đức Trí
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
    public class BLL_KhuyenMai
    {
        DAL_KhuyenMai da = new DAL_KhuyenMai();
        public DataTable LayDS()
        {
            return da.LayDS();
        }

        public DataTable LayDSGiamDan()
        {
            return da.LayDSGiamDan();
        }

        public bool ThemKhuyenMai(ET_KhuyenMai et)
        {
            return da.ThemKhuyenMai(et);
        }
        public bool SuaKhuyenMai(ET_KhuyenMai et)
        {
            return da.SuaKuyenMai(et);
        }
        public bool XoaKhuyenMai(string Ma)
        {
            return da.XoaKhuyenMai(Ma);
        }
        public bool CheckTonTai(ET_KhuyenMai et)
        {
            return da.CheckTonTai(et);
        }

        public DataTable LayKMTheoMa(string ma)
        {
            return da.LayKMTheoMa(ma);
        }
    }
}
