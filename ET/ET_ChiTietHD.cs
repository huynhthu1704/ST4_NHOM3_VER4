//Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietHD
    {
        private string maHD;
        private string maHH;
        private int sL;
        private int gia;
        private int khuyenMai;
        private int thanhTien;

        public ET_ChiTietHD(string maHD, string maHH, int sL, int gia, int khuyenMai, int thanhTien)
        {
            this.maHD = maHD;
            this.maHH = maHH;
            this.sL = sL;
            this.gia = gia;
            this.khuyenMai = khuyenMai;
            this.thanhTien = thanhTien;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public int SL { get => sL; set => sL = value; }
        public int Gia { get => gia; set => gia = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
