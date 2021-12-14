//Duc Tri
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
    public partial class frmKhuyenMai : Form
    {
        private int sTT;
        public frmKhuyenMai()
        {
            InitializeComponent();
        }
        BLL_KhuyenMai b = new BLL_KhuyenMai();
        /// <summary>
        /// sự kiện khi bắt đầu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            Reset();
        }
        /// <summary>
        /// Sự kiện khi click vào nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra các trường được nhập đủ chưa
                if (txtGTKM.Text == "" || txtMaKM.Text == "" || txtTenKM.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_KhuyenMai KhuyenMai = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text, int.Parse(txtGTKM.Text), Convert.ToDateTime(dtpBD.Text), Convert.ToDateTime(dtpKT.Text));
                    //Kiểm tra khuyển mãi đã tồn tại chưa
                    if (b.CheckTonTai(KhuyenMai) == true)
                    {
                        MessageBox.Show("Khuyễn Mãi đã tồn tại");
                    }
                    else
                    {
                        //Kiểm tra khuyển mãi có thêm thành công không
                        if (b.ThemKhuyenMai(KhuyenMai) == true)
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

        /// <summary>
        /// Sự kiện khi click nút xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKM.Text;
            //thông báo có muốn xoá Khuyễn mãi không
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    //kiểm tra trường mã đã dc nhập chưa
                    if (ma == "")
                    {
                        MessageBox.Show("vui lòng nhập mã khuyễn mãi");
                    }
                    else
                    {
                        //kiểm tra xoá khuyễn mãi thành công không
                        if (b.XoaKhuyenMai(ma) == true)
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
        /// <summary>
        /// Sự kiện khi click nút sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra các trường được nhập đủ chưa
                if (txtGTKM.Text == "" || txtMaKM.Text == "" || txtTenKM.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_KhuyenMai KhuyenMai = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text, int.Parse(txtGTKM.Text), Convert.ToDateTime(dtpBD.Text), Convert.ToDateTime(dtpKT.Text));
                    //kiểm tra sửa  thành công không                   
                    if (b.SuaKhuyenMai(KhuyenMai) == true)
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
        /// <summary>
        /// sự kiện khi click nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// sự kiện khi click vào DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaKM.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtTenKM.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
            txtGTKM.Text = dvgDS.Rows[index].Cells[2].Value.ToString();
            dtpBD.Text = dvgDS.Rows[index].Cells[3].Value.ToString();
            dtpKT.Text = dvgDS.Rows[index].Cells[4].Value.ToString();
        }
        /// <summary>
        /// Sự kiện trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKhuyenMai_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                //thông báo muốn thoát không
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

        private void Reset()
        {
            dvgDS.DataSource = b.LayDSGiamDan();
            sTT = b.LayDSGiamDan().Rows.Count != 0 ? int.Parse(b.LayDSGiamDan().Rows[0]["MaKM"].ToString().Substring(2)) + 1 : 1;
            txtMaKM.Text = "KM" + string.Format("{0:00}", sTT);
            txtGTKM.Text = "";
            txtTenKM.Text = "";
            dtpBD.ResetText();
            dtpKT.ResetText();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void frmKhuyenMai_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            try
            {
                //Thông báo muốn thoát hay không
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
    }
}
