
namespace GUI.ThuKho
{
    partial class frmThongKeTonKho
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboKho = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTheoKho = new System.Windows.Forms.RadioButton();
            this.rdbInTatCa = new System.Windows.Forms.RadioButton();
            this.crvKho = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(729, 102);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 28);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(607, 102);
            this.btnIN.Margin = new System.Windows.Forms.Padding(4);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(100, 28);
            this.btnIN.TabIndex = 8;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboKho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbTheoKho);
            this.groupBox1.Controls.Add(this.rdbInTatCa);
            this.groupBox1.Location = new System.Drawing.Point(119, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(479, 137);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức In";
            // 
            // cboKho
            // 
            this.cboKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKho.FormattingEnabled = true;
            this.cboKho.Location = new System.Drawing.Point(277, 87);
            this.cboKho.Margin = new System.Windows.Forms.Padding(4);
            this.cboKho.Name = "cboKho";
            this.cboKho.Size = new System.Drawing.Size(160, 21);
            this.cboKho.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Kho";
            // 
            // rdbTheoKho
            // 
            this.rdbTheoKho.AutoSize = true;
            this.rdbTheoKho.Location = new System.Drawing.Point(212, 38);
            this.rdbTheoKho.Margin = new System.Windows.Forms.Padding(4);
            this.rdbTheoKho.Name = "rdbTheoKho";
            this.rdbTheoKho.Size = new System.Drawing.Size(136, 17);
            this.rdbTheoKho.TabIndex = 1;
            this.rdbTheoKho.TabStop = true;
            this.rdbTheoKho.Text = "In Hàng Hoá Theo Kho";
            this.rdbTheoKho.UseVisualStyleBackColor = true;
            // 
            // rdbInTatCa
            // 
            this.rdbInTatCa.AutoSize = true;
            this.rdbInTatCa.Location = new System.Drawing.Point(27, 38);
            this.rdbInTatCa.Margin = new System.Windows.Forms.Padding(4);
            this.rdbInTatCa.Name = "rdbInTatCa";
            this.rdbInTatCa.Size = new System.Drawing.Size(125, 17);
            this.rdbInTatCa.TabIndex = 0;
            this.rdbInTatCa.TabStop = true;
            this.rdbInTatCa.Text = "In Toàn Bộ  Tồn Kho";
            this.rdbInTatCa.UseVisualStyleBackColor = true;
            // 
            // crvKho
            // 
            this.crvKho.ActiveViewIndex = -1;
            this.crvKho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvKho.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvKho.Location = new System.Drawing.Point(0, 163);
            this.crvKho.Name = "crvKho";
            this.crvKho.Size = new System.Drawing.Size(1036, 399);
            this.crvKho.TabIndex = 10;
            // 
            // frmThongKeTonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 562);
            this.Controls.Add(this.crvKho);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongKeTonKho";
            this.Text = "frmThongKeTonKho";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeTonKho_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeTonKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboKho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTheoKho;
        private System.Windows.Forms.RadioButton rdbInTatCa;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvKho;
    }
}