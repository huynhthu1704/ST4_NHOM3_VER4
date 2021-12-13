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
    public class BLL_PhieuBH
    {
        private DAL_PhieuBH _dal;
        public BLL_PhieuBH()
        {
            _dal = new DAL_PhieuBH();
        }
        //method hiên thị dsd phiếu bh
        public DataTable HienThiDSPhieuBH()
        {
            return _dal.HienThi("sp_LayPhieuBaoHanh");
        }
        //method hiển thị ds pbh theo thứ tự giảm dần
        public DataTable HienThiDSPhieuBHGiamDan()
        {
            return _dal.HienThi("sp_LayPhieuBaoHanhGiamDan");
        }
        //method hiện thị dsd hàng hóa
        public DataTable HienThiDSHH()
        {
            return _dal.HienThi("sp_LayHHCoBaoHanh");
        }
        //method hiển thij ds khách hàng
        public DataTable HienThiDSKH()
        {
            return _dal.HienThi("sp_LayKhachHang");
        }
        //method thêm phiếu bh
        public bool ThemPhieuBH(ET_PhieuBH et)
        {
            return _dal.ThemPhieuBH(et);
        }
        //method xóa phiếu bảo hành
        public bool XoaPhieuBH(ET_PhieuBH et)
        {
            return _dal.XoaPhieuBH(et);
        }
        //method sửa phiếu bảo hành
        public bool SuaPhieuBH(ET_PhieuBH et)
        {
            return _dal.Sua(et);
        }
        //method checck mã pbh
        public bool CheckTonTai(ET_PhieuBH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
