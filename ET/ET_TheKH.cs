//Thanh Quốc
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TheKH
    {
        //field
        private string _maTheKH;
        private string _loaiThe;
        private int _tinhTrang;
        private int _diemTichLuy;
        //constructor
        public ET_TheKH(string maTheKH, string loaiThe, int tinhTrang, int diemTichLuy)
        {
            _maTheKH = maTheKH;
            _loaiThe = loaiThe;
            _tinhTrang = tinhTrang;
            _diemTichLuy = diemTichLuy;
        }
        //properties
        public string MaTheKH { get => _maTheKH; set => _maTheKH = value; }
        public string LoaiThe { get => _loaiThe; set => _loaiThe = value; }
        public int TinhTrang { get => _tinhTrang; set => _tinhTrang = value; }
        public int DiemTichLuy { get => _diemTichLuy; set => _diemTichLuy = value; }
    }
}
