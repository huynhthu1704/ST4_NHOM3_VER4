
namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuHT = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_DN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHT_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLBoPhan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKhuyenMai = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLLoaiTheKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoaiTKDN = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_NCC = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_NV = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_TK = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_QLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_DonViTinh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLHangHoa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_ThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTinhTien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_CSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDKTheKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQL_TheKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLKH = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQLBaoHanh = new System.Windows.Forms.ToolStripMenuItem();
            this.inBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_Admin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_QLKho = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCao_ThuNgan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBaoCaoCSKH = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT,
            this.mnuQL,
            this.inBáoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuHT
            // 
            this.mnuHT.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHT_DN,
            this.mnuHT_Thoat});
            this.mnuHT.Name = "mnuHT";
            this.mnuHT.Size = new System.Drawing.Size(86, 25);
            this.mnuHT.Text = "Hệ thống";
            // 
            // mnuHT_DN
            // 
            this.mnuHT_DN.Name = "mnuHT_DN";
            this.mnuHT_DN.Size = new System.Drawing.Size(180, 26);
            this.mnuHT_DN.Text = "Đăng xuất";
            this.mnuHT_DN.Click += new System.EventHandler(this.mnuHT_DN_Click);
            // 
            // mnuHT_Thoat
            // 
            this.mnuHT_Thoat.Name = "mnuHT_Thoat";
            this.mnuHT_Thoat.Size = new System.Drawing.Size(180, 26);
            this.mnuHT_Thoat.Text = "Thoát";
            this.mnuHT_Thoat.Click += new System.EventHandler(this.mnuHT_Thoat_Click);
            // 
            // mnuQL
            // 
            this.mnuQL.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQL_Admin,
            this.mnuQL_QLKho,
            this.mnuQL_ThuNgan,
            this.mnuQL_CSKH});
            this.mnuQL.Name = "mnuQL";
            this.mnuQL.Size = new System.Drawing.Size(76, 25);
            this.mnuQL.Text = "Quản lý";
            // 
            // mnuQL_Admin
            // 
            this.mnuQL_Admin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQLBoPhan,
            this.mnuQLKho,
            this.mnuQLKhuyenMai,
            this.mnuQLLoaiTheKH,
            this.mnuLoaiTKDN,
            this.mnuQL_NCC,
            this.mnuQL_NV,
            this.mnuQL_TK});
            this.mnuQL_Admin.Name = "mnuQL_Admin";
            this.mnuQL_Admin.Size = new System.Drawing.Size(180, 26);
            this.mnuQL_Admin.Text = "Admin";
            // 
            // mnuQLBoPhan
            // 
            this.mnuQLBoPhan.Name = "mnuQLBoPhan";
            this.mnuQLBoPhan.Size = new System.Drawing.Size(230, 26);
            this.mnuQLBoPhan.Text = "QL Bộ phận";
            // 
            // mnuQLKho
            // 
            this.mnuQLKho.Name = "mnuQLKho";
            this.mnuQLKho.Size = new System.Drawing.Size(230, 26);
            this.mnuQLKho.Text = "QL Kho";
            // 
            // mnuQLKhuyenMai
            // 
            this.mnuQLKhuyenMai.Name = "mnuQLKhuyenMai";
            this.mnuQLKhuyenMai.Size = new System.Drawing.Size(230, 26);
            this.mnuQLKhuyenMai.Text = "QL Khuyến mãi";
            // 
            // mnuQLLoaiTheKH
            // 
            this.mnuQLLoaiTheKH.Name = "mnuQLLoaiTheKH";
            this.mnuQLLoaiTheKH.Size = new System.Drawing.Size(230, 26);
            this.mnuQLLoaiTheKH.Text = "QL Loại Thẻ KH";
            // 
            // mnuLoaiTKDN
            // 
            this.mnuLoaiTKDN.Name = "mnuLoaiTKDN";
            this.mnuLoaiTKDN.Size = new System.Drawing.Size(230, 26);
            this.mnuLoaiTKDN.Text = "QL Loại Tài Khoản DN";
            // 
            // mnuQL_NCC
            // 
            this.mnuQL_NCC.Name = "mnuQL_NCC";
            this.mnuQL_NCC.Size = new System.Drawing.Size(230, 26);
            this.mnuQL_NCC.Text = "QL Nhà Cung Cấp";
            // 
            // mnuQL_NV
            // 
            this.mnuQL_NV.Name = "mnuQL_NV";
            this.mnuQL_NV.Size = new System.Drawing.Size(230, 26);
            this.mnuQL_NV.Text = "QL Nhân Viên";
            // 
            // mnuQL_TK
            // 
            this.mnuQL_TK.Name = "mnuQL_TK";
            this.mnuQL_TK.Size = new System.Drawing.Size(230, 26);
            this.mnuQL_TK.Text = "QL Tài Khoản";
            // 
            // mnuQL_QLKho
            // 
            this.mnuQL_QLKho.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQL_DanhMuc,
            this.mnuQL_DonViTinh,
            this.mnuQLHangHoa,
            this.mnuQL_NhapHang});
            this.mnuQL_QLKho.Name = "mnuQL_QLKho";
            this.mnuQL_QLKho.Size = new System.Drawing.Size(180, 26);
            this.mnuQL_QLKho.Text = "Quản lý kho";
            this.mnuQL_QLKho.Click += new System.EventHandler(this.mnuQL_QLKho_Click);
            // 
            // mnuQL_DanhMuc
            // 
            this.mnuQL_DanhMuc.Name = "mnuQL_DanhMuc";
            this.mnuQL_DanhMuc.Size = new System.Drawing.Size(181, 26);
            this.mnuQL_DanhMuc.Text = "QL Danh mục";
            // 
            // mnuQL_DonViTinh
            // 
            this.mnuQL_DonViTinh.Name = "mnuQL_DonViTinh";
            this.mnuQL_DonViTinh.Size = new System.Drawing.Size(181, 26);
            this.mnuQL_DonViTinh.Text = "QL Đơn vị tính";
            // 
            // mnuQLHangHoa
            // 
            this.mnuQLHangHoa.Name = "mnuQLHangHoa";
            this.mnuQLHangHoa.Size = new System.Drawing.Size(181, 26);
            this.mnuQLHangHoa.Text = "QL Hàng hóa";
            // 
            // mnuQL_NhapHang
            // 
            this.mnuQL_NhapHang.Name = "mnuQL_NhapHang";
            this.mnuQL_NhapHang.Size = new System.Drawing.Size(181, 26);
            this.mnuQL_NhapHang.Text = "QL Nhập hàng";
            // 
            // mnuQL_ThuNgan
            // 
            this.mnuQL_ThuNgan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuTinhTien});
            this.mnuQL_ThuNgan.Name = "mnuQL_ThuNgan";
            this.mnuQL_ThuNgan.Size = new System.Drawing.Size(180, 26);
            this.mnuQL_ThuNgan.Text = "Thu Ngân";
            // 
            // mnuTinhTien
            // 
            this.mnuTinhTien.Name = "mnuTinhTien";
            this.mnuTinhTien.Size = new System.Drawing.Size(180, 26);
            this.mnuTinhTien.Text = "Tính Tiền";
            // 
            // mnuQL_CSKH
            // 
            this.mnuQL_CSKH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuDKTheKH,
            this.mnuQL_TheKH,
            this.mnuQLKH,
            this.mnuQLBaoHanh});
            this.mnuQL_CSKH.Name = "mnuQL_CSKH";
            this.mnuQL_CSKH.Size = new System.Drawing.Size(180, 26);
            this.mnuQL_CSKH.Text = "CSKH";
            // 
            // mnuDKTheKH
            // 
            this.mnuDKTheKH.Name = "mnuDKTheKH";
            this.mnuDKTheKH.Size = new System.Drawing.Size(214, 26);
            this.mnuDKTheKH.Text = "Đăng Ký Thẻ KH";
            // 
            // mnuQL_TheKH
            // 
            this.mnuQL_TheKH.Name = "mnuQL_TheKH";
            this.mnuQL_TheKH.Size = new System.Drawing.Size(214, 26);
            this.mnuQL_TheKH.Text = "QL Thẻ KH";
            // 
            // mnuQLKH
            // 
            this.mnuQLKH.Name = "mnuQLKH";
            this.mnuQLKH.Size = new System.Drawing.Size(214, 26);
            this.mnuQLKH.Text = "QL Khách Hàng";
            // 
            // mnuQLBaoHanh
            // 
            this.mnuQLBaoHanh.Name = "mnuQLBaoHanh";
            this.mnuQLBaoHanh.Size = new System.Drawing.Size(214, 26);
            this.mnuQLBaoHanh.Text = "QL Phiếu Bảo Hành";
            // 
            // inBáoCáoToolStripMenuItem
            // 
            this.inBáoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBaoCao_Admin,
            this.mnuBaoCao_QLKho,
            this.mnuBaoCao_ThuNgan,
            this.mnuBaoCaoCSKH});
            this.inBáoCáoToolStripMenuItem.Name = "inBáoCáoToolStripMenuItem";
            this.inBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.inBáoCáoToolStripMenuItem.Text = "In Báo Cáo";
            // 
            // mnuBaoCao_Admin
            // 
            this.mnuBaoCao_Admin.Name = "mnuBaoCao_Admin";
            this.mnuBaoCao_Admin.Size = new System.Drawing.Size(180, 26);
            this.mnuBaoCao_Admin.Text = "Admin";
            // 
            // mnuBaoCao_QLKho
            // 
            this.mnuBaoCao_QLKho.Name = "mnuBaoCao_QLKho";
            this.mnuBaoCao_QLKho.Size = new System.Drawing.Size(180, 26);
            this.mnuBaoCao_QLKho.Text = "QL Kho";
            // 
            // mnuBaoCao_ThuNgan
            // 
            this.mnuBaoCao_ThuNgan.Name = "mnuBaoCao_ThuNgan";
            this.mnuBaoCao_ThuNgan.Size = new System.Drawing.Size(180, 26);
            this.mnuBaoCao_ThuNgan.Text = "Thu Ngân";
            // 
            // mnuBaoCaoCSKH
            // 
            this.mnuBaoCaoCSKH.Name = "mnuBaoCaoCSKH";
            this.mnuBaoCaoCSKH.Size = new System.Drawing.Size(180, 26);
            this.mnuBaoCaoCSKH.Text = "CSKH";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuHT;
        private System.Windows.Forms.ToolStripMenuItem mnuHT_DN;
        private System.Windows.Forms.ToolStripMenuItem mnuHT_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnuQL;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_Admin;
        private System.Windows.Forms.ToolStripMenuItem mnuQLBoPhan;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKho;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKhuyenMai;
        private System.Windows.Forms.ToolStripMenuItem mnuQLLoaiTheKH;
        private System.Windows.Forms.ToolStripMenuItem mnuLoaiTKDN;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_NCC;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_NV;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_TK;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_QLKho;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_DonViTinh;
        private System.Windows.Forms.ToolStripMenuItem mnuQLHangHoa;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_NhapHang;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_ThuNgan;
        private System.Windows.Forms.ToolStripMenuItem mnuTinhTien;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_CSKH;
        private System.Windows.Forms.ToolStripMenuItem mnuDKTheKH;
        private System.Windows.Forms.ToolStripMenuItem mnuQL_TheKH;
        private System.Windows.Forms.ToolStripMenuItem mnuQLKH;
        private System.Windows.Forms.ToolStripMenuItem mnuQLBaoHanh;
        private System.Windows.Forms.ToolStripMenuItem inBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_Admin;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_QLKho;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCao_ThuNgan;
        private System.Windows.Forms.ToolStripMenuItem mnuBaoCaoCSKH;
    }
}