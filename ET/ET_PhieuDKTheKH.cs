//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_PhieuDKTheKH
    {
        //field
        private string _maPhieu;
        private string _maNV;
        private string _maTheKH;
        private string _maKH;
        private DateTime _ngayDK;
        //constructor
        public ET_PhieuDKTheKH(string maPhieu, string maNV, string maTheKH, string maKH, DateTime ngayDK)
        {
            _maPhieu = maPhieu;
            _maNV = maNV;
            _maTheKH = maTheKH;
            _maKH = maKH;
            _ngayDK = ngayDK;
        }
        //properties
        public string MaPhieu { get => _maPhieu; set => _maPhieu = value; }
        public string MaNV { get => _maNV; set => _maNV = value; }
        public string MaTheKH { get => _maTheKH; set => _maTheKH = value; }
        public string MaKH { get => _maKH; set => _maKH = value; }
        public DateTime NgayDK { get => _ngayDK; set => _ngayDK = value; }
    }
}
