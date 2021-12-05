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
        DAL_LoaiTheKH _dal;

        public BLL_LoaiTheKH()
        {
            _dal = new DAL_LoaiTheKH();
        }
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayLoaiTheKH");
        }
      
        public bool ThemLoaiTK(ET_LoaiTheKH et)
        {
            return _dal.ThemLoaiTK(et);
        }
        public bool XoaLoaiTK(ET_LoaiTheKH et)
        {
            return _dal.XoaLoaiTK(et);
        }
        public bool SuaLoaiTK(ET_LoaiTheKH et)
        {
            return _dal.SuaLoaiTK(et);
        }

        public bool CheckTonTai(ET_LoaiTheKH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
