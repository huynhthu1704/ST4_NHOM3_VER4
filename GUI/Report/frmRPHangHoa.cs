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
    public partial class frmRPHangHoa : Form
    {
        public frmRPHangHoa()
        {
            InitializeComponent();
            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (rdbToanBo.Checked == true)
            {
                crpXuatToanBoHH rphtbh = new crpXuatToanBoHH();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                crvHangHoa.ReportSource = rphtbh;
            }
            else
            {
                if (txtMaDM.Text == "")
                {
                    MessageBox.Show("Vui lòng kiểm tra lại dữ liệu !");
                }
                else
                {
                    crpXuatHHTheoDM rpHHDM = new crpXuatHHTheoDM();
                    ParameterValues para = new ParameterValues();
                    ParameterDiscreteValue val = new ParameterDiscreteValue();
                    val.Value = txtMaDM.Text;
                    para.Add(val);
                    rpHHDM.DataDefinition.ParameterFields["@MaDM"].ApplyCurrentValues(para);
                    crvHangHoa.ReportSource = rpHHDM;
                }
            }
        }

        private void frmRPHangHoa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmRPHangHoa_Load(object sender, EventArgs e)
        {
            rdbToanBo.Checked = true;
        }
    }
}
