/// Đức Tri
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_BoPhan
    {
        private string maBP;
        private string tenBP;
        private string soDT;
        private string maQL;

        public ET_BoPhan(string maBP, string tenBP, string soDT, string maQL)
        {
            this.maBP = maBP;
            this.tenBP = tenBP;
            this.soDT = soDT;
            this.maQL = maQL;
        }

        public string MaBP { get => maBP; set => maBP = value; }
        public string TenBP { get => tenBP; set => tenBP = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string MaQL { get => maQL; set => maQL = value; }
    }
}
