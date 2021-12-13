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
    public class BLL_DVT
    {
        private DAL_DVT _dal;
        public BLL_DVT()
        {
            _dal = new DAL_DVT();
        }
        //method hiển thị ds
        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayDonViTinh");
        }
        //hiển thị ds theo thứ tự giảm dần
        public DataTable HienThiDSGiamDan()
        {
            return _dal.HienThiDS("sp_LayDonViTinhGiamDan");
        }
        //method thêm
        public bool ThemDVT(ET_DVT et)
        {
            return _dal.ThemDVT(et);
        }
        //method xóa
        public bool XoaDVT(ET_DVT et)
        {
            return _dal.XoaDVT(et);
        }
        //method sửa
        public bool SuaDVT(ET_DVT et)
        {
            return _dal.SuaDVT(et);
        }
        //method kiểm tra mã
        public bool CheckTonTai(ET_DVT et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
