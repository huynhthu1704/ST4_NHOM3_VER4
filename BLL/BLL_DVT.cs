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

        public DataTable HienThiDS()
        {
            return _dal.HienThiDS("sp_LayDonViTinh");
        }
        public bool ThemDVT(ET_DVT et)
        {
            return _dal.ThemDVT(et);
        }
        public bool XoaDVT(ET_DVT et)
        {
            return _dal.XoaDVT(et);
        }

        public bool SuaDVT(ET_DVT et)
        {
            return _dal.SuaDVT(et);
        }
        public bool CheckTonTai(ET_DVT et)
        {
            return _dal.CheckTonTai(et);
        }
    }
}
