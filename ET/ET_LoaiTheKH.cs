using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiTheKH
    {
        private string _maLoaiThe;
        private string _tenLoaiThe;

        public ET_LoaiTheKH(string maLoaiThe, string tenLoaiThe)
        {
            _maLoaiThe = maLoaiThe;
            _tenLoaiThe = tenLoaiThe;
        }

        public string MaLoaiThe { get => _maLoaiThe; set => _maLoaiThe = value; }
        public string TenLoaiThe { get => _tenLoaiThe; set => _tenLoaiThe = value; }
    }
}
