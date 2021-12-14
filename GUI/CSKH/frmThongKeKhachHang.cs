using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.CSKH
{
    public partial class frmThongKeKhachHang : Form
    {
        public frmThongKeKhachHang()
        {
            InitializeComponent();
        }


        private void frmThongKeKhachHang_Load(object sender, EventArgs e)
        {
            Report.RPKhachHang cr = new Report.RPKhachHang();
            crvKhachHang.ReportSource = cr;
        }
    }
}
