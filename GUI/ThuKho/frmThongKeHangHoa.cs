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
namespace GUI.ThuKho
{
    public partial class frmThongKeHangHoa : Form
    {
        public frmThongKeHangHoa()
        {
            InitializeComponent();
        }
        BLL_DanhMucHH mucHH = new BLL_DanhMucHH();
        private void frmThongKeHangHoa_Load(object sender, EventArgs e)
        {
            cboDM.DataSource = mucHH.HienThiDS();
            cboDM.DisplayMember = "MaDM";
            cboDM.ValueMember = "MaDM";
            cboDM.SelectedIndex = 0;
            rdbInTatCa.Checked = true;
        }

        private void btnIN_Click(object sender, EventArgs e)
        {
            if (rdbInTatCa.Checked == true)
            {
                Report.RPAllHangHoa rptbhh = new Report.RPAllHangHoa();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                crvHangHoa.ReportSource = rptbhh;
            }
            else
            {
                Report.RPHHTheoDM rphhdm = new Report.RPHHTheoDM();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboDM.Text;
                para.Add(val);
                rphhdm.DataDefinition.ParameterFields["@MaDM"].ApplyCurrentValues(para);
                crvHangHoa.ReportSource = rphhdm;
            }
        }

        private void frmThongKeHangHoa_FormClosing(object sender, FormClosingEventArgs e)
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
