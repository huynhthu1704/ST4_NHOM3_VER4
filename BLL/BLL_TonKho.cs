// Ngọc Thư
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
    public class BLL_TonKho
    {
        DAL_TonKho _dal = new DAL_TonKho();
      
        public DataTable HienThi()
        {
            return _dal.HienThi("sp_LayTonKho");
        }
        public bool ThemTonKho(ET_TonKho et)
        {
            return _dal.ThemTonKho(et);
        }
        public bool SuaTonKho(ET_TonKho et)
        {
            return _dal.SuaTonKho(et);
        }
       
        public bool CheckTonTaiTheoKho(string maHH, string maKho)
        {
            return _dal.CheckTonTaiTheoKho(maHH, maKho);
        }
        
        public int LaySL(string maHH, string maKho)
        {
            return _dal.LaySL(maHH, maKho);
        }

        public int DemTonKho(string maHH)
        {
            return _dal.DemTonKho(maHH);
        }

        public bool CheckTT(string ma)
        {
            return _dal.CheckTonTai(ma);
        }
    }
}
