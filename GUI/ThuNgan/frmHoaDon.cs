//Ngọc Thư
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

namespace GUI.ThuNgan
{
    public partial class frmHoaDon : Form
    {
        BLL_NhanVien bllNV = new BLL_NhanVien();
        BLL_HangHoa bllHH = new BLL_HangHoa();
        BLL_KhuyenMai bllKM = new BLL_KhuyenMai();
        BLL_TonKho bllTonKho = new BLL_TonKho();
        BLL_TheKH bllTheKH = new BLL_TheKH();
        BLL_HoaDon bllHoaDon = new BLL_HoaDon();
        BLL_Kho bllKho = new BLL_Kho();
        BLL_ChiTietHoaDon bllCTHD = new BLL_ChiTietHoaDon();
        int sTT = 0; // STT
        int tienHang = 0; // Tiền hàng
        int khuyenMai = 0; // Khuyến mãi
        int tongTien = 0; // Tổng tiền
        int diemTichLuy = 0; // Điểm tích lũy
        int tienKhachDua = 0; // Tiền khách đưa
        int tienThoi = 0; // Tiền thối
        int chietKhau = 0; // Chiết khấu
        bool checkThe = false; // Check thẻ
        public frmHoaDon()
        {
            InitializeComponent();
            timer.Start();
        }

        // Sự kiện load form
        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            Reset();
            cboMaNV.DataSource = bllNV.LayDS();
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
        }

        // Sự kiện trước khi đóng form, xác nhận có muốn đóng form hay không
        private void frmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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

