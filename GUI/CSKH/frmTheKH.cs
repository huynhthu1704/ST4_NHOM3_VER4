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
    public partial class frmTheKH : Form
    {
        private BLL_TheKH _bll;
        public frmTheKH()
        {
            InitializeComponent();
            _bll = new BLL_TheKH();
        }
        
        private void frmTheKH_Load(object sender, EventArgs e)
        {
            dgvTheKH.DataSource = _bll.HienThiDSTheKH();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            
            //kiem tra cac control cho dung:
            ET_TheKH et = new ET_TheKH(txtMaThe.Text,"", 0, 0);
            try
            {
                if (txtMaThe.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin cần thêm!");
                }
                else
                {
                    if (_bll.CheckTonTai(txtMaThe.Text))
                    {
                        MessageBox.Show("Đã tồn tại thẻ KH này");
                    }
                    else
                    {
                        if (_bll.ThemTheKhachHang(et.MaTheKH))
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
                dgvTheKH.DataSource = _bll.HienThiDSTheKH();
            }
        }
        private void Reset()
        {
            txtMaThe.Text = "";
            txtMaThe.Focus();
        }

        private void dgvTheKH_Click(object sender, EventArgs e)
        {
            try
            {
                //Lay dong vua chon:
                int dong = dgvTheKH.CurrentCell.RowIndex;
                txtMaThe.Text = dgvTheKH.Rows[dong].Cells[0].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int row = dgvTheKH.CurrentCell.RowIndex;
            string maThe = dgvTheKH.Rows[row].Cells[0].Value.ToString();
            //kiem tra cac control cho dung:
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    if (_bll.Xoa(maThe))
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
                dgvTheKH.DataSource = _bll.HienThiDSTheKH();
            }
        }

   
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTheKH_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
