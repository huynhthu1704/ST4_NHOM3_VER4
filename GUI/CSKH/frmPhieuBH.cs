﻿//Thanh Quốc
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
    public partial class frmPhieuBH : Form
    {
        private BLL_PhieuBH _bll;
        public frmPhieuBH()
        {
            InitializeComponent();
            _bll = new BLL_PhieuBH();
        }

        private void frmPhieuBH_Load(object sender, EventArgs e)
        {
            cboMaKH.DataSource = _bll.HienThiDSKH();
            cboMaKH.DisplayMember = "MaKH";
            cboMaKH.ValueMember = "HoTenKH";
            cboMaHang.DataSource = _bll.HienThiDSHH();
            cboMaHang.DisplayMember = "MaHH";
            cboMaHang.ValueMember = "TenHH";
            dgvPhieuBH.DataSource = _bll.HienThiDSPhieuBH();
            cboMaHang.SelectedIndex = 0;
            cboMaKH.SelectedIndex = 0;
            
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_PhieuBH et = new ET_PhieuBH(txtMaPhieu.Text, cboMaHang.Text, cboMaKH.Text, dtpNgayMua.Value, dtpHanBH.Value);
            try
            {
                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                else
                {
                    if (_bll.CheckTonTai(et))
                    {
                        MessageBox.Show("Đã tồn tại Phiếu bảo hành này");
                    }
                    else
                    {
                        if (_bll.ThemPhieuBH(et))
                        {
                            MessageBox.Show("Thêm thành công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm không thành công");
                        }
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
                dgvPhieuBH.DataSource = _bll.HienThiDSPhieuBH();
            }
        }

        private void frmPhieuBH_FormClosing(object sender, FormClosingEventArgs e)
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
        private void Reset()
        {
            txtMaPhieu.Text = "";
            cboMaHang.SelectedIndex = 0;
            cboMaKH.SelectedIndex = 0;
            txtMaPhieu.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_PhieuBH et = new ET_PhieuBH(txtMaPhieu.Text, cboMaHang.Text, cboMaKH.Text, dtpNgayMua.Value, dtpHanBH.Value);
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaPhieuBH(et))
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
                dgvPhieuBH.DataSource = _bll.HienThiDSPhieuBH();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_PhieuBH et = new ET_PhieuBH(txtMaPhieu.Text, cboMaHang.Text, cboMaKH.Text, dtpNgayMua.Value, dtpHanBH.Value);
            try
            {
                if (txtMaPhieu.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần Sửa!");
                }
                else
                {
                    if (_bll.SuaPhieuBH(et))
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công");
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
                dgvPhieuBH.DataSource = _bll.HienThiDSPhieuBH();
            }
        }

        private void dgvPhieuBH_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvPhieuBH.CurrentCell.RowIndex;
                txtMaPhieu.Text = dgvPhieuBH.Rows[dong].Cells[0].Value.ToString();
                cboMaHang.Text = dgvPhieuBH.Rows[dong].Cells[1].Value.ToString();
                cboMaKH.Text = dgvPhieuBH.Rows[dong].Cells[2].Value.ToString();
                dtpNgayMua.Text = dgvPhieuBH.Rows[dong].Cells[3].Value.ToString();
                dtpHanBH.Text = dgvPhieuBH.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
