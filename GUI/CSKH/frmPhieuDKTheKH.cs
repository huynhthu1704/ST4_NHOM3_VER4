//Thanh Quốc
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ET;

namespace GUI.CSKH
{
    public partial class frmPhieuDKTheKH : Form
    {
        private int sTT;
        private BLL_PhieuDKTheKH _bll;
        private BLL_KH _bllKH;
        private BLL_TheKH _bllTheKH;
        public frmPhieuDKTheKH()
        {
            InitializeComponent();
            _bll = new BLL_PhieuDKTheKH();
            _bllKH = new BLL_KH();
            _bllTheKH = new BLL_TheKH();
            timer1.Start();
        }

        private void frmPhieuDKTheKH_Load(object sender, EventArgs e)
        {
           
            Reset();
        }

        private void frmPhieuDKTheKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Thông báo và kq trả về
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //kiểm tra kq 
            if (kq == DialogResult.Yes)
            {
                //Xu lý trc khi thoat
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void dgvPhieuDK_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvPhieuDK.CurrentCell.RowIndex;
                txtMaPhieu.Text = dgvPhieuDK.Rows[dong].Cells[0].Value.ToString();
                cboMaNV.Text = dgvPhieuDK.Rows[dong].Cells[1].Value.ToString();
                cboMaTheKH.Text = dgvPhieuDK.Rows[dong].Cells[2].Value.ToString();
                cboMaKH.Text = dgvPhieuDK.Rows[dong].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void Reset()
        {
            //hiển thị danh sách nhân viên
            cboMaNV.DataSource = _bll.HienThiDSNV();
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
            //hiển thị danh sách thẻ khách hàng
            cboMaTheKH.DataSource = _bll.HienThiDSTheKH();
            cboMaTheKH.DisplayMember = "MaTheKH";
            cboMaTheKH.ValueMember = "MaTheKH";
            //hiển thị ds khách hàng
            cboMaKH.DataSource = _bll.HienThiDSKH();
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "MaKH";
            dgvPhieuDK.DataSource = _bll.HienThiDSPhieuDKTheKH();
            dgvPhieuDK.DataSource = _bll.HienThiDSPhieuDKTheKHGiam();
            sTT = _bll.HienThiDSPhieuDKTheKHGiam().Rows.Count != 0 ? int.Parse(_bll.HienThiDSPhieuDKTheKHGiam().Rows[0]["MaPhieu"].ToString().Substring(3)) + 1 : 1;
            txtMaPhieu.Text = "PDK" + string.Format("{0:00}", sTT);
            cboMaNV.SelectedIndex = 0;
            cboMaTheKH.SelectedIndex = 0;
            cboMaKH.SelectedIndex = 0;
            cboMaNV.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra các control 
            ET_PhieuDKTheKH et = new ET_PhieuDKTheKH(txtMaPhieu.Text, cboMaNV.SelectedValue.ToString(), cboMaTheKH.SelectedValue.ToString(), cboMaKH.SelectedValue.ToString(), DateTime.Now);
            try
            {
                //kiểm tra dư liệu
                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                //kiểm tra mã
                else if (_bll.CheckTonTai(et))
                {
                    MessageBox.Show("Đã tồn tại Phiếu Đăng Ký này");
                }
                else
                {
                    if (_bll.ThemPhieuDK(et))
                    {
                        _bllKH.SuaTheKH(et.MaKH, et.MaTheKH);
                        _bllTheKH.SuaTinhTrangThe(et.MaTheKH, 1);
                        MessageBox.Show("Thêm thành công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                //ném lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = DateTime.Now.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
