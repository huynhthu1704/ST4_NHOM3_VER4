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
        public frmHangHoa()
        {
            InitializeComponent();
            _bll = new BLL_HangHoa();
        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            cboDVT.DataSource = _bll.HienThiDSDVT();
            cboDVT.DisplayMember = "TenDVT";
            cboDVT.ValueMember = "MaDVT";
            cboDM.DataSource = _bll.HienThiDSDM();
            cboDM.DisplayMember = "TenDM";
            cboDM.ValueMember = "MaDM";
            cboMaKM.DataSource = _bll.HienThiDSKM();
            cboMaKM.DisplayMember = "TenKM";
            cboMaKM.ValueMember = "MaKM";

            dgvHangHoa.DataSource = _bll.HienThiDSHH();
            rdbCo.Checked = true;
            //cboDVT.SelectedIndex = 0;
            //cboDM.SelectedIndex = 0;
            //cboMaKM.SelectedIndex = 0;
            txtMaKM.Visible = false;
            cboMaKM.Visible = false;
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";
            //MessageBox.Show(km);
            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            //MessageBox.Show(et.MaHH);
            //MessageBox.Show(et.TenHH);
            //MessageBox.Show(et.Gia.ToString());
            //MessageBox.Show(et.MaDM);
            //MessageBox.Show(et.DonVT);
            //MessageBox.Show(et.BaoHanh.ToString());
            //MessageBox.Show(et.MaKM);
            try
            {
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
                dgvHangHoa.DataSource = _bll.HienThiDSHH();
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
                } else
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
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            txtGia.Text = "0";
            cboDVT.SelectedIndex = 0;
            cboDM.SelectedIndex = 0;
            cboMaKM.SelectedIndex = 0;
            txtMaHH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";

            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaHH(et))
                    {
                        MessageBox.Show("Xóa thành công");
                        Reset();
                        dgvHangHoa.DataSource = _bll.HienThiDSHH();
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
            int bh = 1;
            if (rdbKhong.Checked == true)
            {
                bh = 0;
            }
            //MessageBox.Show(bh.ToString());
            int gia = CheckGia(txtGia.Text) ? int.Parse(txtGia.Text) : -1;
            string km = radKMCo.Checked == true ? cboMaKM.SelectedValue.ToString() : "";
            ET_HangHoa et = new ET_HangHoa(txtMaHH.Text, txtTenHH.Text, cboDVT.SelectedValue.ToString(), int.Parse(txtGia.Text), cboDM.SelectedValue.ToString(), bh, km);
            try {

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
                        dgvHangHoa.DataSource = _bll.HienThiDSHH();
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
    }
}
