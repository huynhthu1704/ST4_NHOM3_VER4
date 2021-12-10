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
        private int STT; // STT để lấy mã số tự động tăng
        public frmLoaiTheKH()
        {
            InitializeComponent();
            _bll = new BLL_LoaiTheKH();
        }

        private void frmLoaiTheKH_Load(object sender, EventArgs e)
        {
            Reset();
        }

        // Sự kiện trước khi đóng form
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

        /// <summary>
        /// Sự kiện khi nhấn nút Thêm
        /// Kiểm tra tên loại thẻ hợp lệ hay không, nếu hợp lệ thì thêm vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Tên thẻ không được trống");
            }
            else
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
                        if (_bll.ThemLoaiTheKH(et))
                        {
                            MessageBox.Show("Thêm thành công");
                            STT++;
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
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Sự kiện khi nhấn nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // khi click vào datagridview thì thông tin hiện lên các field, vì vậy có thể kiểm tra filed có dữ liệu hay chưa để xóa
                if (!string.IsNullOrEmpty(txtTenLoai.Text))
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        ET_LoaiTheKH et = new ET_LoaiTheKH(txtMaLoai.Text, txtTenLoai.Text);
                        if (_bll.XoaLoaiTheKH(et))
                        {
                            MessageBox.Show("Xóa thành công");
                            // Làm lại mã loại thẻ mới
                            STT = _bll.HienThiDS().Rows.Count == 0 ? STT : int.Parse(_bll.HienThiDS().Rows[0]["MaLoaiThe"].ToString().Substring(2)) + 1;
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tài khoản để xóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sự kiện khi nhấn nút Sửa
        // Kiểm tra tên nhập vào có hợp lệ hay không, nếu hợp lệ thì sửa vào CSDL
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTenLoai.Text))
            {
                MessageBox.Show("Tên thẻ không được để trống");
            }
            else
            {
                ET_LoaiTheKH et = new ET_LoaiTheKH(txtMaLoai.Text, txtTenLoai.Text);
                try
                {
                    if (_bll.SuaLoaiTheKH(et))
                    {
                        MessageBox.Show("Sửa thành công");
                        Reset();
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

        // Sự kiện khi nhấn nút Thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Sự kiện khi ckick vào datagridview, hiển thi các dữ liệu tên textbox
        private void dgvDS_Click(object sender, EventArgs e)
        {
            int index = dgvDS.CurrentCell.RowIndex;
            txtMaLoai.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
            txtTenLoai.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
        }

        // Reset control 
        public void Reset()
        {
            // Tính STT dựa trên số thứ tự cũ + 1
            STT = _bll.HienThiDS().Rows.Count == 0 ? 1 : int.Parse(_bll.HienThiDS().Rows[0]["MaLoaiThe"].ToString().Substring(2)) + 1;
            // Set txtMaLoai = LT + STT
            txtMaLoai.Text = "LT" + string.Format("{0:00}", STT);
            dgvDS.DataSource = _bll.HienThiDS();
            txtTenLoai.Text = "";
            txtTenLoai.Focus();
        }

        // Reset các field khi nhấn nút làm mới
        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
