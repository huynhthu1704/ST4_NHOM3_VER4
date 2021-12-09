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

        // Sự kiện load form
        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            // Khởi tạo mã tự động tăng
            STT = _bll.HienThiDS().Rows.Count == 0 ? 1 : int.Parse(_bll.HienThiDS().Rows[0]["MaTK"].ToString().Substring(2)) + 1;
            txtMaTK.Text = "TK" + string.Format("{0:00}", STT);
            // Hiển thị dữ liệu lên datagridview và combobox
            dgvTaiKhoan.DataSource = _bll.HienThiDS();
            cboLoaiTK.DataSource = _bll.HienThiLTK();
            cboLoaiTK.DisplayMember = "TenLoaiTK";
            cboLoaiTK.ValueMember = "MaLoaiTK";
            cboLoaiTK.SelectedIndex = 0;
        }

        // Sự kiện trước khi đóng form
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

        /// <summary>
        /// Sự kiện khi nhấn nút thêm
        /// Kiểm tra tài khoản có tồn tại hay chưa, nếu tồn tai đưa ra thông báo, ngược lại thêm vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrEmpty(txtMK.Text)) {
                MessageBox.Show("Tên đăng nhập / Mật khẩu không được trống");
            } else {
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
           
        }

        // Sự kiện khi nhấn nút Xóa, xác nhận người dùng có muốn xóa hay không
        // Nếu xóa thành công thì thông báo ra màn hình
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

        // Sự kiện khi nhấn nút sửa, xác nhận thông tin đầy đủ thì sửa vào csdl
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenDN.Text) || string.IsNullOrEmpty(txtMK.Text)) {
                MessageBox.Show("Tên đăng nhập / Mật khẩu không được trống");
            }
            else
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
        }

        // Đóng chương trình khi người dùng nhấn btnThoat
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Reset các field
        public void Reset()
        {
            txtMaTK.Text = "";
            txtTenDN.Text = "";
            txtMK.Text = "";
            cboLoaiTK.SelectedIndex = 0;
            txtMaTK.Text = "TK" + string.Format("{0:00}", STT);
        }

        // Hiển thi dữ liệu các fields khi click vào datagrid view
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
