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
    public partial class frmLoaiTK : Form
    {
        private BLL_LoaiTaiKhoan _bll;
        private int STT = 0;
        public frmLoaiTK()
        {
            InitializeComponent();
            _bll = new BLL_LoaiTaiKhoan();
        }

        private void frmLoaiTK_Load(object sender, EventArgs e)
        {
            STT = _bll.HienThiDS().Rows.Count == 0 ? 1 : int.Parse(_bll.HienThiDS().Rows[0]["MaLoaiTK"].ToString().Substring(2)) + 1;
            txtMaLoai.Text = "ML" + string.Format("{0:00}", STT);
            dgvLoaiTK.DataSource = _bll.HienThiDS();
        }

        private void frmLoaiTK_FormClosing(object sender, FormClosingEventArgs e)
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
            ET_LoaiTK et = new ET_LoaiTK(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (_bll.CheckTonTai(et))
                {
                    MessageBox.Show("Đã tồn tại loại tài khoản này");
                } else
                {
                    if (_bll.ThemTaiKhoan(et))
                    {
                        MessageBox.Show("Thêm thành công");
                        STT++;
                        Reset();
                        dgvLoaiTK.DataSource = _bll.HienThiDS();
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
            ET_LoaiTK et = new ET_LoaiTK(txtMaLoai.Text, txtTenLoai.Text);
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
                        dgvLoaiTK.DataSource = _bll.HienThiDS();
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
            ET_LoaiTK et = new ET_LoaiTK(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (_bll.SuaTaiKhoan(et))
                {
                    MessageBox.Show("Sửa thành công");
                    Reset();
                    dgvLoaiTK.DataSource = _bll.HienThiDS();
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

        private void Reset()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
            txtMaLoai.Focus();
            txtMaLoai.Text = "ML" + string.Format("{0:00}", STT);
        }

        private void dgvLoaiTK_Click(object sender, EventArgs e)
        {
            int index = dgvLoaiTK.CurrentCell.RowIndex;
            txtMaLoai.Text = dgvLoaiTK.Rows[index].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvLoaiTK.Rows[index].Cells[1].Value.ToString();
        }
    }
}
