
namespace GUI.ThuKho
{
    partial class frmThongKeHangHoa
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboDM = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdbTheoDM = new System.Windows.Forms.RadioButton();
            this.rdbInTatCa = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvHangHoa
            // 
            this.crvHangHoa.ActiveViewIndex = -1;
            this.crvHangHoa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvHangHoa.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crvHangHoa.Location = new System.Drawing.Point(0, 124);
            this.crvHangHoa.Name = "crvHangHoa";
            this.crvHangHoa.Size = new System.Drawing.Size(777, 333);
            this.crvHangHoa.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 75);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIN
            // 
            this.btnIN.Location = new System.Drawing.Point(488, 75);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(75, 23);
            this.btnIN.TabIndex = 5;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = true;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboDM);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdbTheoDM);
            this.groupBox1.Controls.Add(this.rdbInTatCa);
            this.groupBox1.Location = new System.Drawing.Point(122, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 111);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức In";
            // 
            // cboDM
            // 
            this.cboDM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDM.FormattingEnabled = true;
            this.cboDM.Location = new System.Drawing.Point(208, 71);
            this.cboDM.Name = "cboDM";
            this.cboDM.Size = new System.Drawing.Size(121, 21);
            this.cboDM.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Danh Mục";
            // 
            // rdbTheoDM
            // 
            this.rdbTheoDM.AutoSize = true;
            this.rdbTheoDM.Location = new System.Drawing.Point(159, 31);
            this.rdbTheoDM.Name = "rdbTheoDM";
            this.rdbTheoDM.Size = new System.Drawing.Size(167, 17);
            this.rdbTheoDM.TabIndex = 1;
            this.rdbTheoDM.TabStop = true;
            this.rdbTheoDM.Text = "In Hàng Hóa Theo Danh Mục";
            this.rdbTheoDM.UseVisualStyleBackColor = true;
            // 
            // rdbInTatCa
            // 
            this.rdbInTatCa.AutoSize = true;
            this.rdbInTatCa.Location = new System.Drawing.Point(20, 31);
            this.rdbInTatCa.Name = "rdbInTatCa";
            this.rdbInTatCa.Size = new System.Drawing.Size(130, 17);
            this.rdbInTatCa.TabIndex = 0;
            this.rdbInTatCa.TabStop = true;
            this.rdbInTatCa.Text = "In Toàn Bộ Hàng Hóa";
            this.rdbInTatCa.UseVisualStyleBackColor = true;
            // 
            // frmThongKeHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 457);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.crvHangHoa);
            this.Name = "frmThongKeHangHoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmThongKeHangHoa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKeHangHoa_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKeHangHoa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvHangHoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbTheoDM;
        private System.Windows.Forms.RadioButton rdbInTatCa;
    }
}