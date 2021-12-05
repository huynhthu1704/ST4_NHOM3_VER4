
namespace GUI.ThuKho
{
    partial class frmHDNH
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCongNo = new System.Windows.Forms.TextBox();
            this.txtTienTraTruoc = new System.Windows.Forms.TextBox();
            this.txtTienHang = new System.Windows.Forms.TextBox();
            this.dgvHDNH = new System.Windows.Forms.DataGridView();
            this.colMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colKho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.numericSL = new System.Windows.Forms.NumericUpDown();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLuuHoaDon = new System.Windows.Forms.Button();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.cboNV = new System.Windows.Forms.ComboBox();
            this.btnQuayVe = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cboNCC = new System.Windows.Forms.ComboBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCongNo);
            this.panel1.Controls.Add(this.txtTienTraTruoc);
            this.panel1.Controls.Add(this.txtTienHang);
            this.panel1.Controls.Add(this.dgvHDNH);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 496);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Còn nợ";
            // 
            // txtCongNo
            // 
            this.txtCongNo.Location = new System.Drawing.Point(140, 422);
            this.txtCongNo.Name = "txtCongNo";
            this.txtCongNo.ReadOnly = true;
            this.txtCongNo.Size = new System.Drawing.Size(121, 26);
            this.txtCongNo.TabIndex = 6;
            // 
            // txtTienTraTruoc
            // 
            this.txtTienTraTruoc.Location = new System.Drawing.Point(140, 376);
            this.txtTienTraTruoc.Name = "txtTienTraTruoc";
            this.txtTienTraTruoc.Size = new System.Drawing.Size(121, 26);
            this.txtTienTraTruoc.TabIndex = 6;
            this.txtTienTraTruoc.TextChanged += new System.EventHandler(this.txtTienTraTruoc_TextChanged);
            // 
            // txtTienHang
            // 
            this.txtTienHang.Location = new System.Drawing.Point(140, 317);
            this.txtTienHang.Name = "txtTienHang";
            this.txtTienHang.ReadOnly = true;
            this.txtTienHang.Size = new System.Drawing.Size(125, 26);
            this.txtTienHang.TabIndex = 5;
            // 
            // dgvHDNH
            // 
            this.dgvHDNH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHDNH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHDNH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaSP,
            this.colTenSP,
            this.colSL,
            this.colGia,
            this.colKho});
            this.dgvHDNH.Location = new System.Drawing.Point(0, 3);
            this.dgvHDNH.Name = "dgvHDNH";
            this.dgvHDNH.ReadOnly = true;
            this.dgvHDNH.Size = new System.Drawing.Size(536, 274);
            this.dgvHDNH.TabIndex = 0;
            this.dgvHDNH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHDNH_CellContentClick);
            this.dgvHDNH.Click += new System.EventHandler(this.dgvHDNH_Click);
            // 
            // colMaSP
            // 
            this.colMaSP.HeaderText = "Mã SP";
            this.colMaSP.Name = "colMaSP";
            this.colMaSP.ReadOnly = true;
            // 
            // colTenSP
            // 
            this.colTenSP.HeaderText = "Tên SP";
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.ReadOnly = true;
            // 
            // colSL
            // 
            this.colSL.HeaderText = "SL";
            this.colSL.Name = "colSL";
            this.colSL.ReadOnly = true;
            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";
            this.colGia.ReadOnly = true;
            // 
            // colKho
            // 
            this.colKho.HeaderText = "Kho";
            this.colKho.Name = "colKho";
            this.colKho.ReadOnly = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(427, 443);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(80, 36);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tiền hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Trả trước";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(261, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 1;
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
            this.label9.Location = new System.Drawing.Point(563, 56);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Mã hóa đơn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(563, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Nhà cung cấp";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(563, 147);
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
            this.label15.Size = new System.Drawing.Size(157, 20);
            this.label15.TabIndex = 1;
            this.label15.Text = "Thời gian nhập hàng:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(13, 19);
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
            // numericSL
            // 
            this.numericSL.Location = new System.Drawing.Point(124, 115);
            this.numericSL.Name = "numericSL";
            this.numericSL.Size = new System.Drawing.Size(111, 26);
            this.numericSL.TabIndex = 6;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(577, 448);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(125, 36);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(746, 448);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(114, 36);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLuuHoaDon
            // 
            this.btnLuuHoaDon.Location = new System.Drawing.Point(746, 508);
            this.btnLuuHoaDon.Name = "btnLuuHoaDon";
            this.btnLuuHoaDon.Size = new System.Drawing.Size(114, 36);
            this.btnLuuHoaDon.TabIndex = 4;
            this.btnLuuHoaDon.Text = "Lưu hóa đơn";
            this.btnLuuHoaDon.UseVisualStyleBackColor = true;
            this.btnLuuHoaDon.Click += new System.EventHandler(this.btnLuuHoaDon_Click);
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(124, 13);
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
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(676, 53);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.ReadOnly = true;
            this.txtMaHD.Size = new System.Drawing.Size(184, 26);
            this.txtMaHD.TabIndex = 1;
            // 
            // cboNV
            // 
            this.cboNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNV.FormattingEnabled = true;
            this.cboNV.Location = new System.Drawing.Point(676, 144);
            this.cboNV.Name = "cboNV";
            this.cboNV.Size = new System.Drawing.Size(184, 28);
            this.cboNV.TabIndex = 3;
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
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGia);
            this.panel2.Controls.Add(this.cboKho);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtMaHH);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.numericSL);
            this.panel2.Controls.Add(this.txtTenHH);
            this.panel2.Location = new System.Drawing.Point(554, 178);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 254);
            this.panel2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Giá";
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(124, 160);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(159, 26);
            this.txtGia.TabIndex = 17;
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(124, 206);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(159, 28);
            this.cboKho.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Kho";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(17, 115);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(72, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Số lượng";
            // 
            // cboNCC
            // 
            this.cboNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNCC.FormattingEnabled = true;
            this.cboNCC.Location = new System.Drawing.Point(676, 98);
            this.cboNCC.Name = "cboNCC";
            this.cboNCC.Size = new System.Drawing.Size(184, 28);
            this.cboNCC.TabIndex = 11;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(577, 508);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 36);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(179, 15);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(57, 20);
            this.lblTime.TabIndex = 13;
            this.lblTime.Text = "label4";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // frmHDNH
            // 
            this.AcceptButton = this.btnThem;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.cboNCC);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnQuayVe);
            this.Controls.Add(this.cboNV);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.btnLuuHoaDon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmHDNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoá Đơn";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHDNH_FormClosing);
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHDNH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSL)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCongNo;
        private System.Windows.Forms.TextBox txtTienTraTruoc;
        private System.Windows.Forms.TextBox txtTienHang;
        private System.Windows.Forms.DataGridView dgvHDNH;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericSL;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLuuHoaDon;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.ComboBox cboNV;
        private System.Windows.Forms.Button btnQuayVe;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboNCC;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colKho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label label19;
    }
}