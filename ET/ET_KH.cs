//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KH
    {
        //field
        private string _maKH;
        private string _hoTenKH;
        private string _gioiTinh;
        private string _sDT;
        private string _diaChi;
        private string _maTheKH;

        public ET_KH(string maKH, string hoTenKH, string gioiTinh, string sDT, string diaChi, string maTheKH)
        {
            _maKH = maKH;
            _hoTenKH = hoTenKH;
            _gioiTinh = gioiTinh;
            _sDT = sDT;
            _diaChi = diaChi;
            _maTheKH = maTheKH;
        }

        public string MaKH { get => _maKH; set => _maKH = value; }
        public string HoTenKH { get => _hoTenKH; set => _hoTenKH = value; }
        public string GioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public string SDT { get => _sDT; set => _sDT = value; }
        public string DiaChi { get => _diaChi; set => _diaChi = value; }
        public string MaTheKH { get => _maTheKH; set => _maTheKH = value; }
    }
}
