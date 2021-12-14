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

        // Hiển thị danh sách tài khoản đăng nhập
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayTaiKhoan");
        } 
        
        // Lấy danh sách loại tài khoản
        public DataTable HienThiLTK()
        {
            return _dal.HienThiDS("sp_LayLoaiTaiKhoan");
        }

        // Thêm tài khoản
        public bool ThemTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.ThemTK(et);
        } 
        
        // Xóa tài khoản
        public bool XoaTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.XoaTK(et);
        }
        
        // Sửa tài khoản
        public bool SuaTaiKhoan(ET_TaiKhoan et)
        {
            return _dal.SuaTK(et);
        }

        // Check tồn tại
        public bool CheckTonTai(string maTK)
        {
            if (_dal.TimTaiKhoan(maTK).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        // Kiểm tra đăng nhập
        public DataTable KiemTraDN(string tenDN, string matKhau)
        {
            return _dal.KiemTraDN(tenDN, matKhau);
        }

        // Tìm tài khoản
        public DataTable TimTaiKhoan(string maTK)
        {
            return _dal.TimTaiKhoan(maTK);
        }
    }
}
