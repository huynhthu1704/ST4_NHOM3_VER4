///Đức Trí
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NCC
    {
        private string maNCC;
        private string tenNCC;
        private string diaChi;
        private string sDT;
        private string email;

        public ET_NCC(string maNCC, string tenNCC, string diaChi, string sDT, string email)
        {
            this.maNCC = maNCC;
            this.tenNCC = tenNCC;
            this.diaChi = diaChi;
            this.sDT = sDT;
            this.email = email;
        }

        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string TenNCC { get => tenNCC; set => tenNCC = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string Email { get => email; set => email = value; }
    }
}
