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
            rdbChuaKH.Checked = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tinhTrang = 0;
            if (rdbDaKH.Checked == true)
            {
                tinhTrang = 1;
            }

            //kiem tra cac control cho dung:
            ET_TheKH et = new ET_TheKH(txtMaThe.Text,"", tinhTrang, 0);
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
                        if (_bll.ThemTheKhachHang(et.MaTheKH, et.TinhTrang))
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
            rdbChuaKH.Checked = true;
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

        private void btnSua_Click(object sender, EventArgs e)
        {
            int tinhTrang = 0;
            if (rdbDaKH.Checked == true)
            {
                tinhTrang = 1;
            }
            ET_TheKH et = new ET_TheKH(txtMaThe.Text, "", tinhTrang, 0);
            try
            {
                if (txtMaThe.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin !");
                }
                else
                {
                    if (_bll.SuaTinhTrangThe(txtMaThe.Text, tinhTrang))
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
                dgvTheKH.DataSource = _bll.HienThiDSTheKH();
            }
        }
    }
}
