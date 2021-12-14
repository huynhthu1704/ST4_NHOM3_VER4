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


using BLL;
using ET;
namespace GUI.Admin
{
    public partial class frmNCC : Form
    {
        private int sTT;
        public frmNCC()
        {
            InitializeComponent();
        }
        BLL_NCC b = new BLL_NCC();

        // Thêm nhà cung cấp
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Tên nhà cung cấp không được rỗng");
                }
                else
                {
                    if (!CheckSo(txtSDT.Text))
                    {
                        MessageBox.Show("Số điện thoại kh hợp lệ");
                    } else
                    {
                        string ma = txtMa.Text;
                        string ten = txtTen.Text;
                        string diachi = txtDiaChi.Text;
                        string sdt = txtSDT.Text;
                        string email = txtEmail.Text;
                        ET_NCC NCC = new ET_NCC(ma, ten, diachi, sdt, email);
                        if (b.CheckTonTai(NCC) == true)
                        {
                            MessageBox.Show("Nhà Cung Cấp đã tồn tại");
                        }
                        else
                        {
                            if (b.ThemNCC(NCC) == true)
                            {
                                MessageBox.Show("Thêm Thành Công");
                                Reset();
                            }
                            else
                            {
                                MessageBox.Show("Thêm Không Thành Công");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // reset
        private void Reset()
        {
            sTT = b.LayDSGiamDan().Rows.Count != 0 ? int.Parse(b.LayDSGiamDan().Rows[0]["MaNCC"].ToString().Substring(3)) + 1 : 1;
            dgvDS.DataSource = b.LayDSGiamDan();
            txtMa.Text = "NCC" + string.Format("{0:00}", sTT);
            txtSDT.Text = "";
            txtTen.Text = "";
            txtEmail.Text = "";
            txtDiaChi.Text = "";
        }

        // Sự kiện khi nhấn btnXoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTen.Text;
            if (!string.IsNullOrEmpty(tenNCC))
            {
                string ma = txtMa.Text;
                try
                {
                    if (b.XoaNCC(ma) == true)
                    {
                        MessageBox.Show("Xoá Thành Công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Xoá Không Thành Công");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa");
            }

        }

        // Check số
        public bool CheckSo(string so)
        {
            if (string.IsNullOrEmpty(so))
            {
                return false;
            } 
            for (int i = 0; i < so.Length; i++)
            {
                if (!char.IsDigit(so[i]))
                {
                    return false;
                }
            }
            return true;
        }

        // Sự kiện khi nhấn btnSua
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTen.Text))
                {
                    MessageBox.Show("Tên nhà cung cấp không được rỗng");
                }
                else
                {
                    if (!CheckSo(txtSDT.Text))
                    {
                        MessageBox.Show("Số điện thoại không được rỗng");
                    }
                    string ma = txtMa.Text;
                    string ten = txtTen.Text;
                    string diachi = txtDiaChi.Text;
                    string sdt = txtSDT.Text;
                    string email = txtEmail.Text;
                    ET_NCC NCC = new ET_NCC(ma, ten, diachi, sdt, email);

                    if (b.SuaNCC(NCC) == true)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Form load
        private void frmNCC_Load(object sender, EventArgs e)
        {
            Reset();
        }

        // Nhấn btnThoat, thoát khỏi form
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Sự khi khi nhấn vào datagridview
        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDS.CurrentCell.RowIndex;
            txtMa.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDS.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvDS.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvDS.Rows[index].Cells[4].Value.ToString();
        }

        // Sự kiện trước kho đóng form
        private void frmNCC_FormClosing(object sender, FormClosingEventArgs e)
        {
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

        // Nhấn btnMoi
        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
