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
    public partial class frmKH : Form
    {
        private BLL_KH _bll;
        private int sTT;
        public frmKH()
        {
            InitializeComponent();
            _bll = new BLL_KH();
        }
        BLL_KH KhachHang = new BLL_KH();
        private void frmKH_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            //kiem tra cac control cho dung:
            ET_KH et = new ET_KH(txtMaKH.Text, txtHoTenKH.Text, gt, txtSoDT.Text, txtDiaChi.Text, "");
            try
            {
                if (txtMaKH.Text == "" && txtHoTenKH.Text == "" && txtSoDT.Text == "" && txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                else
                {
                    if (_bll.CheckTonTai(et))
                    {
                        MessageBox.Show("Đã tồn  Khách Hàng này");
                    }
                    else
                    {
                        if (_bll.ThemKH(et))
                        {
                            MessageBox.Show("Thêm thành công");
                            Reset();
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
        }

        private void Reset()
        {
            sTT = _bll.LayDSGiamDan().Rows.Count != 0 ? int.Parse(_bll.LayDSGiamDan().Rows[0]["MaKH"].ToString().Substring(2)) + 1 : 1;
            txtMaKH.Text = "KH" + string.Format("{0:00}", sTT);
            dgvKhachHang.DataSource = _bll.LayDSGiamDan();
            rdbNam.Checked = true;
            txtHoTenKH.Text = "";
            txtSoDT.Text = "";
            txtDiaChi.Text = "";
            txtHoTenKH.Focus();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            //kiem tra cac control cho dung:
            ET_KH et = new ET_KH(txtMaKH.Text, txtHoTenKH.Text, gt, txtSoDT.Text, txtDiaChi.Text,"");
            try
            {
                if (txtMaKH.Text == "")
                {
                    MessageBox.Show("Vui Lòng nhập đủ thông tin cần xóa");
                }
                else
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        if (_bll.XoaKH(et))
                        {
                            MessageBox.Show("Xóa thành công");
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Xóa không thành công");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvKhachHang_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvKhachHang.CurrentCell.RowIndex;
                txtMaKH.Text = dgvKhachHang.Rows[dong].Cells[0].Value.ToString();
                txtHoTenKH.Text = dgvKhachHang.Rows[dong].Cells[1].Value.ToString();
                if (rdbNam.Text == dgvKhachHang.Rows[dong].Cells[2].Value.ToString())
                {
                    rdbNam.Checked = true;
                }
                else
                {
                    rdbNu.Checked = true;
                }
                txtSoDT.Text = dgvKhachHang.Rows[dong].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[dong].Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string gt = "Nam";
            if (rdbNu.Checked == true)
            {
                gt = "Nữ";
            }
            //kiem tra cac control cho dung:
            ET_KH et = new ET_KH(txtMaKH.Text, txtHoTenKH.Text, gt, txtSoDT.Text, txtDiaChi.Text,"");
            try
            {
                if (txtMaKH.Text == "" && txtHoTenKH.Text == "" && txtSoDT.Text == "" && txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần Sửa!");
                }
                else
                {
                    if (_bll.SuaKH(et))
                    {
                        MessageBox.Show("Sửa thành công");
                        Reset();
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
        }

        private void frmKH_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
