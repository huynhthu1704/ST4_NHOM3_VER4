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

        // Lấy danh sách bộ phận
        public DataTable LayDS()
        {
            return daBoPhan.LayDSBoPhan("sp_DSBoPhan");
        }

        // Lấy danh sách bộ phận giảm
        public DataTable LayDSGiamDan()
        {
            return daBoPhan.LayDSBoPhan("sp_DSBoPhanGiamDan");
        }

        // Thêm bộ phận
        public bool ThemBoPhan(ET_BoPhan et)
        {
            return daBoPhan.ThemBoPhan(et);
        }

        // Sửa bộ phận
        public bool SuaBoPhan(ET_BoPhan et)
        {
            return daBoPhan.SuaBoPhan(et);
        }

        // Xóa bộ phận
        public bool XoaBoPhan(string Ma)
        {
            return daBoPhan.XoaBoPhan(Ma);
        }

        // Check tồn tại
        public bool CheckTonTai(ET_BoPhan et)
        {
            return daBoPhan.CheckTonTai(et);
        }
    }
}
