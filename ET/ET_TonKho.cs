// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TonKho
    {
        private string maKho;
        private string maHH;
        private int soLuong;

        public ET_TonKho(string maHH, string maKho, int soLuong)
        {
            this.maKho = maKho;
            this.maHH = maHH;
            this.soLuong = soLuong;
        }

        public string MaKho { get => maKho; set => maKho = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
    }
}
