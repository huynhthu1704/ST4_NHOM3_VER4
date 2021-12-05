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
        int sTT = 0;
        int tienHang = 0;
        int khuyenMai = 0;
        int tongTien = 0;
        int diemTichLuy = 0;
        int tienKhachDua = 0;
        int tienThoi = 0;
        int chietKhau = 0;
        bool checkThe = false;
        public frmHoaDon()
        {
            InitializeComponent();
            timer.Start();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            sTT = bllHoaDon.LayHDGiamDan().Rows.Count == 0 ? 1 :
                int.Parse(bllHoaDon.LayHDGiamDan().Rows[0]["MaHD"].ToString().Substring(2)) + 1;
            txtMaHD.Text = "HD" + string.Format("{0:000}", sTT);
            cboMaNV.DataSource = bllNV.LayDS();
            cboMaNV.DisplayMember = "HoTen";
            cboMaNV.ValueMember = "MaNV";
        }

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

        private void timer_Tick(object sender, EventArgs e)
        {
            lblThoiGian.Text = (DateTime.Now.ToString());
        }

        private void txtMaSP_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bllTonKho.CheckTT(txtMaHH.Text))
                {
                    int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text);
                    //  MessageBox.Show(sLTonKho.ToString());
                    if (sLTonKho >= 1)
                    {
                        //MessageBox.Show(txtMaHH.Text.Length.ToString());
                        int row = bllHH.LayTT(txtMaHH.Text).Rows.Count;
                        //MessageBox.Show(row.ToString());
                        txtTenHH.Text = bllHH.LayTT(txtMaHH.Text).Rows[0]["TenHH"].ToString();
                        //numericSL.Maximum = 
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

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (bllHH.CheckTonTai(txtMaHH.Text))
                {
                    int sL = (int)numericSL.Value;
                    if (bllTonKho.CheckTT(txtMaHH.Text))
                    {
                        int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text);
                        // MessageBox.Show(sLTonKho.ToString());
                        if (sL > sLTonKho)
                        {
                            MessageBox.Show("Không đủ sản phẩm");
                        }
                        else
                        {
                            string maHH = bllHH.LayTT(txtMaHH.Text).Rows[0]["MaHH"].ToString();
                            string tenHH = bllHH.LayTT(txtMaHH.Text).Rows[0]["TenHH"].ToString();
                            int gia = int.Parse(bllHH.LayTT(txtMaHH.Text).Rows[0]["Gia"].ToString());
                            string maKM = bllHH.LayTT(txtMaHH.Text).Rows[0]["MaKM"].ToString();
                            MessageBox.Show(maKM);
                            int gtriKM = 0;
                            if (bllKM.LayKMTheoMa(maKM).Rows.Count > 0)
                            {
                                DateTime ngayBatDau = DateTime.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["NgayBatDauKM"].ToString());
                                DateTime ngayKetThuc = DateTime.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["NgayKetThucKM"].ToString());
                                if (ngayBatDau <= DateTime.Now && DateTime.Now <= ngayKetThuc)
                                {
                                    //MessageBox.Show(ngayBatDau.ToString());
                                    //MessageBox.Show(ngayKetThuc.ToString());  
                                    //MessageBox.Show(DateTime.Now.ToString());
                                    gtriKM = int.Parse(bllKM.LayKMTheoMa(maKM).Rows[0]["GiaTriKM"].ToString());
                                    MessageBox.Show(gtriKM.ToString());
                                }
                            }
                            // MessageBox.Show(bllKM.LayKMTheoMa(maKM).Rows.Count.ToString());
                            int tienKM = gia / 100 * gtriKM * sL;
                            int thanhTien = (gia * sL - tienKM);
                            if (CheckCoHH(maHH) != -1)
                            {
                                int row = CheckCoHH(maHH);
                                int slCu = int.Parse(dgvHoaDon.Rows[row].Cells[4].Value.ToString());
                                int kmCu = int.Parse(dgvHoaDon.Rows[row].Cells[6].Value.ToString());
                                int thanhTienCu = int.Parse(dgvHoaDon.Rows[row].Cells[7].Value.ToString());
                                if ((sL + slCu) > sLTonKho)
                                {
                                    MessageBox.Show("Không đủ sản phẩm");
                                }
                                else
                                {
                                    dgvHoaDon.Rows[row].Cells[4].Value = sL + slCu;
                                    dgvHoaDon.Rows[row].Cells[3].Value = sL + slCu;
                                    //dgvHoaDon.Rows[row].Cells[4].Value = tienKM + kmCu;
                                    //dgvHoaDon.Rows[row].Cells[5].Value = thanhTien + thanhTienCu;
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
                MessageBox.Show(ex.Message + "Them");
            }
        }

        public void ThongTinHD()
        {
            tienHang = 0;
            khuyenMai = 0;
            tongTien = 0;
            diemTichLuy = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                tienHang += int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString())
                             * int.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                khuyenMai += int.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                tongTien += int.Parse(dgvHoaDon.Rows[i].Cells[7].Value.ToString());

            }
            //  tongTien = tienHang - khuyenMai;
           
            diemTichLuy = (int)(tongTien / 1000);
            if (checkThe)
            {
                txtDiemTL.Text = diemTichLuy.ToString();
            }
            txtTienHang.Text = tienHang.ToString();
            txtKhuyenMai.Text = khuyenMai.ToString();
            txtTongTien.Text = tongTien.ToString();
            //txtDiemTL.Text = diemTichLuy.ToString();
        }
        private void dgvHoaDon_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // MessageBox.Show(e.ColumnIndex.ToString());
                if (e.RowIndex >= 0 && e.ColumnIndex == 4)
                {

                    int slCu = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[3].Value.ToString());
                    int sl = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[4].Value.ToString());
                    MessageBox.Show(sl.ToString());
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
                        //dgvHoaDon.Rows[e.RowIndex].Cells[3].Value = sl;
                        int gTriKM = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[5].Value.ToString());
                        //MessageBox.Show(gTriKM.ToString());
                        int giaTienKM = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[6].Value.ToString());
                        int gia = int.Parse(dgvHoaDon.Rows[e.RowIndex].Cells[2].Value.ToString());
                        int tienKM = gia / 100 * gTriKM * sl;
                        //MessageBox.Show("hihi7");
                        int thanhTien = (gia * sl - tienKM);
                        //dgvHoaDon.Rows[e.RowIndex].Cells[2].Value = gia;
                        //dgvHoaDon.Rows[e.RowIndex].Cells[3].Value = sl;
                        dgvHoaDon.Rows[e.RowIndex].Cells[6].Value = tienKM;
                        dgvHoaDon.Rows[e.RowIndex].Cells[7].Value = thanhTien;
                        ThongTinHD();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Cell change");
            }
        }

        private void numericSL_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int sL = int.Parse(numericSL.Value.ToString());
                if (bllTonKho.CheckTT(txtMaHH.Text))
                {
                    int sLTonKho = bllTonKho.DemTonKho(txtMaHH.Text);
                    // MessageBox.Show(sLTonKho.ToString());
                    if (sL > sLTonKho)
                    {
                        errorProvider.SetError(numericSL, "Không đủ số lượng sản phẩm");
                        // MessageBox.Show("Không đủ số lượng sản phẩm");
                    }
                    else
                    {
                        errorProvider.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "Numeric change");
            }
        }

        private void Reset()
        {
            txtMaHH.Text = "";
            txtTenHH.Text = "";
            numericSL.Value = 1;
            errorProvider.Clear();
        }

        private void dgvHoaDon_Click(object sender, EventArgs e)
        {
            //int i = dgvHoaDon.CurrentCell.RowIndex;
            //MessageBox.Show(i.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
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
        }

        private void btnQuayVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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
                            if (checkThe)
                            {
                                etHD = new ET_HoaDon(maHD, txtMaTheKH.Text, maNV, DateTime.Now, ghiChu, tienHang, khuyenMai, chietKhau, tongTien,diemTichLuy, tienKhachDua, tienThoi);
                                int diemTheCu = int.Parse(bllTheKH.LayTheKHTheoMa(txtMaTheKH.Text).Rows[0]["DiemTL"].ToString());
                                MessageBox.Show(diemTichLuy.ToString()+"DTL");
                                bllTheKH.SuaDiemThe(txtMaTheKH.Text, diemTheCu + diemTichLuy); 
                            }
                            else
                            {
                                etHD = new ET_HoaDon(maHD, "", maNV, DateTime.Now, ghiChu, tienHang, khuyenMai, chietKhau, tongTien,0, tienKhachDua, tienThoi);
                            }
                            kq = bllHoaDon.ThemHoaDon(etHD);
                            
                            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                            {
                                string maSP = dgvHoaDon.Rows[i].Cells[0].Value.ToString();
                                int gia = int.Parse(dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                                int sL = int.Parse(dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                                int khuyenMai = int.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString());
                                MessageBox.Show(khuyenMai.ToString()+"KM");
                                int thanhTien = int.Parse(dgvHoaDon.Rows[i].Cells[7].Value.ToString());
                                ET_ChiTietHD etCTHD = new ET_ChiTietHD(maHD, maSP, sL, gia, khuyenMai, thanhTien);
                                kq = bllCTHD.ThemCTHD(etCTHD);
                                DataTable dsKho = bllKho.LayDS();
                                for (int k = 0; k < dsKho.Rows.Count; k++)
                                {
                                    string maKho = dsKho.Rows[k][0].ToString();
                                     MessageBox.Show(maKho);
                                    if (bllTonKho.CheckTonTaiTheoKho(maSP, maKho) && (sL > 0))
                                    {
                                        MessageBox.Show(bllTonKho.LaySL(maSP, maKho).ToString()+"TKho");
                                        if (bllTonKho.LaySL(maSP, maKho) >= sL)
                                        {
                                            ET_TonKho etTonKho = new ET_TonKho(maSP, maKho, bllTonKho.LaySL(maSP, maKho) - sL);
                                            kq = bllTonKho.SuaTonKho(etTonKho);
                                            // MessageBox.Show(etTonKho.SoLuong.ToString() + "1");
                                            break;
                                        }
                                        else
                                        {
                                            ET_TonKho etTonKho = new ET_TonKho(maSP, maKho, bllTonKho.LaySL(maSP, maKho));
                                            kq = bllTonKho.SuaTonKho(etTonKho);
                                            sL -= bllTonKho.LaySL(maSP, maKho);
                                            // MessageBox.Show(etTonKho.SoLuong.ToString() + "2");
                                        }
                                    }
                                }
                            }
                            if (kq)
                            {
                                sTT++;
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
        }

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
        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (bllTheKH.CheckTonTai(txtMaTheKH.Text))
                {
                    errorProvider.Clear();
                    bool tinhTrang = Boolean.Parse(bllTheKH.LayTheKHTheoMa(txtMaTheKH.Text).Rows[0]["TinhTrang"].ToString());
                    MessageBox.Show(tinhTrang.ToString());
                    if (tinhTrang)
                    {
                       // checkThe = false;
                        checkThe = true;
                        txtDiemTL.Text = diemTichLuy.ToString();
                    } else
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
