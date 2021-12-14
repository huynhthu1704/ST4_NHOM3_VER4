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

        // Lấy danh sách khuyến mãi
        public DataTable LayDS()
        {
            return da.LayDS();
        }

        // Lấy danh sách khuyến mãi giảm dần theo mã khuyến mãi 
        public DataTable LayDSGiamDan()
        {
            return da.LayDSGiamDan();
        }

        // Thêm khuyến mãi
        public bool ThemKhuyenMai(ET_KhuyenMai et)
        {
            return da.ThemKhuyenMai(et);
        }

        // Sửa khuyến mãi
        public bool SuaKhuyenMai(ET_KhuyenMai et)
        {
            return da.SuaKuyenMai(et);
        }

        // Xóa khuyến mãi
        public bool XoaKhuyenMai(string Ma)
        {
            return da.XoaKhuyenMai(Ma);
        }

        // Check tồn tại
        public bool CheckTonTai(ET_KhuyenMai et)
        {
            return da.CheckTonTai(et);
        }

        // Lấy khuyến mãi theo mã
        public DataTable LayKMTheoMa(string ma)
        {
            return da.LayKMTheoMa(ma);
        }
    }
}
