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
        Admin.frmBoPhan frmBoPhan = null;
        Admin.frmKho frmKho = null;
        Admin.frmKhuyenMai frmKM = null;
        Admin.frmLoaiTheKH frmLoaiTheKH = null;
        Admin.frmLoaiTK frmLoaiTK = null;
        Admin.frmNCC frmNCC = null;
        Admin.frmNhanVien frmNV = null;
        Admin.frmTaiKhoan frmTK = null;
        Admin.frmThongKeNhanVien inTKNhanVien = null;
        CSKH.frmKH frmKH = null;
        CSKH.frmPhieuBH frmPhieuBH = null;
        CSKH.frmPhieuDKTheKH frmPhieuDKTheKH = null;
        CSKH.frmTheKH frmTheKH = null;
        CSKH.frmThongKeKhachHang frmInKH = null;
        ThuKho.frmDanhMucHH frmDanhMucHH = null;
        ThuKho.frmDVTinh frmDVTinh = null;
        ThuKho.frmHangHoa frmHangHoa = null;
        ThuKho.frmHDNH frmHDNH = null;
        ThuNgan.frmHoaDon frmHoaDon = null;
        ThuKho.frmThongKeTonKho frmThuKho =null;
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
                    mnuBaoCaoThuKho.Visible = false;
                    break;
                case "ThuKho":
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_CSKH.Visible = false;
                    mnuQL_Admin.Visible = false;
                    //mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCaoCSKH.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    break;
                case "CSKH":
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_QLKho.Visible = false;
                    mnuQL_Admin.Visible = false;
                    //mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCaoThuKho.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    break;
                default:
                    mnuQL_ThuNgan.Visible = false;
                    mnuQL_QLKho.Visible = false;
                    mnuQL_Admin.Visible = false;
                    mnuQL_CSKH.Visible = false;
                    //mnuBaoCao_ThuNgan.Visible = false;
                    mnuBaoCaoCSKH.Visible = false;
                    mnuBaoCao_Admin.Visible = false;
                    mnuBaoCaoThuKho.Visible = false;
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
                    //foreach (Form child in this.MdiChildren)
                    //   {
                    //       child.FormClosing += new FormClosingEventHandler(frmMain_FormClosing(null, null));
                    //   }
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
            // this.Close();
            Application.Exit();
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

        private void mnuQLBoPhan_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmBoPhan"))
            {
                frmBoPhan.Focus();
            }
            else
            {
                frmBoPhan = new Admin.frmBoPhan();
                frmBoPhan.MdiParent = this;
                frmBoPhan.Show();
            }
        }

        private void mnuQLKho_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmKho"))
            {
                frmKho.Focus();
            }
            else
            {
                frmKho = new Admin.frmKho();
                frmKho.MdiParent = this;
                frmKho.Show();
            }
        }

        private void mnuQLKhuyenMai_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmKhuyenMai"))
            {
                frmKM.Focus();
            }
            else
            {
                frmKM = new Admin.frmKhuyenMai();
                frmKM.MdiParent = this;
                frmKM.Show();
            }
        }

        private void mnuQLLoaiTheKH_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmLoaiTheKH"))
            {
                frmLoaiTheKH.Focus();
            }
            else
            {
                frmLoaiTheKH = new Admin.frmLoaiTheKH();
                frmLoaiTheKH.MdiParent = this;
                frmLoaiTheKH.Show();
            }
        }

        private void mnuLoaiTKDN_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmLoaiTK"))
            {
                frmLoaiTK.Focus();
            }
            else
            {
                frmLoaiTK = new Admin.frmLoaiTK();
                frmLoaiTK.MdiParent = this;
                frmLoaiTK.Show();
            }
        }

        private void mnuQL_NCC_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmNCC"))
            {
                frmNCC.Focus();
            }
            else
            {
                frmNCC = new Admin.frmNCC();
                frmNCC.MdiParent = this;
                frmNCC.Show();
            }
        }

        private void mnuQL_NV_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmNhanVien"))
            {
                frmNV.Focus();
            }
            else
            {
                frmNV = new Admin.frmNhanVien();
                frmNV.MdiParent = this;
                frmNV.Show();
            }
        }

        private void mnuQL_TK_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmTaiKhoan"))
            {
                frmTK.Focus();
            }
            else
            {
                frmTK = new Admin.frmTaiKhoan();
                frmTK.MdiParent = this;
                frmTK.Show();
            }
        }

        private void mnuQL_DanhMuc_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmDanhMucHH"))
            {
                frmDanhMucHH.Focus();
            }
            else
            {
                frmDanhMucHH = new ThuKho.frmDanhMucHH();
                frmDanhMucHH.MdiParent = this;
                frmDanhMucHH.Show();
            }
        }

        private void mnuQL_DonViTinh_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmDVTinh"))
            {
                frmDVTinh.Focus();
            }
            else
            {
                frmDVTinh = new ThuKho.frmDVTinh();
                frmDVTinh.MdiParent = this;
                frmDVTinh.Show();
            }
        }

        private void mnuQLHangHoa_Click(object sender, EventArgs e)
        {

            if (CheckFormOpen("frmHangHoa"))
            {
                frmHangHoa.Focus();
            }
            else
            {
                frmHangHoa = new ThuKho.frmHangHoa();
                frmHangHoa.MdiParent = this;
                frmHangHoa.Show();
            }
        }

        private void mnuQL_NhapHang_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmHDNH"))
            {
                frmHDNH.Focus();
            }
            else
            {
                frmHDNH = new ThuKho.frmHDNH();
                frmHDNH.MdiParent = this;
                frmHDNH.Show();
            }
        }

        private void mnuTinhTien_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmHoaDon"))
            {
                frmHoaDon.Focus();
            }
            else
            {
                frmHoaDon = new ThuNgan.frmHoaDon();
                frmHoaDon.MdiParent = this;
                frmHoaDon.Show();
            }
        }

        private void mnuDKTheKH_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmPhieuDKTheKH"))
            {
                frmPhieuDKTheKH.Focus();
            }
            else
            {
                frmPhieuDKTheKH = new CSKH.frmPhieuDKTheKH();
                frmPhieuDKTheKH.MdiParent = this;
                frmPhieuDKTheKH.Show();
            }
        }

        private void mnuQL_TheKH_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmTheKH"))
            {
                frmTheKH.Focus();
            }
            else
            {
                frmTheKH = new CSKH.frmTheKH();
                frmTheKH.MdiParent = this;
                frmTheKH.Show();
            }
        }

        private void mnuQLKH_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmKH"))
            {
                frmKH.Focus();
            }
            else
            {
                frmKH = new CSKH.frmKH();
                frmKH.MdiParent = this;
                frmKH.Show();
            }
        }

        private void mnuQLBaoHanh_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmPhieuBH"))
            {
                frmPhieuBH.Focus();
            }
            else
            {
                frmPhieuBH = new CSKH.frmPhieuBH();
                frmPhieuBH.MdiParent = this;
                frmPhieuBH.Show();
            }
        }

        private void mnuBC_NV_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmThongKeNhanVien"))
            {
                inTKNhanVien.Focus();
            }
            else
            {
                inTKNhanVien = new Admin.frmThongKeNhanVien();
                inTKNhanVien.MdiParent = this;
                inTKNhanVien.Show();
            }
        }

        private void mnuBC_TonKho_Click(object sender, EventArgs e)
        {

        }

        private void mnuBC_KH_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmThongKeKhachHang"))
            {
                frmInKH.Focus();
            }
            else
            {
                frmInKH = new CSKH.frmThongKeKhachHang();
                frmInKH.MdiParent = this;
                frmInKH.Show();
            }
        }

        private void mnuBC_TK_Click(object sender, EventArgs e)
        {
            if (CheckFormOpen("frmThongKeTonKho"))
            {
                frmInKH.Focus();
            }
            else
            {
                frmThuKho = new ThuKho.frmThongKeTonKho();
                frmThuKho.MdiParent = this;
                frmThuKho.Show();
            }
        }

    }
}
