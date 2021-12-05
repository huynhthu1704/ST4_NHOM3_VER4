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
        private DAL_LoaiTK _dal;// DAL của LoaiTK
        public BLL_LoaiTaiKhoan()
        {
            _dal = new DAL_LoaiTK(); // Khởi tạo DAL
        }

        // Lấy ds LoaiTK
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayLoaiTaiKhoan");
        }

        // Thêm LoaiTK
        public bool ThemTaiKhoan(ET_LoaiTK et)
        {
            return _dal.ThemLoaiTK(et);
        }

        // Xóa LoaiTK
        public bool XoaTaiKhoan(ET_LoaiTK et)
        {
            return _dal.XoaLoaiTK(et);
        }

        // Sửa LoaiTk
        public bool SuaTaiKhoan(ET_LoaiTK et)
        {
            return _dal.SuaLoaiTK(et);
        }

        /// <summary>
        /// Kiểm tra Loại tài khoản có maLoai có tồn tại hay chưa
        /// </summary>
        /// <param name="maLoai">mã loại tài khoản</param>
        /// <returns>true nếu có tồn tại, ngược lại false</returns>
        public bool CheckTonTai(string maLoai)
        {
            if (_dal.TimLoaiTK(maLoai).Rows.Count > 0)
            {
                return true;
            }
            return false;
        }

        // Tìm loại tài khoản
        public DataTable TimLoaiTK(string maLoai)
        {
            return _dal.TimLoaiTK(maLoai);
        }
    }
}
