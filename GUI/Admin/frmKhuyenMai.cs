﻿using System;
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
        public frmKhuyenMai()
        {
            InitializeComponent();
        }
        BLL_KhuyenMai b = new BLL_KhuyenMai();
        private void frmKhuyenMai_Load(object sender, EventArgs e)
        {
            dvgDS.DataSource = b.LayDS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGTKM.Text == "" || txtMaKM.Text == "" || txtTenKM.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_KhuyenMai KhuyenMai = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text, int.Parse(txtGTKM.Text), Convert.ToDateTime(dtpBD.Text), Convert.ToDateTime(dtpKT.Text));
                    if (b.CheckTonTai(KhuyenMai) == true)
                    {
                        MessageBox.Show("Khuyễn Mãi đã tồn tại");
                    }
                    else
                    {
                        if (b.ThemKhuyenMai(KhuyenMai) == true)
                        {
                            MessageBox.Show("Thêm Thành Công");
                            txtGTKM.Text = "";
                            txtMaKM.Text = "";
                            txtTenKM.Text = "";
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
                dvgDS.DataSource = b.LayDS();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string ma = txtMaKM.Text;
            DialogResult kq = MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq == DialogResult.Yes)
            {
                try
                {
                    if (ma == "")
                    {
                        MessageBox.Show("vui lòng nhập mã khuyễn mãi");
                    }
                    else
                    {
                        if (b.XoaKhuyenMai(ma) == true)
                        {
                            MessageBox.Show("Xoá Thành Công");
                            txtGTKM.Text = "";
                            txtMaKM.Text = "";
                            txtTenKM.Text = "";
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
                    dvgDS.DataSource = b.LayDS();
                }
            }
            else
            {
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtGTKM.Text == "" || txtMaKM.Text == "" || txtTenKM.Text == "")
                {
                    MessageBox.Show("vui lòng nhập đủ thông tin");
                }
                else
                {
                    ET_KhuyenMai KhuyenMai = new ET_KhuyenMai(txtMaKM.Text, txtTenKM.Text, int.Parse(txtGTKM.Text), Convert.ToDateTime(dtpBD.Text), Convert.ToDateTime(dtpKT.Text));
                    if (b.SuaKhuyenMai(KhuyenMai) == true)
                    {
                        MessageBox.Show("Sửa Thành Công");
                        txtGTKM.Text = "";
                        txtMaKM.Text = "";
                        txtTenKM.Text = "";
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
                dvgDS.DataSource = b.LayDS();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dvgDS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dvgDS.CurrentCell.RowIndex;
            txtMaKM.Text = dvgDS.Rows[index].Cells[0].Value.ToString();
            txtTenKM.Text = dvgDS.Rows[index].Cells[1].Value.ToString();
            txtGTKM.Text = dvgDS.Rows[index].Cells[3].Value.ToString();
            dtpBD.Text = dvgDS.Rows[index].Cells[4].Value.ToString();
            dtpKT.Text = dvgDS.Rows[index].Cells[5].Value.ToString();
        }
    }
}
