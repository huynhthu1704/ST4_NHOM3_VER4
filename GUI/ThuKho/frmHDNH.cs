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
        BLL_NCC bllNCC = new BLL_NCC(); // BLL nhà cung cấp
        BLL_NhanVien bllNV = new BLL_NhanVien(); // BLL nhân viên
        BLL_Kho bllKho = new BLL_Kho(); // BLL kho
        BLL_TonKho bllTonKho = new BLL_TonKho(); // BLL tồn kho
        BLL_ChiTietNhapHang bllCTNH = new BLL_ChiTietNhapHang(); // BLL chi tiết nhập hàng
        BLL_HDNH bllHDNH = new BLL_HDNH(); // BLL hóa đơn nhập hàng
        BLL_HangHoa bllHH = new BLL_HangHoa(); // BLL hàng hóa
        int tongTien = 0; // Tổng tiền hóa đơn
        int traTruoc = 0; // Trả trước
        int congNo = 0; // Công nợ
        int STT = 0; // Số thứ tự hàng (để làm tự động tăng)
       
        public frmHDNH()
        {
            InitializeComponent();
            timer.Start(); // bắt đầu timer
        }

        // Sự kiện load form
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Làm mã hóa đơn tự động tăng
            STT = (bllHDNH.HienThiDS().Rows.Count == 0) ? 1 : int.Parse(bllHDNH.HienThiDS().Rows[0]["MaHD"].ToString().Substring(2)) + 1;
            txtMaHD.Text = "HD" + string.Format("{0:000}", STT);
            if (bllNCC.LayDS().Rows.Count != 0)
            {
                // Hiển thị dữ liệu nhà cung cấp lên combobox
                cboNCC.DataSource = bllNCC.LayDS();
                cboNCC.DisplayMember = "TenNCC";
                cboNCC.ValueMember = "MaNCC";
                cboNCC.SelectedIndex = 0;
            }
            if (bllNV.LayDS().Rows.Count != 0)
            {
                // Hiển thị dữ liệu nhân viên lên combobox
                cboNV.DataSource = bllNV.LayDS();
                cboNV.DisplayMember = "HoTen";
                cboNV.ValueMember = "MaNV";
                cboNV.SelectedIndex = 0;
            }
            if (bllKho.LayDS().Rows.Count != 0)
            {
                // Hiển thị dữ liệu kho lên combobox
                cboKho.DataSource = bllKho.LayDS();
                cboKho.DisplayMember = "TenKho";
                cboKho.ValueMember = "MaKho";
                cboKho.SelectedIndex = 0;
            }
            txtMaHH.Focus();
            numericSL.Minimum = 1; // cho giá trị của Số lượng là 1
        }

        // Sự kiện trước khi đóng form
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

        // Khi mã hàng hóa thay đổi, kiểm tra mã hàng có trong csdl hay không, nếu có thì tên được hiện ra txtTenHH
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {

            txtTenHH.Text = "";
            string maHH = txtMaHH.Text;
            try
            {
                if (bllHH.CheckTonTai(maHH))
                {
                    errorProvider1.Clear();
                    DataTable dt = bllHH.LayTT(maHH);
                    txtMaHH.Text = dt.Rows[0]["MaHH"].ToString();
                    txtTenHH.Text = dt.Rows[0]["TenHH"].ToString();
                } else
                {
                    errorProvider1.SetError(txtMaHH, "Chưa tồn tại hàng hóa này");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Khi nhấn btnReset, các trường được trả về như ban đầu load form
        private void btnReset_Click(object sender, EventArgs e)
        {
           // txtMaHD.Text = "HD" + string.Format("{0:000}", STT);
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
            txtTienHang.Text = "";
            txtTienTraTruoc.Text = "";
            txtCongNo.Text = "";
            Reset();
        }

        // Sự kiện khi nhấn btnXoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra người dùng có click vào sản phẩm nào hay không, nếu có thì đưa xác nhân có muốn xóa hay không
                int index = dgvHDNH.CurrentCell.RowIndex;
                if (dgvHDNH.Rows[index].Cells[0].Value != null)
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa hàng hóa này?",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        // Nếu người dùng chọn xóa thì cập nhật lại thông tin giá, số lượng, tiền hàng..
                        int gia = int.Parse(dgvHDNH.Rows[index].Cells[3].Value.ToString());
                        int soLuong = int.Parse(dgvHDNH.Rows[index].Cells[2].Value.ToString());
                        int tienHang = gia * soLuong;
                        tongTien -= tienHang;
                        // Xóa sp tại hàng được chọn
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

        // Sự kiện khi nhấn btnHuy
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

        // Check giá nhập vào có hợp lệ hay không
        // Nếu giá rỗng hoặc có chứ ký tự hay chữ cái đặc biệt thì trả về false
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

        public int CheckCoHH(string maHH, string maKho)
        {
            if (dgvHDNH.Rows.Count > 1)
            {
                for (int i = 0; i < dgvHDNH.Rows.Count - 1; i++)
                {
                    if (dgvHDNH.Rows[i].Cells[0].Value.ToString().CompareTo(maHH) == 0 &&
                        dgvHDNH.Rows[i].Cells[4].Value.ToString().CompareTo(maKho) == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        /// <summary>
        /// Sự kiện khi nhấm vào
        /// Kiểm tra dữ liệu trước khi thêm, nếu hợp lệ thì thêm datagridview, đồng thời thay đổi thông tin đơn hàng
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSP = txtMaHH.Text; // mã hàng hóa
            string tenSP = txtTenHH.Text; // tên hàng hóa
            int sL = (int)numericSL.Value; // số lượng
            int gia = CheckGia(txtGia.Text) ? int.Parse(txtGia.Text) : 0; // giá 
            string maKho = cboKho.SelectedValue.ToString(); // mã kho
            try
            {
                if (bllHH.CheckTonTai(maSP)) // Check hàng hóa có tồn tại hay không
                {
                    if (gia != 0)
                    {
                        tongTien += gia * sL; // tính tổng tiền
                        txtTienHang.Text = tongTien.ToString(); // tiền hàng
                        txtTienTraTruoc.Text = traTruoc.ToString(); // tiền trả trước
                        congNo = tongTien - traTruoc;
                        txtCongNo.Text = congNo.ToString(); // tiền công nợ
                        if (CheckCoHH(maSP, maKho) != -1)
                        {
                            int row = CheckCoHH(maSP,maKho);
                            int slCu = int.Parse(dgvHDNH.Rows[row].Cells[2].Value.ToString());
                            dgvHDNH.Rows[row].Cells[2].Value = sL + slCu; // thêm vào csdl
                            
                        } else
                        {
                            dgvHDNH.Rows.Add(maSP, tenSP, sL, gia, maKho); // thêm vào csdl
                        }
                        Reset();
                    }
                    else
                    {
                        MessageBox.Show("Giá không hợp lệ");
                    }
                }
                else if (string.IsNullOrEmpty(maSP))
                {
                    MessageBox.Show("Vui lòng nhập thông tin sản phẩm");
                } else
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

        /// <summary>
        /// Lưu hóa đơn
        /// Kiểm tra các trường dữ liệu các nhập đủ hay chưa, nếu đủ thì thêm vào csdl
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLuuHoaDon_Click(object sender, EventArgs e)
        {
            string maHD = txtMaHD.Text;
            string nCC = cboNCC.SelectedValue.ToString();
            string maNV = cboNV.SelectedValue.ToString();
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
                            if (traTruoc > tongTien)
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
                                    int sL = int.Parse(dgvHDNH.Rows[i].Cells[2].Value?.ToString());
                                    int gia = int.Parse(dgvHDNH.Rows[i].Cells[3].Value?.ToString());
                                    int thanhTien = sL * gia;
                                    string maKho = dgvHDNH.Rows[i].Cells[4].Value?.ToString();
                                    ET_ChiTietNH etChiTiet = new ET_ChiTietNH(maHD, maHH, sL, gia, thanhTien, maKho);
                                    if (!bllCTNH.ThemCTNH(etChiTiet))
                                    {
                                        kq = false;
                                    }
                                    else
                                    {
                                        STT++;
                                        // Nếu hàng hóa đã tồn tại thì cập nhật số lượng mới cho tồn kho
                                        if (bllTonKho.CheckTonTaiTheoKho(maHH, maKho))
                                        {
                                            sLTonKho = bllTonKho.LaySL(maHH, maKho) + sL;
                                            bllTonKho.SuaTonKho(new ET_TonKho(maHH, maKho, sLTonKho));
                                        }
                                        else // ngược lại thì thêm mới
                                        {
                                            sLTonKho = sL;
                                            bllTonKho.ThemTonKho(new ET_TonKho(maHH, maKho, sL));
                                        }
                                    }
                                }
                                if (kq) // nếu thêm thành công thì reset các fields
                                {
                                    MessageBox.Show("Thêm thành công");
                                   
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

        // Sự kiện khi click vào datagridview, hiển thi thông tin lên các fields
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

        // Sự kiện khi nhấn nút Sửa, kiểm tra thông tin có hợp lệ hay chưa
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

        // Làm mới các fields
        public void Reset()
        {
            txtMaHD.Text = "HD" + string.Format("{0:000}", STT);
            txtMaHH.Text = "";
            txtMaHH.Focus();
            txtTenHH.Text = "";
            numericSL.Value = 1;
            txtGia.Text = "";
            if (bllKho.LayDS().Rows.Count != 0)
            {
                cboKho.DataSource = bllKho.LayDS();
                cboKho.SelectedIndex = 0;
            }
            errorProvider1.Clear();
        }

        // Sự kiện khi nhấn btnQuayVe
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
         
        // Timer tick thì thay đổi thời gian trên màn hình
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            lblTime.Text = time.ToString("dd/MM/yyyy HH:mm:ss");
        }
         

        // Sự kiện khi txtTienTraTruoc thay đổi, tính tiền công nợ
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

    }
}
