// Đức Trí

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
    public partial class frmKho : Form
    {
        private int sTT;
        public frmKho()
        {
            InitializeComponent();
        }
        BLL_Kho bKho = new BLL_Kho();
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKho.Text == "" || txtTenKho.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                    if (bKho.CheckTonTai(Kho) == true)
                    {
                        MessageBox.Show("Kho đã tồn tại");
                    }
                    else
                    {
                        if (bKho.ThemKho(Kho) == true)
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    if (ma == "")
                    {
                        MessageBox.Show("Vui lòng nhập Mã kho");
                    }
                    else
                    {
                        ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                        if (bKho.XoaKho(ma) == true)
                        {
                            MessageBox.Show("Xoá Thành Công");
                            Reset();
                        }
                        else
                        {
                            MessageBox.Show("Xoá Không Thành Công");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaKho.Text == "" || txtTenKho.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                    if (bKho.SuaKho(Kho) == true)
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

        private void Reset()
        {
            dvgDS.DataSource = bKho.LayDSGiamDan();
            sTT = bKho.LayDSGiamDan().Rows.Count != 0 ? int.Parse(bKho.LayDSGiamDan().Rows[0]["MaKho"].ToString().Substring(2)) + 1 : 1;
            txtMaKho.Text = "K" + string.Format("{0:00}", sTT);
            txtTenKho.Text = "";
            txtTenKho.Focus();
        }
        private void frmKho_Load(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmKho_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Close();
        }

        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaKho.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtTenKho.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
