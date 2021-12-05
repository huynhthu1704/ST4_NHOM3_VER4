// Ngọc Thư

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_TaiKhoan
    {
        private string _maTK;
        private string _tenDN;
        private string _matKhau;
        private string _maLoaiTK;

        public ET_TaiKhoan(string maTK, string tenDN, string matKhau, string maLoaiTK)
        {
            _maTK = maTK;
            _tenDN = tenDN;
            _matKhau = matKhau;
            _maLoaiTK = maLoaiTK;
        }

        public string MaTK { get => _maTK; set => _maTK = value; }
        public string TenDN { get => _tenDN; set => _tenDN = value; }
        public string MatKhau { get => _matKhau; set => _matKhau = value; }
        public string MaLoaiTK { get => _maLoaiTK; set => _maLoaiTK = value; }
    }
}
