//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_DVT
    {
        //field 
        private string _maDVT;
        private string _tenDVT;
        //constructor
        public ET_DVT(string maDVT, string tenDVT)
        {
            _maDVT = maDVT;
            _tenDVT = tenDVT;
        }
        //properties
        public string MaDVT { get => _maDVT; set => _maDVT = value; }
        public string TenDVT { get => _tenDVT; set => _tenDVT = value; }
    }
}
