// Ngọc Thư

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ET;
using BLL;

namespace GUI.Admin
{
    public partial class frmTaiKhoan : Form
    {
        private BLL_TaiKhoan _bll;
        private int STT = 0;
        public frmTaiKhoan()
        {
            InitializeComponent();
            _bll = new BLL_TaiKhoan();
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            STT = _bll.HienThiDS().Rows.Count == 0 ? 1 : int.Parse(_bll.HienThiDS().Rows[0]["MaTK"].ToString().Substring(2)) + 1;
            txtMaTK.Text = "TK" + string.Format("{0:00}", STT);
            dgvTaiKhoan.DataSource = _bll.HienThiDS();
            cboLoaiTK.DataSource = _bll.HienThiLTK();
            cboLoaiTK.DisplayMember = "TenLoaiTK";
            cboLoaiTK.ValueMember = "MaLoaiTK";
            cboLoaiTK.SelectedIndex = 0;
        }

        private void frmTaiKhoan_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_TaiKhoan et = new ET_TaiKhoan(txtMaTK.Text, txtTenDN.Text, txtMK.Text, cboLoaiTK.SelectedValue.ToString());
            try
            {
                if (_bll.CheckTonTai(txtMaTK.Text))
                {
                    MessageBox.Show("Đã tồn tại loại tài khoản này");
                }
                else
                {
                    if (_bll.ThemTaiKhoan(et))
                    {
                        MessageBox.Show("Thêm thành công");
                        STT++;
                        Reset();
                        dgvTaiKhoan.DataSource = _bll.HienThiDS();
                    }
                    else
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_TaiKhoan et = new ET_TaiKhoan(txtMaTK.Text, txtTenDN.Text, txtMK.Text, cboLoaiTK.SelectedValue.ToString());
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaTaiKhoan(et))
                    {
                        MessageBox.Show("Xóa thành công");
                        Reset();
                        dgvTaiKhoan.DataSource = _bll.HienThiDS();
                    }
                    else
                    {
                        MessageBox.Show("Xóa không thành công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_TaiKhoan et = new ET_TaiKhoan(txtMaTK.Text, txtTenDN.Text, txtMK.Text, cboLoaiTK.SelectedValue.ToString());
            try
            {
                if (_bll.SuaTaiKhoan(et))
                {
                    MessageBox.Show("Sửa thành công");
                    Reset();
                    dgvTaiKhoan.DataSource = _bll.HienThiDS();
                }
                else
                {
                    MessageBox.Show("Sửa không thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Reset()
        {
            txtMaTK.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            cboLoaiTK.SelectedIndex = 0;
            txtMaTK.Text = "TK" + string.Format("{0:00}", STT);
        }

        private void dgvTaiKhoan_Click(object sender, EventArgs e)
        {
            int index = dgvTaiKhoan.CurrentCell.RowIndex;
            txtMaTK.Text = dgvTaiKhoan.Rows[index].Cells[0].Value.ToString();
            txtTenDN.Text = dgvTaiKhoan.Rows[index].Cells[1].Value.ToString();
            txtMK.Text = dgvTaiKhoan.Rows[index].Cells[2].Value.ToString();
            cboLoaiTK.SelectedValue = dgvTaiKhoan.Rows[index].Cells[3].Value.ToString();
        }
    }
}
