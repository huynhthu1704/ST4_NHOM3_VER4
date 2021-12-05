//Ngọc Thư
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
    public class BLL_LoaiTaiKhoan
    {
        private DAL_LoaiTK _dal;
        public BLL_LoaiTaiKhoan()
        {
            _dal = new DAL_LoaiTK();
        }

        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayLoaiTaiKhoan");
        }
        public bool ThemTaiKhoan(ET_LoaiTK et)
        {
            return _dal.ThemLoaiTK(et);
        }

        public bool XoaTaiKhoan(ET_LoaiTK et)
        {
            return _dal.XoaLoaiTK(et);
        }

        public bool SuaTaiKhoan(ET_LoaiTK et)
        {
            return _dal.SuaLoaiTK(et);
        }

        public bool CheckTonTai(ET_LoaiTK et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
