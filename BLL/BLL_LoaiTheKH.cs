// Ngọc Thư
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
    public class BLL_LoaiTheKH
    {
        DAL_LoaiTheKH _dal; // DAL của LoaiTheKH

        public BLL_LoaiTheKH()
        {
            _dal = new DAL_LoaiTheKH(); // khởi tạo DAL
        }

        // Lấy ds
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayLoaiTheKH");
        }
      // Thêm LoaiThe, nếu thành công trả về true
        public bool ThemLoaiTheKH(ET_LoaiTheKH et)
        {
            return _dal.ThemLoaiTheKH(et);
        }
        
        // Xóa LoaiTheKH, nếu thành công trả về true
        public bool XoaLoaiTheKH(ET_LoaiTheKH et)
        {
            return _dal.XoaLoaiTheKH(et);
        }

        // Sửa LoaiTheKH
        public bool SuaLoaiTheKH(ET_LoaiTheKH et)
        {
            return _dal.SuaLoaiTheKH(et);
        }


        // Check LoaiThe có tồn tại hay không, nếu tồn tại trả về true
        public bool CheckTonTai(ET_LoaiTheKH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
