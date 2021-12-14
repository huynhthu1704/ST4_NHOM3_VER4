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

namespace GUI.ThuKho
{
    public partial class frmInHDNhapHang : Form
    {
        private string maHD = "";
        public frmInHDNhapHang(string maHD)
        {
            InitializeComponent();
            this.maHD = maHD;
        }

        private void frmInHDNhapHang_Load(object sender, EventArgs e)
        {
            Report.RPHoaDonNhapHang cr = new Report.RPHoaDonNhapHang();
            //ParameterValues para = new ParameterValues() ;
            //ParameterDiscreteValue val = new ParameterDiscreteValue();
            //val.Value = this.maHD;
            //cr.DataDefinition.ParameterFields["@MaHD"].ApplyCurrentValues(para);
            cr.SetParameterValue("@MaHD", this.maHD);
            crviewer_HDNH.ReportSource = cr;
        }
    }
}
