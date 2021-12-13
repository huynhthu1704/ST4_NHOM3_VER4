
namespace GUI.Admin
{
    partial class frmThongKeNhanVien
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
            this.crvNhanVien = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbInTatCa = new System.Windows.Forms.RadioButton();
            this.rdbTheoBP = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMaBP = new System.Windows.Forms.ComboBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvNhanVien
            // 
            this.crvNhanVien.ActiveViewIndex = -1;
            this.crvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvNhanVien.Location = new System.Drawing.Point(0, 130);
            this.crvNhanVien.Name = "crvNhanVien";
            this.crvNhanVien.Size = new System.Drawing.Size(884, 431);
            this.crvNhanVien.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaBP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbTheoBP);
            this.groupBox1.Controls.Add(this.rdbInTatCa);
            this.groupBox1.Location = new System.Drawing.Point(178, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức In";
            // 
            // rdbInTatCa
            // 
            this.rdbInTatCa.AutoSize = true;
            this.rdbInTatCa.Location = new System.Drawing.Point(20, 31);
            this.rdbInTatCa.Name = "rdbInTatCa";
            this.rdbInTatCa.Size = new System.Drawing.Size(131, 17);
            this.rdbInTatCa.TabIndex = 0;
            this.rdbInTatCa.TabStop = true;
            this.rdbInTatCa.Text = "In Toàn Bộ Nhân Viên";
            this.rdbInTatCa.UseVisualStyleBackColor = true;
            // 
            // rdbTheoBP
            // 
            this.rdbTheoBP.AutoSize = true;
            this.rdbTheoBP.Location = new System.Drawing.Point(159, 31);
            this.rdbTheoBP.Name = "rdbTheoBP";
            this.rdbTheoBP.Size = new System.Drawing.Size(159, 17);
            this.rdbTheoBP.TabIndex = 1;
            this.rdbTheoBP.TabStop = true;
            this.rdbTheoBP.Text = "In Nhân Viên Theo Bộ Phận";
            this.rdbTheoBP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Bộ Phận";
            // 
            // cboMaBP
            // 
            this.cboMaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaBP.FormattingEnabled = true;
            this.cboMaBP.Location = new System.Drawing.Point(208, 71);
            this.cboMaBP.Name = "cboMaBP";
            this.cboMaBP.Size = new System.Drawing.Size(121, 21);
            this.cboMaBP.TabIndex = 3;
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(544, 81);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 23);
            this.btnIN.TabIndex = 2;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(636, 81);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvNhanVien);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmThongKeNhanVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeNhanVien_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeNhanVien_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboMaBP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTheoBP;
        private System.Windows.Forms.RadioButton rdbInTatCa;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button button2;
    }
}