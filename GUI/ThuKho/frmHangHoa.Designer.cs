
namespace GUI.ThuKho
{
    partial class frmHangHoa
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
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.txtMaKM = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboDVT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboDM = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbKhong = new System.Windows.Forms.RadioButton();
            this.rdbCo = new System.Windows.Forms.RadioButton();
            this.cboMaKM = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radKMKhong = new System.Windows.Forms.RadioButton();
            this.radKMCo = new System.Windows.Forms.RadioButton();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHangHoa.Location = new System.Drawing.Point(0, 321);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.RowHeadersWidth = 51;
            this.dgvHangHoa.Size = new System.Drawing.Size(884, 240);
            this.dgvHangHoa.TabIndex = 29;
            this.dgvHangHoa.Click += new System.EventHandler(this.dgvHangHoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(636, 262);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(94, 43);
            this.btnThoat.TabIndex = 25;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(522, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 43);
            this.btnSua.TabIndex = 26;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(410, 262);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(94, 43);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(301, 262);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(94, 43);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(205, 162);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(176, 26);
            this.txtGia.TabIndex = 22;
            this.txtGia.Text = "0";
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(205, 59);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(176, 26);
            this.txtTenHH.TabIndex = 23;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(205, 12);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(176, 26);
            this.txtMaHH.TabIndex = 24;
            // 
            // txtMaKM
            // 
            this.txtMaKM.AutoSize = true;
            this.txtMaKM.Location = new System.Drawing.Point(459, 218);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.Size = new System.Drawing.Size(115, 20);
            this.txtMaKM.TabIndex = 17;
            this.txtMaKM.Text = "Mã khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tên HH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã HH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Đơn vị tính";
            // 
            // cboDVT
            // 
            this.cboDVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDVT.FormattingEnabled = true;
            this.cboDVT.Location = new System.Drawing.Point(205, 109);
            this.cboDVT.Name = "cboDVT";
            this.cboDVT.Size = new System.Drawing.Size(176, 28);
            this.cboDVT.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(459, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Danh mục";
            // 
            // cboDM
            // 
            this.cboDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDM.FormattingEnabled = true;
            this.cboDM.Location = new System.Drawing.Point(588, 10);
            this.cboDM.Name = "cboDM";
            this.cboDM.Size = new System.Drawing.Size(221, 28);
            this.cboDM.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbKhong);
            this.groupBox1.Controls.Add(this.rdbCo);
            this.groupBox1.Location = new System.Drawing.Point(463, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 53);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảo hành";
            // 
            // rdbKhong
            // 
            this.rdbKhong.AutoSize = true;
            this.rdbKhong.Location = new System.Drawing.Point(209, 23);
            this.rdbKhong.Name = "rdbKhong";
            this.rdbKhong.Size = new System.Drawing.Size(73, 24);
            this.rdbKhong.TabIndex = 1;
            this.rdbKhong.TabStop = true;
            this.rdbKhong.Text = "Không";
            this.rdbKhong.UseVisualStyleBackColor = true;
            // 
            // rdbCo
            // 
            this.rdbCo.AutoSize = true;
            this.rdbCo.Location = new System.Drawing.Point(106, 23);
            this.rdbCo.Name = "rdbCo";
            this.rdbCo.Size = new System.Drawing.Size(47, 24);
            this.rdbCo.TabIndex = 0;
            this.rdbCo.TabStop = true;
            this.rdbCo.Text = "Có";
            this.rdbCo.UseVisualStyleBackColor = true;
            // 
            // cboMaKM
            // 
            this.cboMaKM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaKM.FormattingEnabled = true;
            this.cboMaKM.Location = new System.Drawing.Point(588, 210);
            this.cboMaKM.Name = "cboMaKM";
            this.cboMaKM.Size = new System.Drawing.Size(221, 28);
            this.cboMaKM.TabIndex = 32;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radKMKhong);
            this.groupBox2.Controls.Add(this.radKMCo);
            this.groupBox2.Location = new System.Drawing.Point(463, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 66);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khuyến mãi";
            // 
            // radKMKhong
            // 
            this.radKMKhong.AutoSize = true;
            this.radKMKhong.Checked = true;
            this.radKMKhong.Location = new System.Drawing.Point(209, 24);
            this.radKMKhong.Name = "radKMKhong";
            this.radKMKhong.Size = new System.Drawing.Size(73, 24);
            this.radKMKhong.TabIndex = 1;
            this.radKMKhong.TabStop = true;
            this.radKMKhong.Text = "Không";
            this.radKMKhong.UseVisualStyleBackColor = true;
            this.radKMKhong.CheckedChanged += new System.EventHandler(this.radKMKhong_CheckedChanged);
            // 
            // radKMCo
            // 
            this.radKMCo.AutoSize = true;
            this.radKMCo.Location = new System.Drawing.Point(106, 25);
            this.radKMCo.Name = "radKMCo";
            this.radKMCo.Size = new System.Drawing.Size(47, 24);
            this.radKMCo.TabIndex = 0;
            this.radKMCo.Text = "Có";
            this.radKMCo.UseVisualStyleBackColor = true;
            this.radKMCo.CheckedChanged += new System.EventHandler(this.radKMCo_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(190, 262);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 43);
            this.btnReset.TabIndex = 34;
            this.btnReset.Text = "Làm Mới";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cboMaKM);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboDM);
            this.Controls.Add(this.cboDVT);
            this.Controls.Add(this.dgvHangHoa);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý hàng hóa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHangHoa_FormClosing);
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label txtMaKM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboDVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboDM;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbKhong;
        private System.Windows.Forms.RadioButton rdbCo;
        private System.Windows.Forms.ComboBox cboMaKM;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radKMKhong;
        private System.Windows.Forms.RadioButton radKMCo;
        private System.Windows.Forms.Button btnReset;
    }
}