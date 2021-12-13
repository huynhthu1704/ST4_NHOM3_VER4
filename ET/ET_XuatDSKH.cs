using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_XuatDSKH
    {
        private string maKH;
        private string hoTenKH;
        private string gioiTinh;
        private string sDT;
        private string diaChi;
        private string maThe;
        private string diemTL;

        public ET_XuatDSKH(string maKH, string hoTenKH, string gioiTinh, string sDT, string diaChi, string maThe, string diemTL)
        {
            this.maKH = maKH;
            this.hoTenKH = hoTenKH;
            this.gioiTinh = gioiTinh;
            this.sDT = sDT;
            this.diaChi = diaChi;
            this.maThe = maThe;
            this.diemTL = diemTL;
        }

        public string MaKH { get => maKH; set => maKH = value; }
        public string HoTenKH { get => hoTenKH; set => hoTenKH = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string MaThe { get => maThe; set => maThe = value; }
        public string DiemTL { get => diemTL; set => diemTL = value; }
    }
}
