using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using ET;
using System.Data.SqlClient;

namespace GUI.Report
{
    public partial class frmRPKhachHang : Form
    {
        SqlConnection conn = Connection.conn;

        public frmRPKhachHang()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                crpKhachHang kh = new crpKhachHang();
                DataSet ds = new DataSet();
                DataTable dt;
                ds.Tables.Add(new DataTable("KhachHang"));
                SqlCommand cmd = new SqlCommand("sp_LayKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Tables["KhachHang"]);
                foreach (DataRow dr in ds.Tables["KhachHang"].Rows)
                {
                    MessageBox.Show(dr["MaKH"].ToString());
                    kh.SetDataSource(ds);
                    string maTheKH = dr["MaTheKH"].ToString();
                    cmd = new SqlCommand("sp_LayTheKHTheoMa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaTheKH", maTheKH));
                    dt = new DataTable();
                    da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    kh.SetParameterValue("diemTL", dt.Rows[0]["DiemTL"].ToString());
                }
                crvKhachHang.ReportSource = kh;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void frmRPKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq = MessageBox.Show("Bạn có muốn thoát?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            //kiểm tra kq 
            if (kq == DialogResult.Yes)
            {
                //Xu lý trc khi thoat
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
