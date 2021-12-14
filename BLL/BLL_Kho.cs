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

        // Lấy danh sách kho giảm dần theo mã kho
        public DataTable LayDSGiamDan()
        {
            return da.LayDSKhoTheoMaGiamDan();
        }

        // Lấy danh sách kho
        public DataTable LayDS()
        {
            return da.LayDSKho();
        }

        // Thêm kho
        public bool ThemKho(ET_Kho et)
        {
            return da.ThemKho(et);
        }

        // Sửa kho
        public bool SuaKho(ET_Kho et)
        {
            return da.SuaKho(et);
        }

        // Xóa kho
        public bool XoaKho(string Ma)
        {
            return da.XoaKho(Ma);
        }

        // Check tồn tại kho
        public bool CheckTonTai(ET_Kho et)
        {
            return da.CheckTonTai(et);
        }
    }
}
