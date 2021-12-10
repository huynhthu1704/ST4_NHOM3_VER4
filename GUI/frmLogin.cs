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
using System.Threading;
using ET;
using BLL;
namespace GUI
{
    public partial class frmLogin : Form
    {
        Thread th;
        public string maNV = "";
        BLL_TaiKhoan bllTK = new BLL_TaiKhoan();
        BLL_LoaiTaiKhoan bllLoaiTK = new BLL_LoaiTaiKhoan();
        BLL_NhanVien bllNV = new BLL_NhanVien();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }

        // Sự kiện trước khi đóng form
        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {

            //try
            //{
            //    DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
            //       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //    if (kq == DialogResult.Yes)
            //    {
            //        e.Cancel = false;
            //    }
            //    else
            //    {
            //        e.Cancel = true;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        // Sự kiện khi nhấn btnDN
        private void btnDN_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDN.Text; // Tên đăng nhập
            string mk = txtMK.Text; // Mật khẩu
            try
            {
                DataTable dt = bllTK.KiemTraDN(tenDN, mk);
                if (dt.Rows.Count >  0)
                {
                    string maTK = dt.Rows[0]["MaTK"].ToString();
                    string maLoaiTK = dt.Rows[0]["MaLoaiTK"].ToString();
                    DataTable dt1 = bllLoaiTK.TimLoaiTK(maLoaiTK);
                  
                    string tenLoaiTK = dt1.Rows[0]["TenLoaiTK"].ToString();
                    Const.LoaiTK = new ET_LoaiTK(maLoaiTK, tenLoaiTK);
                    DataTable dt2 = bllNV.TimNVTheoTKDN(maTK);
                    Const.MaNhanVien = dt2.Rows[0]["MaNV"].ToString();
                    //Const.HoTenNV = dt2.Rows[0]["HoTen"].ToString();
                    th = new Thread(openFormMain);
                    this.Close();
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                  
                } else
                {
                    MessageBox.Show("Tài khoản không hợp lệ");
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void openFormMain()
        {
            Application.Run(new frmMain());
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
