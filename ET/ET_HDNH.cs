// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_HDNH
    {
        private string maHD; // mã hóa đơn
        private string maNCC;// mã nhà cung cấp
        private string maNV; // mã nhân viên
        private DateTime thoiGian; // thời gian nhập hàng
        private int tongTien; // tổng tiền nhập
        private int traTruoc; // trả trước
        private int congNo; // công nợ


        public ET_HDNH(string maHD, string maNCC, string maNV, DateTime thoiGian, int tongTien, int traTruoc, int congNo)
        {
            this.maHD = maHD;
            this.maNCC = maNCC;
            this.maNV = maNV;
            this.thoiGian = thoiGian;
            this.tongTien = tongTien;
            this.traTruoc = traTruoc;
            this.congNo = congNo;
        }

        public string MaHD { get => maHD; set => maHD = value; }
        public string MaNCC { get => maNCC; set => maNCC = value; }
        public string MaNV { get => maNV; set => maNV = value; }
        public DateTime ThoiGian { get => thoiGian; set => thoiGian = value; }
        public int TongTien { get => tongTien; set => tongTien = value; }
        public int TraTruoc { get => traTruoc; set => traTruoc = value; }
        public int CongNo { get => congNo; set => congNo = value; }
    }
}
