// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_ChiTietNH
    {
        private string maHD;
        private string maHH;
        private int soLuong;
        private int gia;
        private int thanhTien;
        private string maKho;

        public ET_ChiTietNH(string maHD, string maHH, int soLuong, int gia, int thanhTien, string maKho)
        {
            this.maHD = maHD;
            this.maHH = maHH;
            this.soLuong = soLuong;
            this.gia = gia;
            this.thanhTien = thanhTien;
            this.maKho = maKho;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaHH { get => maHH; set => maHH = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public int Gia { get => gia; set => gia = value; }
        public int ThanhTien { get => thanhTien; set => thanhTien = value; }
        public string MaKho { get => maKho; set => maKho = value; }
    }
}
