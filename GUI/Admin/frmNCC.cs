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
        public frmNCC()
        {
            InitializeComponent();
        }
        BLL_NCC b = new BLL_NCC();
        private void btnThem_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            ET_NCC NCC = new ET_NCC(ma, ten, diachi, sdt, email);
            try
            {
                if (b.CheckTonTai(NCC) == true)
                {
                    MessageBox.Show("Nhà Cung Cấp đã tồn tại");
                }
                else
                {
                    if (b.ThemNCC(NCC) == true)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        txtMa.Text = "";
                        txtSDT.Text = "";
                        txtTen.Text = "";
                        txtEmail.Text = "";
                        txtDiaChi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Thêm Không Thành Công");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvDS.DataSource = b.LayDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            try
            {
                if (b.XoaNCC(ma) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    txtMa.Text = "";
                    txtSDT.Text = "";
                    txtTen.Text = "";
                    txtEmail.Text = "";
                    txtDiaChi.Text = "";
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
            finally
            {
                dgvDS.DataSource = b.LayDS();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string ma = txtMa.Text;
            string ten = txtTen.Text;
            string diachi = txtDiaChi.Text;
            string sdt = txtSDT.Text;
            string email = txtEmail.Text;
            ET_NCC NCC = new ET_NCC(ma, ten, diachi, sdt, email);
            try
            {
                    if (b.SuaNCC(NCC) == true)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        txtMa.Text = "";
                        txtSDT.Text = "";
                        txtTen.Text = "";
                        txtEmail.Text = "";
                        txtDiaChi.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Sửa Không Thành Công");
                    }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dgvDS.DataSource = b.LayDS();
            }
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            dgvDS.DataSource = b.LayDS();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDS.CurrentCell.RowIndex;
            txtMa.Text = dgvDS.Rows[index].Cells[0].Value.ToString();
            txtTen.Text = dgvDS.Rows[index].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvDS.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dgvDS.Rows[index].Cells[3].Value.ToString();
            txtEmail.Text = dgvDS.Rows[index].Cells[4].Value.ToString();
        }

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
    }
}
