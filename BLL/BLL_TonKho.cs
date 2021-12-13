// Ngọc Thư
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
    public class BLL_TonKho
    {
        DAL_TonKho _dal = new DAL_TonKho();
      
        // Lấy danh sách tồn kho
        public DataTable HienThi()
        {
            return _dal.HienThi("sp_LayTonKho");
        }

        // Thêm tồn kho,nếu thành công trả về true
        public bool ThemTonKho(ET_TonKho et)
        {
            return _dal.ThemTonKho(et);
        }

        // Sửa tồn kho
        public bool SuaTonKho(ET_TonKho et)
        {
            return _dal.SuaTonKho(et);
        }
       
        // Check tồn tại theo kho
        public bool CheckTonTaiTheoKho(string maHH, string maKho)
        {
            return _dal.CheckTonTaiTheoKho(maHH, maKho);
        }
        
        // Lấy số lượng tồn kho
        public int LaySL(string maHH, string maKho)
        {
            return _dal.LaySL(maHH, maKho);
        }

        // Đếm tồn kho
        public int DemTonKho(string maHH)
        {
            return _dal.DemTonKho(maHH);
        }

        // Check tồn kho
        public bool CheckTT(string ma)
        {
            return _dal.CheckTonTai(ma);
        }
    }
}
