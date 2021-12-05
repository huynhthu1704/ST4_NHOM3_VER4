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
using System.Globalization;
using ET;
using BLL;

namespace GUI.ThuKho
{
    public partial class frmHDNH : Form
    {
        BLL_NCC bllNCC = new BLL_NCC();
        BLL_NhanVien bllNV = new BLL_NhanVien();
        BLL_Kho bllKho = new BLL_Kho();
        BLL_TonKho bllTonKho = new BLL_TonKho();
        BLL_ChiTietNhapHang bllCTNH = new BLL_ChiTietNhapHang();
        BLL_HDNH bllHDNH = new BLL_HDNH();
        BLL_HangHoa bllHH = new BLL_HangHoa();
        int tongTien = 0;
        int traTruoc = 0;
        int congNo = 0;
        int STT = 0;
        public frmHDNH()
        {
            InitializeComponent();
            timer.Start();
        }


        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            STT = (bllHDNH.HienThiDS().Rows.Count == 0) ? 1 : int.Parse(bllHDNH.HienThiDS().Rows[0]["MaHD"].ToString().Substring(2)) + 1;
            MessageBox.Show(STT.ToString());
            txtMaHD.Text = "HD" + string.Format("{0:000}", STT);
            if (bllNCC.LayDS().Rows.Count != 0)
            {
                cboNCC.DataSource = bllNCC.LayDS();
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
                cboNCC.SelectedIndex = 0;
            }
            if (bllNV.LayDS().Rows.Count != 0)
            {
                cboNV.DataSource = bllNV.LayDS();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";
                cboNV.SelectedIndex = 0;
            }
            if (bllKho.LayDS().Rows.Count != 0)
            {
                cboKho.DataSource = bllKho.LayDS();
                cboKho.DisplayMember = "TenKho";
                cboKho.ValueMember = "MaKho";
                cboKho.SelectedIndex = 0;
            }
            numericSL.Minimum = 1;
        }

        private void frmHDNH_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

