using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
namespace GUI
{
    public partial class frm_RPTimMKho : Form
    {
        public frm_RPTimMKho()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            RP_TimMaKho rp = new RP_TimMaKho();
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = txtTen.Text;
            para.Add(val);
            rp.DataDefinition.ParameterFields["@MaKho"].ApplyCurrentValues(para);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
