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

namespace GUI.ThuKho
{
    public partial class frmHangHoa : Form
    {
        private BLL_HangHoa _bll;
        private int sTT;
        public frmHangHoa()
        {
            InitializeComponent();
            _bll = new BLL_HangHoa();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            Reset();
            //hiênr thị ds dvt
            cboDVT.DataSource = _bll.HienThiDSDVT();
            cboDVT.DisplayMember = "TenDVT";
            cboDVT.ValueMember = "MaDVT";
            //hien thị ds dmhh
            cboDM.DataSource = _bll.HienThiDSDM();
            cboDM.DisplayMember = "TenDM";
            cboDM.ValueMember = "MaDM";
            //hiện thị ds km
            cboMaKM.DataSource = _bll.HienThiDSKM();
            cboMaKM.DisplayMember = "TenKM";
            cboMaKM.ValueMember = "MaKM";

            dgvHangHoa.DataSource = _bll.HienThiDSHH();
            rdbCo.Checked = true;
            Reset();
            txtMaKM.Visible = false;
            cboMaKM.Visible = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra bảo hành
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            //kiểm tra km
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";
            //kiểm tra control
            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            try
            {
                //kiểm tra dữ liệu
                if (txtMaHH.Text == "" || txtTenHH.Text == "" || txtGia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                else
                {
                    if (_bll.CheckTonTai(txtMaHH.Text))
                    {
                        MessageBox.Show("Đã tồn tại Hàng Hóa này");
                    }
                    else
                    {
                        if (_bll.ThemHH(et))
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

        private void dgvHangHoa_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvHangHoa.CurrentCell.RowIndex;
                txtMaHH.Text = dgvHangHoa.Rows[dong].Cells[0].Value.ToString();
                txtTenHH.Text = dgvHangHoa.Rows[dong].Cells[1].Value.ToString();
                cboDVT.Text = dgvHangHoa.Rows[dong].Cells[2].Value.ToString();
                txtGia.Text = dgvHangHoa.Rows[dong].Cells[3].Value.ToString();
                cboDM.Text = dgvHangHoa.Rows[dong].Cells[4].Value.ToString();
                MessageBox.Show(dgvHangHoa.Rows[dong].Cells[5].Value.ToString());
                if (dgvHangHoa.Rows[dong].Cells[5].Value.ToString() == "True")
                {
                    rdbCo.Checked = true;
                }
                else
                {
                    rdbKhong.Checked = true;
                }
                if (string.IsNullOrEmpty(dgvHangHoa.Rows[dong].Cells[6].Value.ToString()))
                {
                    radKMKhong.Checked = true;
                }
                else
                {
                    radKMCo.Checked = true;
                    cboMaKM.Text = dgvHangHoa.Rows[dong].Cells[6].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }
        private void Reset()
        {
            dgvHangHoa.DataSource = _bll.HienThiDSHH();
            sTT = _bll.HienThiDSHH().Rows.Count != 0 ? int.Parse(_bll.HienThiDSHH().Rows[0]["MaHH"].ToString().Substring(2)) + 1 : 1;
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtGia.Text = "0";
            //cboDM.SelectedIndex = 0;
            //cboDVT.SelectedIndex = 0;
            //cboMaKM.SelectedIndex = 0;
            txtMaHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra bh
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            //kiểm tra km
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";
            //kiểm tra control
            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            try
            {
                //hiển thị xác nhận
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaHH(et))
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckGia(string gia)
        {
            for (int i = 0; i < gia.Length; i++)
            {
                if (!char.IsDigit(gia[i]))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //kiểm tra bh
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            //kiểm tra km
            int gia = CheckGia(txtGia.Text) ? int.Parse(txtGia.Text) : -1;
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";
            //kiểm tra control
            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            try
            {
                //kiểm tra dữ liệu
                if (txtMaHH.Text == "" || txtTenHH.Text == "" || gia == -1)
                {
                    MessageBox.Show("Vui Lòng Nhập Đủ Thông Tin Cần Sửa !");
                }
                else
                {
                    if (_bll.SuaHH(et))
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

        private void frmHangHoa_FormClosing(object sender, FormClosingEventArgs e)
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

        private void radKMCo_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKM.Visible = true;
            cboMaKM.Visible = true;
        }

        private void radKMKhong_CheckedChanged(object sender, EventArgs e)
        {
            txtMaKM.Visible = false;
            cboMaKM.Visible = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
