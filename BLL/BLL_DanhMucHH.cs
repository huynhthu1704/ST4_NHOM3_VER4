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

        public DataTable HienThiDS()
        {
            return _dal.HienThi("sp_LayDanhMucHH");
        }

        public DataTable HienThiDSGiamDan()
        {
            return _dal.HienThi("sp_LayDanhMucHHGiamDan");
        }

        public bool ThemDM(ET_DanhMucHH et)
        {
            return _dal.ThemDM(et);
        }
        public bool XoaDM(ET_DanhMucHH et)
        {
            return _dal.XoaDM(et);
        }

        public bool SuaDM(ET_DanhMucHH et)
        {
            return _dal.Sua(et);
        }
        public bool CheckTonTai(ET_DanhMucHH et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
