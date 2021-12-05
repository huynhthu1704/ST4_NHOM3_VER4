//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HangHoa
    {
        private string _maHH;
        private string _tenHH;
        private string _donVT;
        private int _gia;
        private string _maDM;
        private int _baoHanh;
        private string _maKM;

        public ET_HangHoa(string maHH, string tenHH, string donVT, int gia, string maDM, int baoHanh, string maKM)
        {
            _maHH = maHH;
            _tenHH = tenHH;
            _donVT = donVT;
            _gia = gia;
            _maDM = maDM;
            _baoHanh = baoHanh;
            _maKM = maKM;
        }

        public string MaHH { get => _maHH; set => _maHH = value; }
        public string TenHH { get => _tenHH; set => _tenHH = value; }
        public string DonVT { get => _donVT; set => _donVT = value; }
        public int Gia { get => _gia; set => _gia = value; }
        public string MaDM { get => _maDM; set => _maDM = value; }
        public int BaoHanh { get => _baoHanh; set => _baoHanh = value; }
        public string MaKM { get => _maKM; set => _maKM = value; }
    }
}
