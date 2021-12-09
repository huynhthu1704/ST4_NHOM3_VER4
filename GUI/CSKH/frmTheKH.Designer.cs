
namespace GUI.CSKH
{
    partial class frmTheKH
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
            this.dgvTheKH = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtMaThe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbDaKH = new System.Windows.Forms.RadioButton();
            this.rdbChuaKH = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTheKH
            // 
            this.dgvTheKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTheKH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTheKH.Location = new System.Drawing.Point(0, 231);
            this.dgvTheKH.Name = "dgvTheKH";
            this.dgvTheKH.Size = new System.Drawing.Size(684, 180);
            this.dgvTheKH.TabIndex = 12;
            this.dgvTheKH.Click += new System.EventHandler(this.dgvTheKH_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(434, 167);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(92, 39);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(286, 167);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(92, 39);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(140, 167);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 39);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaThe
            // 
            this.txtMaThe.Location = new System.Drawing.Point(221, 30);
            this.txtMaThe.Name = "txtMaThe";
            this.txtMaThe.Size = new System.Drawing.Size(176, 27);
            this.txtMaThe.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã thẻ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbChuaKH);
            this.groupBox1.Controls.Add(this.rdbDaKH);
            this.groupBox1.Location = new System.Drawing.Point(131, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 98);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tình Trạng";
            // 
            // rdbDaKH
            // 
            this.rdbDaKH.AutoSize = true;
            this.rdbDaKH.Location = new System.Drawing.Point(22, 41);
            this.rdbDaKH.Name = "rdbDaKH";
            this.rdbDaKH.Size = new System.Drawing.Size(118, 23);
            this.rdbDaKH.TabIndex = 0;
            this.rdbDaKH.TabStop = true;
            this.rdbDaKH.Text = "Đã Kích Hoạt";
            this.rdbDaKH.UseVisualStyleBackColor = true;
            // 
            // rdbChuaKH
            // 
            this.rdbChuaKH.AutoSize = true;
            this.rdbChuaKH.Location = new System.Drawing.Point(166, 41);
            this.rdbChuaKH.Name = "rdbChuaKH";
            this.rdbChuaKH.Size = new System.Drawing.Size(136, 23);
            this.rdbChuaKH.TabIndex = 1;
            this.rdbChuaKH.TabStop = true;
            this.rdbChuaKH.Text = "Chưa Kích Hoạt";
            this.rdbChuaKH.UseVisualStyleBackColor = true;
            // 
            // frmTheKH
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(684, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvTheKH);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaThe);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmTheKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTheKH";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTheKH_FormClosing);
            this.Load += new System.EventHandler(this.frmTheKH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTheKH;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtMaThe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbChuaKH;
        private System.Windows.Forms.RadioButton rdbDaKH;
    }
}