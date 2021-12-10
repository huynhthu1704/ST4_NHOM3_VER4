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

        public DataTable HienThiDSTheKH()
        {
            return _dal.HienThi("sp_LayTheKhachHang");
        }

        public DataTable HienThiDSTheKHGiamDan()
        {
            return _dal.HienThi("sp_LayTheKHGiamDan");
        }

        public DataTable LayTheKHTheoMa(string maTheKH)
        {
            return _dal.LayTheKHTheoMa(maTheKH);
        }
        public DataTable HienThiDSLoaiThe()
        {
            return _dal.HienThi("sp_LayLoaiTheKH");
        }

        public bool ThemTheKhachHang(string maThe, int tinhTrang)
        {
            return _dal.ThemTheKhachHang(maThe, tinhTrang);
        }
        public bool CheckTonTai(string maKH)
        {
            return _dal.CheckTonTai(maKH);
        }
        public bool Xoa(string maThe)
        {
            return _dal.Xoa(maThe);
        }
        public bool Sua(ET_TheKH et)
        {
            return _dal.SuaLoaiThe(et);
        }

        public bool SuaTinhTrangThe(string maThe, int tinhTrang)
        {
            return _dal.SuaTheKH("sp_SuaTinhTrangTheKH", maThe, "@TinhTrang", tinhTrang);
        }
        public bool SuaDiemThe(string maThe, int diem)
        {
            return _dal.SuaTheKH("sp_SuaDiemTheKH", maThe, "@DiemTL", diem);
        }
    }
}