        // Timer tick hiển thị thời gian thanh toán lên màn hìh
        private void timer_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = (DateTime.Now.ToString());
        }

        // Sự kiện txtMaSP thay đổi, kiểm tra nếu hàng hóa không tồn tại thì thông báo error
        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bllTonKho.CheckTT(txtMaHH.Text)) // Check tồn tại hàng hóa
                {
                    int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text); // Số lượng tồn kho
                    if (sLTonKho >= 1)
                    {
                        int row = bllHH.LayTT(txtMaHH.Text).Rows.Count;
                        txtMaHH.Text = bllHH.LayTT(txtMaHH.Text).Rows[0]["MaHH"].ToString();
                        txtTenHH.Text = bllHH.LayTT(txtMaHH.Text).Rows[0]["TenHH"].ToString();
                        errorProvider.Clear();
                    }
                }
                else
                {
                    txtTenHH.Text = "";
                    errorProvider.SetError(txtMaHH, "Sản phẩm đã bán hết hoặc không tồn tại");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Check hàng hóa đã được thêm hay chưa
        public int CheckCoHH(string maHH)
        {
            if (dgvHoaDon.Rows.Count != 1)
            {
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    if (dgvHoaDon.Rows[i].Cells[0].Value.ToString().CompareTo(maHH) == 0)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        // Sự kiện khi nhấn btnThem, thêm hàng hóa vào datagridview
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllHH.CheckTonTai(txtMaHH.Text)) // Check tồn tại mã hàng hóa
                {
                    int sL = (int)numericSL.Value; // Số lượng lấy từ numerric
                    if (bllTonKho.CheckTT(txtMaHH.Text))
                    {
                        int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text); // Số lượng tồn kho
                        if (sL > sLTonKho)
                        {
                            MessageBox.Show("Không đủ sản phẩm");
                        }
                        else
                        {
                            // Mã hàng hóa
                            string maHH = bllHH.LayTT(txtMaHH.Text).Rows[0]["MaHH"].ToString();
                            // Tên hàng hóa
                            string tenHH = bllHH.LayTT(txtMaHH.Text).Rows[0]["TenHH"].ToString();
                            // Giá
                            int gia = int.Parse(bllHH.LayTT(txtMaHH.Text).Rows[0]["Gia"].ToString());
                            // Mã khuyến mãi
                            string maKM = bllHH.LayTT(txtMaHH.Text).Rows[0]["MaKM"].ToString();
                            // Giá trị khuyến mãi
                            int gtriKM = 0;
                            // Kiểm tra nếu có khuyến mãi thì check ngày khuyến mãi được áp dụng hay chưa
                            if (bllKM.LayKMTheoMa(maKM).Rows.Count > 0)
                            {
                                DateTime ngayBatDau = DateTime.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["NgayBatDauKM"].ToString());
                                DateTime ngayKetThuc = DateTime.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["NgayKetThucKM"].ToString());
                                if (ngayBatDau <= DateTime.Now && DateTime.Now <= ngayKetThuc)
                                {
                                    gtriKM = int.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["GiaTriKM"].ToString());
                                }
                            }
                            int tienKM = gia / 100 * gtriKM * sL; // Tính tiền khuyến mãi
                            int thanhTien = (gia * sL - tienKM); // Thành tiền
                            // Kiểm tra hàng hóa đã được thêm vào datagridview hay chưa, nếu rồi thì cộng số lượng vào
                            if (CheckCoHH(maHH) != -1)
                            {
                                int row = CheckCoHH(maHH); // Lấy hàng trong datagridview có chứa hàng hóa đó
                                int slCu = int.Parse(dgvHoaDon.Rows[row].Cells[4].Value.ToString()); // số lượng cũ
                                int kmCu = int.Parse(dgvHoaDon.Rows[row].Cells[6].Value.ToString()); // khuyễn mãi cũ
                                int thanhTienCu = int.Parse(dgvHoaDon.Rows[row].Cells[7].Value.ToString());
                                if ((sL + slCu) > sLTonKho) // Kiểm tra đủ hàng hay không
                                {
                                    MessageBox.Show("Không đủ sản phẩm");
                                }
                                else
                                {
                                    // Có 2 cột số lượng, 1 cột cũ để lưu trữ số lượng cũ trong trường hợp thay đổi số lượng trực tiếp trên datagridview
                                    dgvHoaDon.Rows[row].Cells[4].Value = sL + slCu;
                                    dgvHoaDon.Rows[row].Cells[3].Value = sL + slCu;
                                }
                            }
                            else
                            {
                                dgvHoaDon.Rows.Add(maHH, tenHH, gia, sL, sL, gtriKM, tienKM, thanhTien);
                            }
                            Reset();
                            ThongTinHD();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin sản phẩm");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Tính toán các thông tin về giá tiền, khuyến mãi, tích lũy...
        public void ThongTinHD()
        {
            tienHang = 0; // tiền hàng
            khuyenMai = 0; // khuyến mãi
            tongTien = 0; // tổng tiền
            diemTichLuy = 0; // điểm tích lũy
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                tienHang += int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString())
                             * int.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                khuyenMai += int.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                tongTien += int.Parse(dgvHoaDon.Rows[i].Cells[7].Value.ToString());

            }

            diemTichLuy = (int)(tongTien / 1000);
            if (checkThe)
            {
                txtDiemTL.Text = diemTichLuy.ToString();
            }
            txtTienHang.Text = tienHang.ToString();
            txtKhuyenMai.Text = khuyenMai.ToString();
            txtTongTien.Text = tongTien.ToString();
        }

        // Sự kiện thay đổi cột số lượng trong datagridview
        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {
                    // Cột số lượng cũ là hidden
                    int slCu = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int sl = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                    // Số lượng tồn kho
                    int sLTonKho = bllTonKho.DemTonKho(dgvHoaDon.Rows[e.RowIndex].Cells[0].Value.ToString());
                    if (sl < 1)
                    {
                        MessageBox.Show("Số lượng không hợp lệ");
                    }
                    else if (sl > sLTonKho)
                    {
                        MessageBox.Show("Không đủ sản phẩm");
                        dgvHoaDon.Rows[e.RowIndex].Cells[4].Value = slCu.ToString();
                    }
                    else
                    {
                        dgvHoaDon.Rows[e.RowIndex].Cells[3].Value = sl.ToString();
                        // giá trị khuyến mãi
                        int gTriKM = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString());
                        // giá tiền khuyến mãi
                        int giaTienKM = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString());
                        // giá
                        int gia = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                        // tiền khuyến mãi
                        int tienKM = gia / 100 * gTriKM * sl;
                        // thành tiền
                        int thanhTien = (gia * sl - tienKM);
                        dgvHoaDon.Rows[e.RowIndex].Cells[6].Value = tienKM;
                        dgvHoaDon.Rows[e.RowIndex].Cells[7].Value = thanhTien;
                        ThongTinHD();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void numericSL_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                // số lượng
                int sL = int.Parse(numericSL.Value.ToString());
                if (bllTonKho.CheckTT(txtMaHH.Text)) // check tồn kho
                {
                    // số lượng tồn kho
                    int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text);
                    numericSL.Maximum = sLTonKho;
                    if (sL == sLTonKho)
                    {
                        errorProvider.SetError(numericSL, "Không đủ số lượng sản phẩm");

                    }
                    else
                    {
                        errorProvider.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Reset các fields
        private void Reset()
        {
            sTT = bllHoaDon.LayHDGiamDan().Rows.Count == 0 ? 1 :
              int.Parse(bllHoaDon.LayHDGiamDan().Rows[0]["MaHD"].ToString().Substring(2)) + 1;
            txtMaHD.Text = "HD" + string.Format("{0:000}", sTT);
            txtMaHH.Text = "";
            txtMaHH.Focus();
            txtTenHH.Text = "";
            numericSL.Value = 1;
            errorProvider.Clear();
        }

        // Sự kiện khi nhấn btnXoa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy hàng đang được click vào
                int row = dgvHoaDon.CurrentCell.RowIndex;
                if (row < dgvHoaDon.Rows.Count)
                {
                    DialogResult kq = MessageBox.Show("Bạn có muốn xóa sản phẩm này",
                        "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (kq == DialogResult.Yes)
                    {
                        ThongTinHD();
                        dgvHoaDon.Rows.RemoveAt(row);
                    }
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
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Sự kiện khi nhấn btnResrt, reset toàn bộ dữ liệu của form
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtMaHD.Text = "";
            txtMaTheKH.Text = "";
            cboMaNV.SelectedIndex = 0;
            Reset();
            dgvHoaDon.Rows.Clear();
            tienHang = 0;
            khuyenMai = 0;
            tongTien = 0;
            txtGhiChu.Text = "";
            txtTienHang.Text = "";
            txtKhuyenMai.Text = "";
            txtChietKhau.Text = "";
            txtTongTien.Text = "";
            txtDiemTL.Text = "";
            txtTienKhachDua.Text = "";
            txtTienThoi.Text = "";
            txtMaHD.Text = "HD" + string.Format("{0:000}", sTT);
            errorProvider.Clear();
        }

        // Sự kiện khi nhấn btnQuayVe, thoát form Hóa đơn hiện tại
        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // In hóa đơne
        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            bool kq = true;
            ET_HoaDon etHD = null;
            if (dgvHoaDon.Rows.Count > 1)
            {
                if (string.IsNullOrEmpty(txtTienKhachDua.Text))
                {
                    MessageBox.Show("Chưa thanh toán tiền");
                }
                else
                {
                    if (string.IsNullOrEmpty(txtTienThoi.Text))
                    {
                        MessageBox.Show("Chưa thanh toán đủ tiền");

                    }
                    else
                    {
                        string maHD = txtMaHD.Text;
                        string maNV = cboMaNV.SelectedValue.ToString();
                        string ghiChu = txtGhiChu.Text;
                        try
                        {
                            if (checkThe) // Check nếu khách hàng có thẻ khách hàng
                            {
                                etHD = new ET_HoaDon(maHD, txtMaTheKH.Text, maNV, DateTime.Now, ghiChu, tienHang, khuyenMai, chietKhau, tongTien, diemTichLuy, tienKhachDua, tienThoi);
                                // Lấy số điểm cũ trong thẻ
                                int diemTheCu = int.Parse(bllTheKH.LayTheKHTheoMa(txtMaTheKH.Text).Rows[0]["DiemTL"].ToString());
                                // Update điểm thẻ
                                bllTheKH.SuaDiemThe(txtMaTheKH.Text, diemTheCu + diemTichLuy);
                            }
                            else
                            {
                                etHD = new ET_HoaDon(maHD, "", maNV, DateTime.Now, ghiChu, tienHang, khuyenMai, chietKhau, tongTien, 0, tienKhachDua, tienThoi);
                            }
                            kq = bllHoaDon.ThemHoaDon(etHD); //Check thêm hóa đơn thành công hay chưa

                            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                            {
                                // Mã sản phẩm
                                string maSP = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                                // Giá
                                int gia = int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                                // Số lượng
                                int sL = int.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                                // Khuyến mãi
                                int khuyenMai = int.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                                // Thành tiền
                                int thanhTien = int.Parse(dgvHoaDon.Rows[i].Cells[7].Value.ToString());
                                ET_ChiTietHD etCTHD = new ET_ChiTietHD(maHD, maSP, sL, gia, khuyenMai, thanhTien);
                                kq = bllCTHD.ThemCTHD(etCTHD);
                                DataTable dsKho = bllKho.LayDS();

                                // Kiểm tra số lượng từng kho, nếu kho đầu không đủ số lượng thì tiếp trừ những kho tiếp theo
                                for (int k = 0; k < dsKho.Rows.Count; k++)
                                {
                                    // Lấy mã kho
                                    string maKho = dsKho.Rows[k][0].ToString();
                                    if (bllTonKho.CheckTonTaiTheoKho(maSP, maKho))
                                    {
                                        int slTonKho = bllTonKho.LaySL(maSP, maKho);
                                        if (slTonKho > sL)
                                        {
                                            ET_TonKho etTonKho = new ET_TonKho(maSP, maKho, slTonKho - sL);
                                            kq = bllTonKho.SuaTonKho(etTonKho);
                                            break;
                                        }
                                        else
                                        {
                                            ET_TonKho etTonKho = new ET_TonKho(maSP, maKho, 0);
                                            kq = bllTonKho.SuaTonKho(etTonKho);
                                            sL -= slTonKho;
                                        }
                                    }
                                }
                            }
                            if (kq)
                            {
                                sTT++; // Tăng số thứ tự để làm mã hóa đơn tự động tăng
                                btnReset_Click(null, null);
                                frmInHD frm = new frmInHD(etHD);
                                frm.Show();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa có hàng hóa để in");
            }
        }

        // Check string nhập vào có phải là số hay không
        public bool CheckSo(string so)
        {
            if (string.IsNullOrEmpty(so))
                return false;
            for (int i = 0; i < so.Length; i++)
            {
                if (!char.IsDigit(so[i]))
                {
                    return false;
                }
            }
            return true;
        }

        // Sự kiện khi txtMaTheKH thay đổi, nếu tồn tại thẻ và thẻ đươc kích hoạt thì checkThe  = true
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bllTheKH.CheckTonTai(txtMaTheKH.Text))
                {
                    errorProvider.Clear();
                    bool tinhTrang = Boolean.Parse(bllTheKH.LayTheKHTheoMa(txtMaTheKH.Text).Rows[0]["TinhTrang"].ToString());
                    if (tinhTrang)
                    {
                        checkThe = true;
                        txtMaTheKH.Text = bllTheKH.LayTheKHTheoMa(txtMaTheKH.Text).Rows[0]["MaTheKH"].ToString();
                        txtDiemTL.Text = diemTichLuy.ToString();
                    }
                    else
                    {
                        errorProvider.SetError(txtMaTheKH, "Thẻ chưa kích hoạt");
                    }
                }
                else
                {
                    errorProvider.SetError(txtMaTheKH, "Không tồn tại thẻ KH này");
                    checkThe = false;
                    txtDiemTL.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Khi nhập vào tiền khách đưa, thay đổi tiền thối tương ứng
        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            if (!CheckSo(txtTienKhachDua.Text))
            {
                errorProvider.SetError(txtTienKhachDua, "Tiền không hợp lệ");
                txtTienThoi.Text = "";
            }
            else
            {
                errorProvider.Clear();
                tienKhachDua = int.Parse(txtTienKhachDua.Text);
                tienThoi = tienKhachDua - tongTien;
                if (tienThoi < 0)
                {
                    errorProvider.SetError(txtTienKhachDua, "Tiền không đủ");
                    txtTienThoi.Text = "";
                    tienKhachDua = 0;
                    tienThoi = 0;
                }
                else
                {
                    errorProvider.Clear();
                    txtTienThoi.Text = tienThoi.ToString();
                }
            }
        }
    }
}
