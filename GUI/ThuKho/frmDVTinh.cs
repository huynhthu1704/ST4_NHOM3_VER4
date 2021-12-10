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
using ET;
using BLL;

namespace GUI.ThuKho
{
    public partial class frmDVTinh : Form
    {
        private BLL_DVT _bll;
        private int sTT;
        public frmDVTinh()
        {
            InitializeComponent();
            _bll = new BLL_DVT();
        }

        private void frmDVTinh_Load(object sender, EventArgs e)
        {
            dgvDVT.DataSource = _bll.HienThiDS();
            Reset();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //kiểm tra các control
            ET_DVT et = new ET_DVT(txtMaDVT.Text, txtTenDVT.Text);
            try
            {
                //kiểm tra dữ liệu
                if (txtMaDVT.Text == "" && txtTenDVT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                else
                {
                    //kiểm tra mã
                    if (_bll.CheckTonTai(et))
                    {
                        MessageBox.Show("Đã tồn tại Đơn vị tính này");
                    }
                    else
                    {
                        if (_bll.ThemDVT(et))
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
                //ném lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvDVT_Click(object sender, EventArgs e)
        {
            int index = dgvDVT.CurrentCell.RowIndex;
            txtMaDVT.Text = dgvDVT.Rows[index].Cells[0].Value.ToString();
            txtTenDVT.Text = dgvDVT.Rows[index].Cells[1].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //kiểm tra các control
            ET_DVT et = new ET_DVT(txtMaDVT.Text, txtTenDVT.Text);
            try
            {
                //hiển thị xác nhận
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.XoaDVT(et))
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
                //ném lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //kiểm tra các control
            ET_DVT et = new ET_DVT(txtMaDVT.Text, txtTenDVT.Text);
            try
            {
                //kiểm tra dữ liệu
                if (txtMaDVT.Text == "" && txtTenDVT.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần sửa!");
                }
                else
                {
                    if (_bll.SuaDVT(et))
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
                //ném lỗi
                MessageBox.Show(ex.Message);
            }
        }

        private void frmDVTinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //hiển thij xác nhận
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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reset()
        {
            dgvDVT.DataSource = _bll.HienThiDSGiamDan();
            sTT = _bll.HienThiDSGiamDan().Rows.Count != 0 ? int.Parse(_bll.HienThiDSGiamDan().Rows[0]["MaDVT"].ToString().Substring(3)) + 1 : 1;
            txtMaDVT.Text = "DVT" + string.Format("{0:00}", sTT);
            txtTenDVT.Text = "";
            
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
