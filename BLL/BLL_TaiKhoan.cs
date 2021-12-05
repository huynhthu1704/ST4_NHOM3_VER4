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
    public class BLL_TaiKhoan
    {
        private DAL_TaiKhoan _dal;
        public BLL_TaiKhoan()
        {
            _dal = new DAL_TaiKhoan();
        }

        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayTaiKhoan");
        } 
        

        public DataTable HienThiLTK()
        {
            return _dal.HienThiDS("sp_LayLoaiTaiKhoan");
        }
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.ThemTK(et);
        } 
        
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.XoaTK(et);
        }
        
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.SuaTK(et);
        }

        public bool CheckTonTai(string maTK)
        {
            if (_dal.TimTaiKhoan(maTK).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        public DataTable KiemTraDN(string tenDN, string matKhau)
        {
            return _dal.KiemTraDN(tenDN, matKhau);
        }
        public DataTable TimTaiKhoan(string maTK)
        {
            return _dal.TimTaiKhoan(maTK);
        }
    }
}
