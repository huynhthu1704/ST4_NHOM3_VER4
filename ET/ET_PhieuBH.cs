//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhieuBH
    {
        private string _maBH;
        private string _maHH;
        private string _maKH;
        private DateTime _ngayMua;
        private DateTime _thoiHanBH;

        public ET_PhieuBH(string maBH, string maHH, string maKH, DateTime ngayMua, DateTime thoiHanBH)
        {
            _maBH = maBH;
            _maHH = maHH;
            _maKH = maKH;
            _ngayMua = ngayMua;
            _thoiHanBH = thoiHanBH;
        }

        public string MaBH { get => _maBH; set => _maBH = value; }
        public string MaHH { get => _maHH; set => _maHH = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public DateTime NgayMua { get => _ngayMua; set => _ngayMua = value; }
        public DateTime ThoiHanBH { get => _thoiHanBH; set => _thoiHanBH = value; }
    }
}
