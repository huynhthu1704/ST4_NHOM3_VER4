
namespace GUI.ThuKho
{
    partial class frmInHDNhapHang
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
            this.crviewer_HDNH = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crviewer_HDNH
            // 
            this.crviewer_HDNH.ActiveViewIndex = -1;
            this.crviewer_HDNH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crviewer_HDNH.Cursor = System.Windows.Forms.Cursors.Default;
            this.crviewer_HDNH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crviewer_HDNH.Location = new System.Drawing.Point(0, 0);
            this.crviewer_HDNH.Name = "crviewer_HDNH";
            this.crviewer_HDNH.Size = new System.Drawing.Size(884, 561);
            this.crviewer_HDNH.TabIndex = 0;
            this.crviewer_HDNH.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // frmInHDNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.crviewer_HDNH);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmInHDNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.frmInHDNhapHang_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crviewer_HDNH;
    }
}