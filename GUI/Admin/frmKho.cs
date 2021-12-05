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
        public frmKho()
        {
            InitializeComponent();
        }
        BLL_Kho bKho = new BLL_Kho();
        private void btnThem_Click(object sender, EventArgs e)
        {
            ET_Kho Kho = new ET_Kho(txtMaKho.Text,txtTenKho.Text);

            try
            {
                if (bKho.CheckTonTai(Kho) == true)
                {
                    MessageBox.Show("Kho đã tồn tại");
                }
                else
                {
                    if (bKho.ThemKho(Kho) == true)
                    {
                        MessageBox.Show("Thêm Thành Công");
                        txtMaKho.Text = "";
                        txtTenKho.Text = "";
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
                dvgDS.DataSource = bKho.LayDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            try
            {
                if (bKho.XoaKho(ma) == true)
                {
                    MessageBox.Show("Xoá Thành Công");
                    txtMaKho.Text = "";
                    txtTenKho.Text = "";
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
                dvgDS.DataSource = bKho.LayDS();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);

            try
            {
                if (bKho.SuaKho(Kho) == true)
                {
                    MessageBox.Show("Sửa Thành Công");
                    txtMaKho.Text = "";
                    txtTenKho.Text = "";
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
                dvgDS.DataSource = bKho.LayDS();
            }
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            dvgDS.DataSource = bKho.LayDS();
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
    }
}
