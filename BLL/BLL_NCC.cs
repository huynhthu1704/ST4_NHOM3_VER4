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

        // Lấy danh sách nhà cung cấp
        public DataTable LayDS()
        {
            return da.LayDS("sp_DSNCC");
        }

        // Lấy danh sách nhà cung cấp giảm dần theo mã
        public DataTable LayDSGiamDan()
        {
            return da.LayDS("sp_DSNCCGiamDan");
        }

        // Thêm nhà cung cấp
        public bool ThemNCC(ET_NCC et)
        {
            return da.ThemNCC(et);
        }

        // Sửa nhà cung cấp
        public bool SuaNCC(ET_NCC et)
        {
            return da.SuaNCC(et);
        }

        // Xóa nhà cung cấp
        public bool XoaNCC(string Ma)
        {
            return da.XoaNCC(Ma);
        }

        // Check tồn tại
        public bool CheckTonTai(ET_NCC et)
        {
            return da.CheckTonTai(et);
        }
    }
}
