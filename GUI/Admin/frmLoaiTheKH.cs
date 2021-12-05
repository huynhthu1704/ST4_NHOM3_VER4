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
    public partial class frmLoaiTheKH : Form
    {
        private BLL_LoaiTheKH _bll;
        public frmLoaiTheKH()
        {
            InitializeComponent();
            _bll = new BLL_LoaiTheKH();
        }

        private void frmLoaiTheKH_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = _bll.HienThiDS();
        }

        private void frmLoaiTheKH_FormClosing(object sender, FormClosingEventArgs e)
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
            ET_LoaiTheKH et = new ET_LoaiTheKH(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (_bll.CheckTonTai(et))
                {
                    MessageBox.Show("Đã tồn tại loại tài khoản này");
                }
                else
                {
                    if (_bll.ThemLoaiTK(et))
                    {
                        MessageBox.Show("Thêm thành công");
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
            finally
            {
                Reset();
                dgvDS.DataSource = _bll.HienThiDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_LoaiTheKH et = new ET_LoaiTheKH(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaLoaiTK(et))
                    {
                        MessageBox.Show("Xóa thành công");
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
            finally
            {
                Reset();
                dgvDS.DataSource = _bll.HienThiDS();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_LoaiTheKH et = new ET_LoaiTheKH(txtMaLoai.Text, txtTenLoai.Text);
            try
            {
                if (_bll.XoaLoaiTK(et))
                {
                    MessageBox.Show("Sửa thành công");
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
            finally
            {
                Reset();
                dgvDS.DataSource = _bll.HienThiDS();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDS_Click(object sender, EventArgs e)
        {
            int index = dgvDS.CurrentCell.RowIndex;
            txtMaLoai.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
        }

        public void Reset()
        {
            txtMaLoai.Text = "";
            txtTenLoai.Text = "";
        }
    }
}
