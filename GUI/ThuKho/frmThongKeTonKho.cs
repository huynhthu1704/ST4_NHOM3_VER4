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
    public partial class frmThongKeTonKho : Form
    {
        public frmThongKeTonKho()
        {
            InitializeComponent();
        }
        BLL_Kho Kho = new BLL_Kho();
        private void btnIN_Click(object sender, EventArgs e)
        {
            if (rdbInTatCa.Checked == true)
            {
                Report.RPThongKeTonKho rp = new Report.RPThongKeTonKho();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                crvKho.ReportSource = rp;
            }
            else
            {
                Report.RPDSHangHoaTheoKho rp = new Report.RPDSHangHoaTheoKho();
                ParameterValues para = new ParameterValues();
                ParameterDiscreteValue val = new ParameterDiscreteValue();
                val.Value = cboKho.Text;
                para.Add(val);
                rp.DataDefinition.ParameterFields["@MaKho"].ApplyCurrentValues(para);
                crvKho.ReportSource = rp;
            }
        }

        private void frmThongKeTonKho_Load(object sender, EventArgs e)
        {
            cboKho.DataSource = Kho.LayDS();
            cboKho.DisplayMember = "MaKho";
            cboKho.ValueMember = "MaKho";
            cboKho.SelectedIndex = 0;
            rdbInTatCa.Checked = true;
        }

        private void frmThongKeTonKho_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
