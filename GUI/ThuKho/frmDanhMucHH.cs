//Thanh  Quốc
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
    public partial class frmDanhMucHH : Form
    {
        private BLL_DanhMucHH _bll;
        private int sTT;
        public frmDanhMucHH()
        {
            InitializeComponent();
            _bll = new BLL_DanhMucHH();
        }

        private void frmDanhMucHH_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_DanhMucHH et = new ET_DanhMucHH(txtMaDM.Text, txtTenDM.Text);
            try
            {
                if (_bll.CheckTonTai(et))
                {
                    MessageBox.Show("Đã tồn tại Danh Mục này");
                }
                else
                {
                    if (txtMaDM.Text == "" && txtTenDM.Text == "")
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin Cần Thêm!");
                    }
                    else
                    {
                        if (_bll.ThemDM(et))
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
            dgvDanhMucHH.DataSource = _bll.HienThiDSGiamDan();
            sTT = _bll.HienThiDSGiamDan().Rows.Count != 0 ? int.Parse(_bll.HienThiDSGiamDan().Rows[0]["MaDM"].ToString().Substring(2)) + 1 : 1;
            txtMaDM.Text = "DM" + string.Format("{0:00}", sTT);
            txtTenDM.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            ET_DanhMucHH et = new ET_DanhMucHH(txtMaDM.Text, txtTenDM.Text);
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaDM(et))
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

        private void dgvDanhMucHH_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvDanhMucHH.CurrentCell.RowIndex;
                txtMaDM.Text = dgvDanhMucHH.Rows[dong].Cells[0].Value.ToString();
                txtTenDM.Text = dgvDanhMucHH.Rows[dong].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_DanhMucHH et = new ET_DanhMucHH(txtMaDM.Text, txtTenDM.Text);
            try
            {
                if (txtMaDM.Text == "" && txtTenDM.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin Cần sửa Thêm!");
                }
                else
                {
                    if (_bll.SuaDM(et))
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

        private void frmDanhMucHH_FormClosing(object sender, FormClosingEventArgs e)
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
