// Ngọc Thư
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data;
using ET;
using BLL;
namespace GUI.ThuNgan
{
    public partial class frmInHD : Form
    {
        ET_HoaDon etHD;
        ET_ChiTietHD etCTHD;
        BLL_ChiTietHoaDon bllCTHD;
        BLL_HoaDon bllHD;
        List<ET_ChiTietHD> cthd = new List<ET_ChiTietHD>();
        public frmInHD(ET_HoaDon etHD)
        {
            InitializeComponent();
            this.etHD = etHD;
            bllHD = new BLL_HoaDon();
            bllCTHD = new BLL_ChiTietHoaDon();
        }

        private void frmInHD_Load(object sender, EventArgs e)
        {
            DataTable dt = null;
            try
            {
                MessageBox.Show(etHD.MaHD);
                dt = bllCTHD.LayCTHDTheoMaHD(etHD.MaHD);
                foreach (DataRow dr in dt.Rows)
                {
                    MessageBox.Show("hi");
                    cthd.Add(new ET_ChiTietHD(dr["MaHD"].ToString(), dr["MaHH"].ToString(), int.Parse(dr["SL"].ToString()), int.Parse(dr["Gia"].ToString()), int.Parse(dr["KhuyenMai"].ToString()), int.Parse(dr["ThanhTien"].ToString())));
                }
               // MessageBox.Show(dt.Rows.Count.ToString() + "row1");
                RPInHoaDon rp = new RPInHoaDon();
               // MessageBox.Show(dt.Rows.Count.ToString() + "row2");
                rp.SetDataSource(cthd);
                //MessageBox.Show(dt.Rows.Count.ToString() + "row3");
                rp.SetParameterValue("@MaHD", etHD.MaHD);
                //rp.SetParameterValue("tenNV", etHD.MaNV);
                //rp.SetParameterValue("ngayTT", etHD.NgayTT.ToString("dd/MM/yyyy HH:mm:ss"));
                //rp.SetParameterValue("ghiChu", etHD.GhiChu);
                //rp.SetParameterValue("tienHang", etHD.TienHang);
                //rp.SetParameterValue("kM", etHD.KhuyenMai);
                //rp.SetParameterValue("chietKhau", etHD.ChietKhau);
                //rp.SetParameterValue("thanhTien", etHD.TongTien);
                //rp.SetParameterValue("maThe", etHD.MaTheKH);
                //rp.SetParameterValue("diemTichLuy", etHD.DiemTL);
                //rp.SetParameterValue("tienKhachDua", etHD.TienKhachDua);
                //rp.SetParameterValue("tienThoi", etHD.TienThoi);

                inHDViewer.ReportSource = rp;
                inHDViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
