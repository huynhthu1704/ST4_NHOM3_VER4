
namespace GUI.ThuNgan
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiemTL = new System.Windows.Forms.TextBox();
            this.txtTienThoi = new System.Windows.Forms.TextBox();
            this.txtTienKhachDua = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txtChietKhau = new System.Windows.Forms.TextBox();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.colMaSp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSLCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGTKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.numericSL = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.txtMaTheKH = new System.Windows.Forms.TextBox();
            this.cboMaNV = new System.Windows.Forms.ComboBox();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDiemTL);
            this.panel1.Controls.Add(this.txtTienThoi);
            this.panel1.Controls.Add(this.txtTienKhachDua);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.txtChietKhau);
            this.panel1.Controls.Add(this.txtKhuyenMai);
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.txtTienHang);
            this.panel1.Controls.Add(this.dgvHoaDon);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 496);
            this.panel1.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Điểm tích lũy";
            // 
            // txtDiemTL
            // 
            this.txtDiemTL.Location = new System.Drawing.Point(384, 349);
            this.txtDiemTL.Name = "txtDiemTL";
            this.txtDiemTL.ReadOnly = true;
            this.txtDiemTL.Size = new System.Drawing.Size(121, 26);
            this.txtDiemTL.TabIndex = 7;
            this.txtDiemTL.TabStop = false;
            // 
            // txtTienThoi
            // 
            this.txtTienThoi.Location = new System.Drawing.Point(384, 430);
            this.txtTienThoi.Name = "txtTienThoi";
            this.txtTienThoi.ReadOnly = true;
            this.txtTienThoi.Size = new System.Drawing.Size(121, 26);
            this.txtTienThoi.TabIndex = 6;
            this.txtTienThoi.TabStop = false;
            // 
            // txtTienKhachDua
            // 
            this.txtTienKhachDua.Location = new System.Drawing.Point(384, 384);
            this.txtTienKhachDua.Name = "txtTienKhachDua";
            this.txtTienKhachDua.Size = new System.Drawing.Size(121, 26);
            this.txtTienKhachDua.TabIndex = 10;
            this.txtTienKhachDua.TextChanged += new System.EventHandler(this.txtTienKhachDua_TextChanged);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(121, 455);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(125, 26);
            this.txtTongTien.TabIndex = 6;
            this.txtTongTien.TabStop = false;
            // 
            // txtChietKhau
            // 
            this.txtChietKhau.Location = new System.Drawing.Point(121, 420);
            this.txtChietKhau.Name = "txtChietKhau";
            this.txtChietKhau.ReadOnly = true;
            this.txtChietKhau.Size = new System.Drawing.Size(125, 26);
            this.txtChietKhau.TabIndex = 6;
            this.txtChietKhau.TabStop = false;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Location = new System.Drawing.Point(121, 384);
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.ReadOnly = true;
            this.txtKhuyenMai.Size = new System.Drawing.Size(125, 26);
            this.txtKhuyenMai.TabIndex = 0;
            this.txtKhuyenMai.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(121, 291);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(384, 49);
            this.txtGhiChu.TabIndex = 9;
            // 
            // txtTienHang
            // 
            this.txtTienHang.Location = new System.Drawing.Point(121, 349);
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.ReadOnly = true;
            this.txtTienHang.Size = new System.Drawing.Size(125, 26);
            this.txtTienHang.TabIndex = 0;
            this.txtTienHang.TabStop = false;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSp,
            this.colTen,
            this.colGia,
            this.colSLCu,
            this.colSL,
            this.colGTKM,
            this.colKM,
            this.colThanhTien});
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(536, 274);
            this.dgvHoaDon.TabIndex = 11;
            this.dgvHoaDon.TabStop = false;
            this.dgvHoaDon.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellValueChanged);
            // 
            // colMaSp
            // 
            this.colMaSp.HeaderText = "Mã SP";
            this.colMaSp.Name = "colMaSp";
            this.colMaSp.ReadOnly = true;
            this.colMaSp.Visible = false;
            // 
            // colTen
            // 
            this.colTen.HeaderText = "Tên SP";
            this.colTen.Name = "colTen";
            this.colTen.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Đơn giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colSLCu
            // 
            this.colSLCu.HeaderText = "Số lượng cũ";
            this.colSLCu.Name = "colSLCu";
            this.colSLCu.ReadOnly = true;
            this.colSLCu.Visible = false;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "Số lượng";
            this.colSL.Name = "colSL";
            // 
            // colGTKM
            // 
            this.colGTKM.HeaderText = "GTKM";
            this.colGTKM.Name = "colGTKM";
            this.colGTKM.ReadOnly = true;
            this.colGTKM.Visible = false;
            // 
            // colKM
            // 
            this.colKM.HeaderText = "KM";
            this.colKM.Name = "colKM";
            this.colKM.ReadOnly = true;
            // 
            // colThanhTien
            // 
            this.colThanhTien.HeaderText = "Thành tiền";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(425, 457);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 384);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Khuyến mãi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 420);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chiếu khấu";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 455);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 20);
            this.label20.TabIndex = 1;
            this.label20.Text = "Tổng tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 388);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tiền khách đưa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 430);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tiền thối";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(85, -27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "label1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(580, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(580, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Thẻ KH";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(580, 147);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Nhân viên";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 15);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(126, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Thời gian T.Toán";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã sản phẩm";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 56);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 20);
            this.label18.TabIndex = 2;
            this.label18.Text = "Tên sản phẩm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Số lượng";
            // 
            // numericSL
            // 
            this.numericSL.Location = new System.Drawing.Point(124, 115);
            this.numericSL.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSL.Name = "numericSL";
            this.numericSL.Size = new System.Drawing.Size(111, 26);
            this.numericSL.TabIndex = 6;
            this.numericSL.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericSL.ValueChanged += new System.EventHandler(this.numericSL_ValueChanged);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(577, 448);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 36);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(746, 448);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.Location = new System.Drawing.Point(746, 508);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(114, 36);
            this.btnInHoaDon.TabIndex = 11;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = true;
            this.btnInHoaDon.Click += new System.EventHandler(this.btnInHoaDon_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHuy.Location = new System.Drawing.Point(577, 508);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(125, 36);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(124, 8);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(159, 26);
            this.txtMaHH.TabIndex = 4;
            this.txtMaHH.TextChanged += new System.EventHandler(this.txtMaSP_TextChanged);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(124, 56);
            this.txtTenHH.Multiline = true;
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.ReadOnly = true;
            this.txtTenHH.Size = new System.Drawing.Size(159, 39);
            this.txtTenHH.TabIndex = 5;
            this.txtTenHH.TabStop = false;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(691, 53);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(159, 26);
            this.txtMaHD.TabIndex = 1;
            this.txtMaHD.TabStop = false;
            // 
            // txtMaTheKH
            // 
            this.txtMaTheKH.Location = new System.Drawing.Point(691, 98);
            this.txtMaTheKH.Name = "txtMaTheKH";
            this.txtMaTheKH.Size = new System.Drawing.Size(159, 26);
            this.txtMaTheKH.TabIndex = 2;
            this.txtMaTheKH.TextChanged += new System.EventHandler(this.txtMaKH_TextChanged);
            // 
            // cboMaNV
            // 
            this.cboMaNV.FormattingEnabled = true;
            this.cboMaNV.Location = new System.Drawing.Point(691, 144);
            this.cboMaNV.Name = "cboMaNV";
            this.cboMaNV.Size = new System.Drawing.Size(159, 28);
            this.cboMaNV.TabIndex = 3;
            // 
            // btnQuayVe
            // 
            this.btnQuayVe.Location = new System.Drawing.Point(736, 7);
            this.btnQuayVe.Name = "btnQuayVe";
            this.btnQuayVe.Size = new System.Drawing.Size(114, 29);
            this.btnQuayVe.TabIndex = 9;
            this.btnQuayVe.Text = "Quay về ->";
            this.btnQuayVe.UseVisualStyleBackColor = true;
            this.btnQuayVe.Click += new System.EventHandler(this.btnQuayVe_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtMaHH);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.numericSL);
            this.panel2.Controls.Add(this.txtTenHH);
            this.panel2.Location = new System.Drawing.Point(567, 218);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 175);
            this.panel2.TabIndex = 4;
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.Location = new System.Drawing.Point(148, 15);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(174, 20);
            this.lblThoiGian.TabIndex = 11;
            this.lblThoiGian.Text = "Thời gian thanh toán";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmHoaDon
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnHuy;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.cboMaNV);
            this.Controls.Add(this.txtMaTheKH);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTienThoi;
        private System.Windows.Forms.TextBox txtTienKhachDua;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtChietKhau;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown numericSL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnInHoaDon;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.TextBox txtMaTheKH;
        private System.Windows.Forms.ComboBox cboMaNV;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiemTL;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSp;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSLCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGTKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
    }
}