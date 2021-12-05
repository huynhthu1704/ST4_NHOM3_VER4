/// Đức Trí
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_Kho
    {
        private string maKho;
        private string tenKho;

        public ET_Kho(string maKho, string tenKho)
        {
            this.maKho = maKho;
            this.tenKho = tenKho;
        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string TenKho { get => tenKho; set => tenKho = value; }
    }
}
