//Thanh Quốc
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

namespace GUI.Report
{
    public partial class frmRPNhanVien : Form
    {
        public frmRPNhanVien()
        {
            InitializeComponent();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (rdbToanBo.Checked == true)
            {
                crpXuatTBNV rptbnv = new crpXuatTBNV();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                crvNhanVien.ReportSource = rptbnv;
            }
            else
            {
                if (txtMaBP.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại dữ liệu !");
                }
                else
                {
                    crpNhanVien rpnv = new crpNhanVien();
                    ParameterValues para = new ParameterValues();
                    ParameterDiscreteValue val = new ParameterDiscreteValue();
                    val.Value = txtMaBP.Text;
                    para.Add(val);
                    rpnv.DataDefinition.ParameterFields["@MaBP"].ApplyCurrentValues(para);
                    crvNhanVien.ReportSource = rpnv;
                }
            }
        }


        private void frmRPNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //kiểm tra kq 
            if (kq == DialogResult.Yes)
            {
                //Xu lý trc khi thoat
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRPNhanVien_Load(object sender, EventArgs e)
        {
            rdbToanBo.Checked = true;
        }
    }
}
