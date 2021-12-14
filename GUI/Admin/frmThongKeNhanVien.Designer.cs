
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
            this.button2 = new System.Windows.Forms.Button();
            this.cboMaBP = new System.Windows.Forms.ComboBox();
            this.btnIN = new System.Windows.Forms.Button();
            this.labelMaBP = new System.Windows.Forms.Label();
            this.rdbTheoBP = new System.Windows.Forms.RadioButton();
            this.rdbInTatCa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvNhanVien
            // 
            this.crvNhanVien.ActiveViewIndex = -1;
            this.crvNhanVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvNhanVien.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvNhanVien.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvNhanVien.Location = new System.Drawing.Point(0, 130);
            this.crvNhanVien.Name = "crvNhanVien";
            this.crvNhanVien.Size = new System.Drawing.Size(884, 431);
            this.crvNhanVien.TabIndex = 0;
            this.crvNhanVien.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.cboMaBP);
            this.groupBox1.Controls.Add(this.btnIN);
            this.groupBox1.Controls.Add(this.labelMaBP);
            this.groupBox1.Controls.Add(this.rdbTheoBP);
            this.groupBox1.Controls.Add(this.rdbInTatCa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(121, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 111);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức In";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(475, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 27);
            this.button2.TabIndex = 3;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboMaBP
            // 
            this.cboMaBP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMaBP.FormattingEnabled = true;
            this.cboMaBP.Location = new System.Drawing.Point(185, 61);
            this.cboMaBP.Name = "cboMaBP";
            this.cboMaBP.Size = new System.Drawing.Size(133, 28);
            this.cboMaBP.TabIndex = 3;
            // 
            // btnIN
            // 
            this.btnIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.Location = new System.Drawing.Point(345, 61);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(94, 27);
            this.btnIN.TabIndex = 2;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // labelMaBP
            // 
            this.labelMaBP.AutoSize = true;
            this.labelMaBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaBP.Location = new System.Drawing.Point(33, 68);
            this.labelMaBP.Name = "labelMaBP";
            this.labelMaBP.Size = new System.Drawing.Size(112, 20);
            this.labelMaBP.TabIndex = 2;
            this.labelMaBP.Text = "Chọn Bộ Phận";
            // 
            // rdbTheoBP
            // 
            this.rdbTheoBP.AutoSize = true;
            this.rdbTheoBP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTheoBP.Location = new System.Drawing.Point(345, 31);
            this.rdbTheoBP.Name = "rdbTheoBP";
            this.rdbTheoBP.Size = new System.Drawing.Size(224, 24);
            this.rdbTheoBP.TabIndex = 1;
            this.rdbTheoBP.TabStop = true;
            this.rdbTheoBP.Text = "In Nhân Viên Theo Bộ Phận";
            this.rdbTheoBP.UseVisualStyleBackColor = true;
            this.rdbTheoBP.CheckedChanged += new System.EventHandler(this.rdbTheoBP_CheckedChanged);
            // 
            // rdbInTatCa
            // 
            this.rdbInTatCa.AutoSize = true;
            this.rdbInTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbInTatCa.Location = new System.Drawing.Point(37, 31);
            this.rdbInTatCa.Name = "rdbInTatCa";
            this.rdbInTatCa.Size = new System.Drawing.Size(183, 24);
            this.rdbInTatCa.TabIndex = 0;
            this.rdbInTatCa.TabStop = true;
            this.rdbInTatCa.Text = "In Toàn Bộ Nhân Viên";
            this.rdbInTatCa.UseVisualStyleBackColor = true;
            this.rdbInTatCa.CheckedChanged += new System.EventHandler(this.rdbInTatCa_CheckedChanged);
            // 
            // frmThongKeNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
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
        private System.Windows.Forms.Label labelMaBP;
        private System.Windows.Forms.RadioButton rdbTheoBP;
        private System.Windows.Forms.RadioButton rdbInTatCa;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.Button button2;
    }
}