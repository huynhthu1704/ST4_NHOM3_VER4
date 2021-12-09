
namespace GUI.Report
{
    partial class frmRPNhanVien
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
            this.btnIn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaBP = new System.Windows.Forms.TextBox();
            this.crpNhanVien2 = new GUI.Report.crpNhanVien();
            this.crpNhanVien1 = new GUI.Report.crpNhanVien();
            this.crvNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpNhanVien3 = new GUI.Report.crpNhanVien();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbBoPhan = new System.Windows.Forms.RadioButton();
            this.rdbToanBo = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(436, 103);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(75, 23);
            this.btnIn.TabIndex = 0;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Mã Bộ Phận :";
            // 
            // txtMaBP
            // 
            this.txtMaBP.Location = new System.Drawing.Point(190, 80);
            this.txtMaBP.Name = "txtMaBP";
            this.txtMaBP.Size = new System.Drawing.Size(100, 20);
            this.txtMaBP.TabIndex = 2;
            // 
            // crvNhanVien
            // 
            this.crvNhanVien.ActiveViewIndex = 0;
            this.crvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvNhanVien.Location = new System.Drawing.Point(0, 147);
            this.crvNhanVien.Name = "crvNhanVien";
            this.crvNhanVien.ReportSource = this.crpNhanVien3;
            this.crvNhanVien.Size = new System.Drawing.Size(800, 303);
            this.crvNhanVien.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBoPhan);
            this.groupBox1.Controls.Add(this.rdbToanBo);
            this.groupBox1.Controls.Add(this.txtMaBP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(78, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 128);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hình Thức Xuất";
            // 
            // rdbBoPhan
            // 
            this.rdbBoPhan.AutoSize = true;
            this.rdbBoPhan.Location = new System.Drawing.Point(144, 31);
            this.rdbBoPhan.Name = "rdbBoPhan";
            this.rdbBoPhan.Size = new System.Drawing.Size(119, 17);
            this.rdbBoPhan.TabIndex = 1;
            this.rdbBoPhan.TabStop = true;
            this.rdbBoPhan.Text = "Xuất Theo Bộ Phận";
            this.rdbBoPhan.UseVisualStyleBackColor = true;
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
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(544, 102);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmRPNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvNhanVien);
            this.Controls.Add(this.btnIn);
            this.Name = "frmRPNhanVien";
            this.Text = "frmRPNhanVien";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRPNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmRPNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaBP;
        private crpNhanVien crpNhanVien1;
        private crpNhanVien crpNhanVien2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhanVien;
        private crpNhanVien crpNhanVien3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbBoPhan;
        private System.Windows.Forms.RadioButton rdbToanBo;
        private System.Windows.Forms.Button btnThoat;
    }
}