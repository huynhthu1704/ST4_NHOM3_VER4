using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace GUI
{
    public partial class frmMain : Form
    {
        Thread th;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            switch (Const.LoaiTK.TenLoai)
            {
                case "Admin":
                    break;
                case "ThuNgan":
                    mnuQL_Admin.Visible = false;
                    mnuQL_CSKH.Visible = false;
                    mnuQL_QLKho.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    mnuBaoCaoCSKH.Visible = false;
                    mnuBaoCao_QLKho.Visible = false;
                    break;
                case "ThuKho":
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_CSKH.Visible = false;
                    mnuQL_Admin.Visible = false;
                    mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCaoCSKH.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    break;
                case "CSKH":
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_QLKho.Visible = false;
                    mnuQL_Admin.Visible = false;
                    mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCao_QLKho.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    break;
                default:
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_QLKho.Visible = false;
                    mnuQL_Admin.Visible = false;
                    mnuQL_CSKH.Visible = false;
                    mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCaoCSKH.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    mnuBaoCao_QLKho.Visible = false;
                    break;
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuHT_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuHT_DN_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openLogin);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void openLogin()
        {
            Application.Run(new frmLogin());
        }

        private void mnuQL_QLKho_Click(object sender, EventArgs e)
        {

        }

        private bool CheckFormOpen(string name)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name.CompareTo(name) == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
