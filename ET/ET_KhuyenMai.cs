/// Đức Trí
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ET
{
    public class ET_KhuyenMai
    {
        private string maKM;
        private string tenKM;
        private int giaTriKM;
        private DateTime ngayBD;
        private DateTime ngayKT;

        public ET_KhuyenMai(string maKM, string tenKM,  int giaTriKM, DateTime ngayBD, DateTime ngayKT)
        {
            this.maKM = maKM;
            this.tenKM = tenKM;
            this.giaTriKM = giaTriKM;
            this.ngayBD = ngayBD;
            this.ngayKT = ngayKT;
        }

        public string MaKM { get => maKM; set => maKM = value; }
        public string TenKM { get => tenKM; set => tenKM = value; }
        public int GiaTriKM { get => giaTriKM; set => giaTriKM = value; }
        public DateTime NgayBD { get => ngayBD; set => ngayBD = value; }
        public DateTime NgayKT { get => ngayKT; set => ngayKT = value; }
    }
}
