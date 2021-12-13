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
    public class BLL_DanhMucHH
    {
        private DAL_DanhMucHH _dal;
        public BLL_DanhMucHH()
        {
            _dal = new DAL_DanhMucHH();
        }
        //method hiển thị ds
        public DataTable HienThiDS()
        {
            return _dal.HienThi("sp_LayDanhMucHH");
        }
        //method hiển thị ds theo thứ tự giảm dần
        public DataTable HienThiDSGiamDan()
        {
            return _dal.HienThi("sp_LayDanhMucHHGiamDan");
        }
        //method thêm
        public bool ThemDM(ET_DanhMucHH et)
        {
            return _dal.ThemDM(et);
        }
        //method xóa
        public bool XoaDM(ET_DanhMucHH et)
        {
            return _dal.XoaDM(et);
        }
        //method sửa
        public bool SuaDM(ET_DanhMucHH et)
        {
            return _dal.Sua(et);
        }
        //method check mã
        public bool CheckTonTai(ET_DanhMucHH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
