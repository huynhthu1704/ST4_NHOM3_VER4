// Ngọc Thư

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_LoaiTK
    {
        private string _maLoaiTK;
        private string _tenLoai;

        public ET_LoaiTK(string maLoaiTK, string tenLoai)
        {
            this._maLoaiTK = maLoaiTK;
            this._tenLoai = tenLoai;
        }

        public string MaLoaiTK { get => _maLoaiTK; set => _maLoaiTK = value; }
        public string TenLoai { get => _tenLoai; set => _tenLoai = value; }
    }
}
