///DucTri
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
        /// <summary>
        /// Sự kiện khi click vào nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra các trường có bỏ trống hay không
                if (txtMaKho.Text == "" || txtTenKho.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                    //kiểm tra Kho đẵ tồn tại chưa
                    if (bKho.CheckTonTai(Kho) == true)
                    {
                        MessageBox.Show("Kho đã tồn tại");
                    }
                    else
                    {
                        //kiểm tra Kho có thêm được không
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Lấy dữ liệu lên DataGirdView
                dvgDS.DataSource = bKho.LayDS();
            }
        }
        /// <summary>
        /// Sự kiện khi click vào nút xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKho.Text;
            //Thông báo có muốn xoá hay không
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    //kiểm tra trường mã được nhập chưa
                    if (ma == "")
                    {
                        MessageBox.Show("Vui lòng nhập Mã kho");
                    }
                    else
                    {
                        ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                        //kiểm tra có xoá được Kho không
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
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    //Lấy dữ liệu lên DataGirdView
                    dvgDS.DataSource = bKho.LayDS();
                }
            }
            else
            {

            }
        }

        /// <summary>
        /// Sự kiện khi click vào nút Sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                //kiểm tra các trường được nhập đủ hay chưa
                if (txtMaKho.Text == "" || txtTenKho.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_Kho Kho = new ET_Kho(txtMaKho.Text, txtTenKho.Text);
                    //kiểm tra Kho có được sửa chưa
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Lấy dữ liệu lên DataGirdView
                dvgDS.DataSource = bKho.LayDS();
            }
        }

        /// <summary>
        /// sự kiện khi bắt đầu mở form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKho_Load(object sender, EventArgs e)
        {
            dvgDS.DataSource = bKho.LayDS();
        }
        /// <summary>
        /// sự kiện trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmKho_FormClosing(object sender, FormClosingEventArgs e)
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
        /// <summary>
        /// sự kiện khi nhấn nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Sự kiện khi click vào DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaKho.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtTenKho.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
        }
    }
}
