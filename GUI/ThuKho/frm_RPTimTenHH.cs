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
    public partial class frm_RPTimTenHH : Form
    {
        public frm_RPTimTenHH()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            RP_TimTenHH rp = new RP_TimTenHH();
            ParameterValues para = new ParameterValues();
            ParameterDiscreteValue val = new ParameterDiscreteValue();
            val.Value = txtTen.Text;
            para.Add(val);
            rp.DataDefinition.ParameterFields["@Ten"].ApplyCurrentValues(para);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
