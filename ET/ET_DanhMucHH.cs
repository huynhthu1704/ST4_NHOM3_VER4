//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public  class ET_DanhMucHH
    {
        private string _maDM;
        private string _tenDM;

        public ET_DanhMucHH(string maDM, string tenDM)
        {
            _maDM = maDM;
            _tenDM = tenDM;
        }

        public string MaDM { get => _maDM; set => _maDM = value; }
        public string TenDM { get => _tenDM; set => _tenDM = value; }
    }
}
