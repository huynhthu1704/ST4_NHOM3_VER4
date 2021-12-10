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
    public partial class frmBoPhan : Form
    {
        private int sTT;
        public frmBoPhan()
        {
            InitializeComponent();
        }
        BLL_BoPhan bBoPhan = new BLL_BoPhan();
        private void btnThem_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtMaBP.Text == ""  || txtSDT.Text == "" || txtTenBP.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
                else
                {
                    string maBP = txtMaBP.Text;
                    string tenBP = txtTenBP.Text;
                    string sDT = string.IsNullOrEmpty(txtSDT.Text) ? "" : txtSDT.Text;
                    string maQL = string.IsNullOrEmpty(txtMaQL.Text) ? "" : txtMaQL.Text;
                    ET_BoPhan BoPhan = new ET_BoPhan(maBP, tenBP, sDT, maQL);
                    if (bBoPhan.CheckTonTai(BoPhan))
                    {
                        MessageBox.Show("Đã tồn tại bộ phận này");
                    }
                    else
                    {
                        if (bBoPhan.ThemBoPhan(BoPhan) == true)
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
            string ma = txtMaBP.Text;
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    if (bBoPhan.XoaBoPhan(ma) == true)
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
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtMaBP.Text == "" || txtSDT.Text == "" || txtTenBP.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
                else
                {
                    ET_BoPhan BoPhan = new ET_BoPhan(txtMaBP.Text, txtTenBP.Text, txtSDT.Text, txtMaQL.Text);
                    if (bBoPhan.SuaBoPhan(BoPhan) == true)
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

        private void frmBoPhan_Load(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            dvgDS.DataSource = bBoPhan.LayDSGiamDan();
            sTT = bBoPhan.LayDSGiamDan().Rows.Count != 0 ? int.Parse(bBoPhan.LayDSGiamDan().Rows[0]["MaBP"].ToString().Substring(2)) + 1 : 1;
            txtMaBP.Text = "BP" + string.Format("{0:00}", sTT);
            txtMaQL.Text = "";
            txtSDT.Text = "";
            txtTenBP.Text = "";
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmBoPhan_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaBP.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtTenBP.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
            txtSDT.Text = dvgDS.Rows[index].Cells[2].Value.ToString();
            txtMaQL.Text = dvgDS.Rows[index].Cells[3].Value.ToString();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
