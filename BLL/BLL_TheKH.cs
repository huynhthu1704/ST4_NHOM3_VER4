//Thanh Quốc
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
    public class BLL_TheKH
    {
        private DAL_TheKH _dal;
        public BLL_TheKH()
        {
            _dal = new DAL_TheKH();
        }
        //method hiên thị ds the kh
        public DataTable HienThiDSTheKH()
        {
            return _dal.HienThi("sp_LayTheKhachHang");
        }
        //method hiển thị ds theo thứ tự giảm dần
        public DataTable HienThiDSTheKHGiamDan()
        {
            return _dal.HienThi("sp_LayTheKHGiamDan");
        }
        //method lấy thẻ kh theo mã
        public DataTable LayTheKHTheoMa(string maTheKH)
        {
            return _dal.LayTheKHTheoMa(maTheKH);
        }
        //method hiển thi ds loại thẻ
        public DataTable HienThiDSLoaiThe()
        {
            return _dal.HienThi("sp_LayLoaiTheKH");
        }
        // method thêm
        public bool ThemTheKhachHang(string maThe, int tinhTrang)
        {
            return _dal.ThemTheKhachHang(maThe, tinhTrang);
        }
        // method kiểm tra mã
        public bool CheckTonTai(string maKH)
        {
            return _dal.CheckTonTai(maKH);
        }
        //method xóa
        public bool Xoa(string maThe)
        {
            return _dal.Xoa(maThe);
        }
        //method sưa
        public bool Sua(ET_TheKH et)
        {
            return _dal.SuaLoaiThe(et);
        }
        //method sửa tính trạng
        public bool SuaTinhTrangThe(string maThe, int tinhTrang)
        {
            return _dal.SuaTheKH("sp_SuaTinhTrangTheKH", maThe, "@TinhTrang", tinhTrang);
        }
        //method sửa điểm tl
        public bool SuaDiemThe(string maThe, int diem)
        {
            return _dal.SuaTheKH("sp_SuaDiemTheKH", maThe, "@DiemTL", diem);
        }
    }
}