            txtTenHH.Text = "";
            string maHH = txtMaHH.Text;
            try
            {
                if (bllHH.CheckTonTai(maHH))
                {
                    DataTable dt = bllHH.LayTT(maHH);
                    txtTenHH.Text = dt.Rows[0]["TenHH"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "HD" + string.Format("{0:000}", STT);
            dgvHDNH.Rows.Clear();
            tongTien = 0;
            txtMaHD.Text = "";
            if (bllNCC.LayDS().Rows.Count != 0)
            {
                cboNCC.DataSource = bllNCC.LayDS();
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
                cboNCC.SelectedIndex = 0;
            }
            if (bllNV.LayDS().Rows.Count != 0)
            {
                cboNV.DataSource = bllNV.LayDS();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";
                cboNV.SelectedIndex = 0;
            }
            Reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHDNH.CurrentCell.RowIndex;
                if (dgvHDNH.Rows[index].Cells[0].Value != null)
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa hàng hóa này?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        int gia = int.Parse(dgvHDNH.Rows[index].Cells[3].Value.ToString());
                        int soLuong = int.Parse(dgvHDNH.Rows[index].Cells[2].Value.ToString());
                        int tienHang = gia * soLuong;
                        tongTien -= tienHang;
                        dgvHDNH.Rows.RemoveAt(index);
                        Reset();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hàng hóa");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult kq = MessageBox.Show("Bạn có muốn ngừng nhập?", "Thông báo",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (kq == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool CheckGia(string gia)
        {
            if (string.IsNullOrEmpty(gia))
                return false;
            for (int i = 0; i < gia.Length; i++)
            {
                if (!char.IsDigit(gia[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaHH.Text;
            string tenSP = txtTenHH.Text;
            int sL = (int)numericSL.Value;
            int gia = CheckGia(txtGia.Text) ? int.Parse(txtGia.Text) : 0;
            string maKho = cboKho.SelectedValue.ToString();
            try
            {
                if (bllHH.CheckTonTai(maSP))
                {
                    if (gia != 0)
                    {
                        tongTien += gia * sL;
                        txtTienHang.Text = tongTien.ToString();
                        txtTienTraTruoc.Text = traTruoc.ToString();
                        txtCongNo.Text = congNo.ToString();
                        dgvHDNH.Rows.Add(maSP, tenSP, sL, gia, maKho);
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Giá không hợp lệ");
                    }
                }
                else
                {
                    DialogResult kq = MessageBox.Show("Chưa có thông tin liên quan đến hàng hóa này, bạn có muốn thêm hàng hóa?",
                         "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        frmHangHoa frm = new frmHangHoa();
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string nCC = cboNCC.SelectedValue.ToString();
            string maNV = cboNV.SelectedValue.ToString();
            traTruoc = CheckGia(txtTienTraTruoc.Text) ? int.Parse(txtTienTraTruoc.Text) : 0;
            congNo = int.Parse(txtCongNo.Text);
            try
            {
                if (bllHDNH.CheckTonTai(maHD))
                {
                    MessageBox.Show("Đã tồn tại hóa đơn này");
                }
                else
                {
                    if (string.IsNullOrEmpty(maHD))
                    {
                        MessageBox.Show("Mã hóa đơn trống");
                    }
                    else
                    {
                        int count = dgvHDNH.Rows.Count;
                        if (count == 1)
                        {
                            MessageBox.Show("Không có hàng hóa để nhập");
                        }
                        else
                        {
                            if (traTruoc > congNo)
                            {
                                MessageBox.Show("Tiền trả trước lớn hơn tổng tiền sản phẩm");
                            }
                            else
                            {
                                bool kq = true;
                                ET_HDNH et = new ET_HDNH(maHD, nCC, maNV, DateTime.Now, tongTien, traTruoc, congNo);
                                bllHDNH.ThemHDNH(et);
                                for (int i = 0; i < count - 1; i++)
                                {
                                    int sLTonKho = 0;
                                    string maHH = dgvHDNH.Rows[i].Cells[0].Value?.ToString();
                                    MessageBox.Show(maHH + "1");
                                    int sL = int.Parse(dgvHDNH.Rows[i].Cells[2].Value?.ToString());
                                    int gia = int.Parse(dgvHDNH.Rows[i].Cells[3].Value?.ToString());
                                    int thanhTien = sL * gia;
                                    string maKho = dgvHDNH.Rows[i].Cells[4].Value?.ToString();
                                    MessageBox.Show(maKho + "1");
                                    ET_ChiTietNH etChiTiet = new ET_ChiTietNH(maHD, maHH, sL, gia, thanhTien, maKho);
                                    if (!bllCTNH.ThemCTNH(etChiTiet))
                                    {
                                        kq = false;
                                    }
                                    else
                                    {
                                        if (bllTonKho.CheckTonTaiTheoKho(maHH, maKho))
                                        {
                                            sLTonKho = bllTonKho.LaySL(maHH, maKho) + sL;
                                            bllTonKho.SuaTonKho(new ET_TonKho(maHH, maKho, sLTonKho));
                                        }
                                        else
                                        {
                                            sLTonKho = sL;
                                            bllTonKho.ThemTonKho(new ET_TonKho(maHH, maKho, sL));
                                        }
                                    }
                                }
                                if (kq)
                                {
                                    MessageBox.Show("Thêm thành công");
                                    STT++;
                                    btnReset_Click(null, null);
                                }
                                else
                                {
                                    MessageBox.Show("Thêm không thành công");
                                }
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

        private void dgvHDNH_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHDNH.CurrentCell != null)
                {
                    int index = dgvHDNH.CurrentCell.RowIndex;
                    txtMaHH.Text = dgvHDNH.Rows[index].Cells[0].Value != null ? dgvHDNH.Rows[index].Cells[0].Value.ToString() : "";
                    txtTenHH.Text = dgvHDNH.Rows[index].Cells[1].Value != null ? dgvHDNH.Rows[index].Cells[1].Value.ToString() : "";
                    numericSL.Text = dgvHDNH.Rows[index].Cells[2].Value != null ? dgvHDNH.Rows[index].Cells[2].Value.ToString() : 0.ToString();
                    txtGia.Text = dgvHDNH.Rows[index].Cells[3].Value != null ? dgvHDNH.Rows[index].Cells[3].Value.ToString() : "";
                    cboKho.Text = dgvHDNH.Rows[index].Cells[4].Value != null ? dgvHDNH.Rows[index].Cells[4].Value.ToString() : "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvHDNH.CurrentCell.RowIndex;
                string maSPDGV = dgvHDNH.Rows[index].Cells[0].Value != null ? dgvHDNH.Rows[index].Cells[0].Value.ToString() : "";
                string maSP = txtMaHH.Text;
                if (maSPDGV.CompareTo(maSP) != 0)
                {
                    DialogResult kq = MessageBox.Show("Mã sản phẩm đã bị thay đổi, bạn muốn thêm hàng hóa mới?", "Thông báo",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        btnThem_Click(null, EventArgs.Empty);
                    }
                }
                else
                {
                    string tenSP = txtTenHH.Text;
                    int sL = (int)numericSL.Value;
                    int gia = CheckGia(txtGia.Text) ? int.Parse(txtGia.Text) : 0;
                    string maKho = cboKho.SelectedValue.ToString();
                    dgvHDNH.Rows[index].Cells[0].Value = maSP;
                    dgvHDNH.Rows[index].Cells[1].Value = tenSP;
                    dgvHDNH.Rows[index].Cells[2].Value = sL;
                    dgvHDNH.Rows[index].Cells[3].Value = gia;
                    dgvHDNH.Rows[index].Cells[4].Value = maKho;
                    Reset();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void Reset()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            numericSL.Value = 1;
            txtGia.Text = "";
            if (bllKho.LayDS().Rows.Count != 0)
            {
                cboKho.DataSource = bllKho.LayDS();
                cboKho.SelectedIndex = 0;
            }
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void txtTienTraTruoc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                traTruoc = CheckGia(txtTienTraTruoc.Text) ? int.Parse(txtTienTraTruoc.Text) : 0;
                if (traTruoc > tongTien)
                {
                    MessageBox.Show("Tiền trả trước lớn hơn tổng tiền sp");
                    congNo = 0;
                }
                else
                {
                    congNo = tongTien - traTruoc;
                }
                txtCongNo.Text = congNo.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHDNH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
