
namespace GUI.Report
{
    partial class frmRPHangHoa
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
            this.crvHangHoa = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpXuatToanBoHH1 = new GUI.Report.crpXuatToanBoHH();
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDM = new System.Windows.Forms.TextBox();
            this.rdbToanBo = new System.Windows.Forms.RadioButton();
            this.rdbBoPhan = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvHangHoa
            // 
            this.crvHangHoa.ActiveViewIndex = -1;
            this.crvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHangHoa.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvHangHoa.Location = new System.Drawing.Point(0, 158);
            this.crvHangHoa.Name = "crvHangHoa";
            this.crvHangHoa.Size = new System.Drawing.Size(800, 292);
            this.crvHangHoa.TabIndex = 7;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(479, 102);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 5;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Danh Mục :";
            // 
            // txtMaDM
            // 
            this.txtMaDM.Location = new System.Drawing.Point(190, 80);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.Size = new System.Drawing.Size(100, 20);
            this.txtMaDM.TabIndex = 2;
            // 
            // rdbToanBo
            // 
            this.rdbToanBo.AutoSize = true;
            this.rdbToanBo.Location = new System.Drawing.Point(24, 31);
            this.rdbToanBo.Name = "rdbToanBo";
            this.rdbToanBo.Size = new System.Drawing.Size(91, 17);
            this.rdbToanBo.TabIndex = 0;
            this.rdbToanBo.TabStop = true;
            this.rdbToanBo.Text = "Xuất Toàn Bộ";
            this.rdbToanBo.UseVisualStyleBackColor = true;
            // 
            // rdbBoPhan
            // 
            this.rdbBoPhan.AutoSize = true;
            this.rdbBoPhan.Location = new System.Drawing.Point(144, 31);
            this.rdbBoPhan.Name = "rdbBoPhan";
            this.rdbBoPhan.Size = new System.Drawing.Size(128, 17);
            this.rdbBoPhan.TabIndex = 1;
            this.rdbBoPhan.TabStop = true;
            this.rdbBoPhan.Text = "Xuất Theo Danh Mục";
            this.rdbBoPhan.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBoPhan);
            this.groupBox1.Controls.Add(this.rdbToanBo);
            this.groupBox1.Controls.Add(this.txtMaDM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(121, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 128);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình Thức Xuất";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(592, 101);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmRPHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.crvHangHoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIn);
            this.Name = "frmRPHangHoa";
            this.Text = "frmRPHangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRPHangHoa_FormClosing);
            this.Load += new System.EventHandler(this.frmRPHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHangHoa;
        private crpXuatToanBoHH crpXuatToanBoHH1;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDM;
        private System.Windows.Forms.RadioButton rdbToanBo;
        private System.Windows.Forms.RadioButton rdbBoPhan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThoat;
    }
}