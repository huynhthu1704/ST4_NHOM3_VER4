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
using ET;
using BLL;
namespace GUI.ThuNgan
{
    public partial class frmInHD : Form
    {
        ET_HoaDon etHD;
        BLL_ChiTietHoaDon bllCTHD;
        List<ET_ChiTietHD> cthd = new List<ET_ChiTietHD>();
        public frmInHD(ET_HoaDon etHD)
        {
            InitializeComponent();
            this.etHD = etHD;
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
                    cthd.Add(new ET_ChiTietHD(dr["MaHD"].ToString(), dr["MaHH"].ToString(), int.Parse(dr["SL"].ToString()), int.Parse(dr["Gia"].ToString()), int.Parse(dr["KhuyenMai"].ToString()), int.Parse(dr["ThanhTien"].ToString())));
                }
                Report.RPInHoaDon rp = new Report.RPInHoaDon();
                rp.SetDataSource(cthd);
                rp.SetParameterValue("@MaHD", etHD.MaHD);
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
