
namespace GUI.Admin
{
    partial class frmKhuyenMai
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKM = new System.Windows.Forms.TextBox();
            this.txtTenKM = new System.Windows.Forms.TextBox();
            this.txtGTKM = new System.Windows.Forms.TextBox();
            this.dtpBD = new System.Windows.Forms.DateTimePicker();
            this.dtpKT = new System.Windows.Forms.DateTimePicker();
            this.dvgDS = new System.Windows.Forms.DataGridView();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã KM:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên KM:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Giá Trị KM:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(390, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ngày Kết Thúc:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Bắt Đầu:";
            // 
            // txtMaKM
            // 
            this.txtMaKM.Location = new System.Drawing.Point(179, 34);
            this.txtMaKM.Name = "txtMaKM";
            this.txtMaKM.ReadOnly = true;
            this.txtMaKM.Size = new System.Drawing.Size(170, 26);
            this.txtMaKM.TabIndex = 7;
            this.txtMaKM.TabStop = false;
            // 
            // txtTenKM
            // 
            this.txtTenKM.Location = new System.Drawing.Point(179, 101);
            this.txtTenKM.Name = "txtTenKM";
            this.txtTenKM.Size = new System.Drawing.Size(170, 26);
            this.txtTenKM.TabIndex = 8;
            // 
            // txtGTKM
            // 
            this.txtGTKM.Location = new System.Drawing.Point(179, 164);
            this.txtGTKM.Name = "txtGTKM";
            this.txtGTKM.Size = new System.Drawing.Size(170, 26);
            this.txtGTKM.TabIndex = 10;
            // 
            // dtpBD
            // 
            this.dtpBD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBD.Location = new System.Drawing.Point(558, 32);
            this.dtpBD.Name = "dtpBD";
            this.dtpBD.Size = new System.Drawing.Size(167, 26);
            this.dtpBD.TabIndex = 11;
            // 
            // dtpKT
            // 
            this.dtpKT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpKT.Location = new System.Drawing.Point(558, 96);
            this.dtpKT.Name = "dtpKT";
            this.dtpKT.Size = new System.Drawing.Size(167, 26);
            this.dtpKT.TabIndex = 12;
            // 
            // dvgDS
            // 
            this.dvgDS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgDS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDS.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dvgDS.Location = new System.Drawing.Point(0, 316);
            this.dvgDS.Name = "dvgDS";
            this.dvgDS.RowHeadersWidth = 51;
            this.dvgDS.RowTemplate.Height = 24;
            this.dvgDS.Size = new System.Drawing.Size(800, 134);
            this.dvgDS.TabIndex = 13;
            this.dvgDS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDS_CellClick);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(200, 231);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(95, 46);
            this.btnThem.TabIndex = 14;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(476, 232);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(95, 46);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(332, 231);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(95, 46);
            this.btnSua.TabIndex = 16;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(615, 231);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(95, 46);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(67, 231);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(95, 46);
            this.btnMoi.TabIndex = 18;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // frmKhuyenMai
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dvgDS);
            this.Controls.Add(this.dtpKT);
            this.Controls.Add(this.dtpBD);
            this.Controls.Add(this.txtGTKM);
            this.Controls.Add(this.txtTenKM);
            this.Controls.Add(this.txtMaKM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Khuyến mãi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKhuyenMai_FormClosing_1);
            this.Load += new System.EventHandler(this.frmKhuyenMai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgDS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKM;
        private System.Windows.Forms.TextBox txtTenKM;
        private System.Windows.Forms.TextBox txtGTKM;
        private System.Windows.Forms.DateTimePicker dtpBD;
        private System.Windows.Forms.DateTimePicker dtpKT;
        private System.Windows.Forms.DataGridView dvgDS;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnMoi;
    }
}