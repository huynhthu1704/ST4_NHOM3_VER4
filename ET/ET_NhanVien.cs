using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_NhanVien
    {
        private string maNV;
        private string hoNV;
        private string tenNV;
        private string soDT;
        private string gioiTinh;
        private string CCCD;
        private DateTime ngaySinh;
        private string diaChi;
        private DateTime ngayVaoLam;
        private string maBP;
        private string maTK;

        public ET_NhanVien(string maNV, string hoNV, string tenNV, string soDT, string gioiTinh, string cCCD, DateTime ngaySinh, string diaChi, DateTime ngayVaoLam, string maBP, string maTK)
        {
            this.maNV = maNV;
            this.hoNV = hoNV;
            this.tenNV = tenNV;
            this.soDT = soDT;
            this.gioiTinh = gioiTinh;
            CCCD = cCCD;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.ngayVaoLam = ngayVaoLam;
            this.maBP = maBP;
            this.maTK = maTK;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoNV { get => hoNV; set => hoNV = value; }
        public string TenNV { get => tenNV; set => tenNV = value; }
        public string SoDT { get => soDT; set => soDT = value; }
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value; }
        public string CCCD1 { get => CCCD; set => CCCD = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public DateTime NgayVaoLam { get => ngayVaoLam; set => ngayVaoLam = value; }
        public string MaBP { get => maBP; set => maBP = value; }
        public string MaTK { get => maTK; set => maTK = value; }
    }
}
