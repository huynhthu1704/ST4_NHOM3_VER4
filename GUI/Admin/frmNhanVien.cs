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
    public partial class frmNhanVien : Form
    {
        private int sTT;
        public frmNhanVien()
        {
            InitializeComponent();
        }

        BLL_NhanVien b = new BLL_NhanVien();
        BLL_BoPhan BP = new BLL_BoPhan();
        /// <summary>
        /// Sự kiện khi bắt đầu form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            Reset();
            cboMaBP.DataSource = BP.LayDS();
            cboMaBP.DisplayMember = "TenBP";
            cboMaBP.ValueMember = "MaBP";
        }

        /// <summary>
        /// Sự kiện trước khi đóng form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
        /// sự kiện khi nhấn nút thêm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string Gt;
            //kiểm tra radio là nam hay nữ
            if (radNam.Checked == true)
            {
                Gt = "Nam";
            }
            else
            {
                Gt = "Nữ";
            }
            try
            {
                //kiểm tra các trường đã nhập đủ dữ liệu chưa
                if (txtCCCD.Text == "" || txtDiaChi.Text == "" || txtHoNV.Text == "" || txtMaNV.Text == "" || txtMaTK.Text == "" || txtSDT.Text == "" || txtTenNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
                else
                {
                    ET_NhanVien NV = new ET_NhanVien(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtSDT.Text, Gt, txtCCCD.Text, Convert.ToDateTime(dtpNS.Text), txtDiaChi.Text, Convert.ToDateTime(dtpNVL.Text), cboMaBP.SelectedValue.ToString(), txtMaTK.Text);
                    //Kiểm tra nhân viên và Tài khoản đã tồn tại chưa
                    if (b.CheckTonTai(NV) == true && b.CheckTonTaiMaTK(txtMaTK.Text) == false)
                    {
                        if (b.CheckTonTai(NV) == true)
                        {
                            MessageBox.Show("Tài khoản đã tồn tại");
                        }
                        if (b.CheckTonTaiMaTK(txtMaTK.Text) == false)
                        {
                            MessageBox.Show("Mã tài khoản không tồn tại");
                        }
                    }
                    else
                    {
                        //Kiểm tra có thêm nhân viên thành công không
                        if (b.ThemNhanVien(NV))
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
            finally
            {
                //Lấy dữ liệu lên DataGirdView
                dvgDS.DataSource = b.LayDS();
            }
        }

        /// <summary>
        /// Sự kiện khi nhấn nút sửa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSua_Click(object sender, EventArgs e)
        {
            string Gt;
            if (radNam.Checked == true)
            {
                Gt = "Nam";
            }
            else
            {
                Gt = "Nữ";
            }
            try
            {
                //Kiểm tra các trường có được nhập đủ không
                if (txtCCCD.Text == "" || txtDiaChi.Text == "" || txtHoNV.Text == "" || txtMaNV.Text == "" || txtMaTK.Text == "" || txtSDT.Text == "" || txtTenNV.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ thông tin");
                }
                else
                {
                    ET_NhanVien NV = new ET_NhanVien(txtMaNV.Text, txtHoNV.Text, txtTenNV.Text, txtSDT.Text, Gt, txtCCCD.Text, Convert.ToDateTime(dtpNS.Text), txtDiaChi.Text, Convert.ToDateTime(dtpNVL.Text), cboMaBP.SelectedValue.ToString(), txtMaTK.Text);

                    if (b.SuaNhanVien(NV) == true)
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
            finally
            {
                //Lấy dữ liệu lên DataGirdView
                dvgDS.DataSource = b.LayDS();
            }
        }

        /// <summary>
        /// sự kiện khi nhấn nút xoá
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaNV.Text;
            try
            {
                //Thông báo có muốn xoá không
                DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    try
                    {
                        if (b.XoaNhanVien(ma) == true)
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
                    finally
                    {
                        //Lấy dữ liệu lên DataGirdView
                        dvgDS.DataSource = b.LayDS();
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
            sTT = b.LayDSGiamDan().Rows.Count != 0 ? int.Parse(b.LayDSGiamDan().Rows[0]["MaNV"].ToString().Substring(2)) + 1 : 1;
            txtMaNV.Text = "NV" + string.Format("{0:00}", sTT);
            dvgDS.DataSource = b.LayDSGiamDan();
            cboMaBP.SelectedIndex = 0;
            txtCCCD.Text = "";
            txtDiaChi.Text = "";
            txtHoNV.Text = "";
            txtMaTK.Text = "";
            txtSDT.Text = "";
            radNam.Checked = true;
            txtTenNV.Text = "";
            dtpNS.ResetText();
            dtpNVL.ResetText();
        }

        /// <summary>
        /// sự kiện khi click vào DataGridView
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaNV.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtHoNV.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
            txtTenNV.Text = dvgDS.Rows[index].Cells[2].Value.ToString();
            txtSDT.Text = dvgDS.Rows[index].Cells[3].Value.ToString();
            if (dvgDS.Rows[index].Cells[4].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            txtCCCD.Text = dvgDS.Rows[index].Cells[5].Value.ToString();
            dtpNS.Text = dvgDS.Rows[index].Cells[6].Value.ToString();
            txtDiaChi.Text = dvgDS.Rows[index].Cells[7].Value.ToString();
            dtpNVL.Text = dvgDS.Rows[index].Cells[8].Value.ToString();
            cboMaBP.SelectedValue = dvgDS.Rows[index].Cells[9].Value.ToString();
            txtMaTK.Text = dvgDS.Rows[index].Cells[10].Value.ToString();
        }
        /// <summary>
        /// sự kiện khi click vào nút thoát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
