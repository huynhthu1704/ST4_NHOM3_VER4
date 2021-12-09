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
		private string maHD; // mã hóa đơn
		private string maTheKH;// mã thẻ KH
        private string maNV; // mã nhân viên
		private DateTime ngayTT; // ngày thanh toán
		private string ghiChu; // ghi chú
		private int tienHang; // tiền hàng
		private int khuyenMai; // khuyến mãi
		private int chietKhau; // chiết khấu
		private int tongTien; // tổng tiền
        private int diemTL; // điểm tích lũy
		private int tienKhachDua; // tiền khách đưa
		private int tienThoi; // tiền thối

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
