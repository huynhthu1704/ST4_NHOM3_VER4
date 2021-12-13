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
using BLL;
using ET;

namespace GUI.Admin
{
    public partial class frmThongKeNhanVien : Form
    {
        public frmThongKeNhanVien()
        {
            InitializeComponent();
        }
        BLL_BoPhan bBoPhan = new BLL_BoPhan();
        private void frmThongKeNhanVien_Load(object sender, EventArgs e)
        {
            cboMaBP.DataSource = bBoPhan.LayDS();
            cboMaBP.DisplayMember = "MaBP";
            cboMaBP.ValueMember = "MaBP";
            cboMaBP.SelectedIndex = 0;
            rdbInTatCa.Checked = true;
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (rdbInTatCa.Checked == true)
            {
                 Report.RPNhanVien rptbnv = new Report.RPNhanVien();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                crvNhanVien.ReportSource = rptbnv;
            }
            else
            {
                    Report.RPNVTheoBP rpnvbp = new Report.RPNVTheoBP();
                    ParameterValues para = new ParameterValues();
                    ParameterDiscreteValue val = new ParameterDiscreteValue();
                    val.Value = cboMaBP.Text;
                    para.Add(val);
                    rpnvbp.DataDefinition.ParameterFields["@MaBP"].ApplyCurrentValues(para);
                    crvNhanVien.ReportSource = rpnvbp;
            }
        }

        private void frmThongKeNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
