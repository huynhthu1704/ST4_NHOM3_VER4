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
    public class DAL_TaiKhoan
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_TaiKhoan()
        {
            conn = Connection.conn;
        }

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
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool CheckTonTai(string maTK)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", maTK));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool ThemTK(ET_TaiKhoan et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", et.MaTK));
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", et.TenDN));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", et.MatKhau));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }


        public bool XoaTK(ET_TaiKhoan et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", et.MaTK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        public bool SuaTK(ET_TaiKhoan et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", et.MaTK));
                cmd.Parameters.Add(new SqlParameter("@TenDangNhap", et.TenDN));
                cmd.Parameters.Add(new SqlParameter("@MatKhau", et.MatKhau));
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
