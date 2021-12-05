using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Ngọc Thư
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
        public frmInHD(ET_HoaDon etHD)
        {
            InitializeComponent();
            this.etHD = etHD;
            bllHD = new BLL_HoaDon();
            bllCTHD = new BLL_ChiTietHoaDon();
        }

        private void frmInHD_Load(object sender, EventArgs e)
        {
            /*DataTable dt = null;
            try
            {
                MessageBox.Show(etHD.MaHD);
                dt = bllCTHD.LayCTHDTheoMaHD(etHD.MaHD);
                MessageBox.Show(dt.Rows.Count.ToString() + "row1");
                //RPInHoaDon rp = new RPInHoaDon();
                MessageBox.Show(dt.Rows.Count.ToString() + "row2");
                rp.SetDataSource(dt);
                MessageBox.Show(dt.Rows.Count.ToString() + "row3");
                rp.SetParameterValue("maHD", etHD.MaHD);
                rp.SetParameterValue("tenNV", etHD.MaNV);
                rp.SetParameterValue("ngayTT", etHD.NgayTT.ToString("dd/MM/yyyy HH:mm:ss"));
                rp.SetParameterValue("ghiChu", etHD.GhiChu);
                rp.SetParameterValue("tienHang", etHD.TienHang);
                rp.SetParameterValue("kM", etHD.KhuyenMai);
                rp.SetParameterValue("chietKhau", etHD.ChietKhau);
                rp.SetParameterValue("thanhTien", etHD.TongTien);
                rp.SetParameterValue("maThe", etHD.MaTheKH);
                rp.SetParameterValue("diemTichLuy", etHD.DiemTL);
                rp.SetParameterValue("tienKhachDua", etHD.TienKhachDua);
                rp.SetParameterValue("tienThoi", etHD.TienThoi);

                inHDViewer.ReportSource = rp;
                inHDViewer.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/
        }
    }
}
