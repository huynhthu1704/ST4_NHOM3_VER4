// Ngọc Thư
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BLL;
namespace GUI
{
    public partial class frmLogin : Form
    {
        public string maNV = "";
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDN_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text;
            string mk = txtMK.Text;
            try
            {
                if (bllTK.CheckTonTai(tenDN))
                {

                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
