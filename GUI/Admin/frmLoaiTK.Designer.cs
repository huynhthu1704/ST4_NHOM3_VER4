
namespace GUI.Admin
{
    partial class frmLoaiTK
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
            this.dgvLoaiTK = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtTenLoai = new System.Windows.Forms.TextBox();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLoaiTK
            // 
            this.dgvLoaiTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiTK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvLoaiTK.Location = new System.Drawing.Point(0, 231);
            this.dgvLoaiTK.Name = "dgvLoaiTK";
            this.dgvLoaiTK.Size = new System.Drawing.Size(684, 180);
            this.dgvLoaiTK.TabIndex = 30;
            this.dgvLoaiTK.Click += new System.EventHandler(this.dgvLoaiTK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(480, 135);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 39);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(382, 135);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(284, 135);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 39);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(186, 135);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTenLoai
            // 
            this.txtTenLoai.Location = new System.Drawing.Point(292, 62);
            this.txtTenLoai.Name = "txtTenLoai";
            this.txtTenLoai.Size = new System.Drawing.Size(176, 27);
            this.txtTenLoai.TabIndex = 2;
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(292, 10);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(176, 27);
            this.txtMaLoai.TabIndex = 1;
            this.txtMaLoai.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tên loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã loại";
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(88, 135);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(92, 39);
            this.btnMoi.TabIndex = 31;
            this.btnMoi.Text = "Mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // frmLoaiTK
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.dgvLoaiTK);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTenLoai);
            this.Controls.Add(this.txtMaLoai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmLoaiTK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý loại tài khoản";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiTK_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiTK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLoaiTK;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenLoai;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMoi;
    }
}