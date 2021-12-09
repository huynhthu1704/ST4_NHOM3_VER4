
namespace GUI.Report
{
    partial class frmRPKhachHang
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
            this.crvKhachHang = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.crpKhachHang1 = new GUI.Report.crpKhachHang();
            this.SuspendLayout();
            // 
            // crvKhachHang
            // 
            this.crvKhachHang.ActiveViewIndex = 0;
            this.crvKhachHang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKhachHang.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvKhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvKhachHang.Location = new System.Drawing.Point(0, 0);
            this.crvKhachHang.Name = "crvKhachHang";
            this.crvKhachHang.ReportSource = this.crpKhachHang1;
            this.crvKhachHang.Size = new System.Drawing.Size(800, 450);
            this.crvKhachHang.TabIndex = 0;
            this.crvKhachHang.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // frmRPKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crvKhachHang);
            this.Name = "frmRPKhachHang";
            this.Text = "frmRPKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmRPKhachHang_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvKhachHang;
        private crpKhachHang crpKhachHang1;
    }
}