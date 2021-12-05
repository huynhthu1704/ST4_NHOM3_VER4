// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HoaDon
    {
		private string maHD;
		private string maTheKH;
        private string maNV;
		private DateTime ngayTT;
		private string ghiChu;
		private int tienHang;
		private int khuyenMai;
		private int chietKhau;
		private int tongTien;
        private int diemTL;
		private int tienKhachDua;
		private int tienThoi;

        public ET_HoaDon(string maHD, string maTheKH, string maNV, DateTime ngayTT, string ghiChu, int tienHang, int khuyenMai, int chietKhau, int tongTien, int diemTL, int tienKhachDua, int tienThoi)
        {
            this.maHD = maHD;
            this.maTheKH = maTheKH;
            this.maNV = maNV;
            this.ngayTT = ngayTT;
            this.ghiChu = ghiChu;
            this.tienHang = tienHang;
            this.khuyenMai = khuyenMai;
            this.chietKhau = chietKhau;
            this.tongTien = tongTien;
            this.diemTL = diemTL;
            this.tienKhachDua = tienKhachDua;
            this.tienThoi = tienThoi;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaTheKH { get => maTheKH; set => maTheKH = value; }
        public DateTime NgayTT { get => ngayTT; set => ngayTT = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public int TienHang { get => tienHang; set => tienHang = value; }
        public int KhuyenMai { get => khuyenMai; set => khuyenMai = value; }
        public int ChietKhau { get => chietKhau; set => chietKhau = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int TienKhachDua { get => tienKhachDua; set => tienKhachDua = value; }
        public int TienThoi { get => tienThoi; set => tienThoi = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public int DiemTL { get => diemTL; set => diemTL = value; }
    }
}
