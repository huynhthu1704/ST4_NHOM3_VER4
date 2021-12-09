// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ET;

namespace DAL
{
    public class DAL_HoaDon
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_HoaDon()
        {
            conn = Connection.conn;
        }

        // Lấy ds hóa đơn
        public DataTable HienThiDS(string tenSP)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand(tenSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Lấy hóa đơn theo mã hóa đơn
        public DataTable LayHDTheoMaHD(string maHD)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_LayHoaDonTheoMaHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHD));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        // Thêm hóa đ
        public bool ThemHD(ET_HoaDon et)
        {
            try
            {
                conn.Open();


                if (string.IsNullOrEmpty(et.MaTheKH))
                {
                    cmd = new SqlCommand("sp_ThemHoaDonKhachVL", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                }
                else
                {
                    cmd = new SqlCommand("sp_ThemHoaDonTheoMaKH", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaTheKH", et.MaTheKH));
                    cmd.Parameters.Add(new SqlParameter("@DiemTL", et.DiemTL));
                }

                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@GhiChu", et.GhiChu));
                cmd.Parameters.Add(new SqlParameter("@TienHang", et.TienHang));
                cmd.Parameters.Add(new SqlParameter("@KhuyenMai", et.KhuyenMai));
                cmd.Parameters.Add(new SqlParameter("@ChietKhau", et.ChietKhau));
                cmd.Parameters.Add(new SqlParameter("@TongTien", et.TongTien));
                cmd.Parameters.Add(new SqlParameter("@TienKhachDua", et.TienKhachDua));
                cmd.Parameters.Add(new SqlParameter("@TienThoi", et.TienThoi));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
