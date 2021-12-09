// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class DAL_LoaiTK
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_LoaiTK()
        {
            conn = Connection.conn;
        }

        /// <summary>
        /// Lấy danh sách loại tài khoản
        /// </summary>
        /// <param name="tenSP">tenSP là tên stored procedure cần lấy ds</param>
        /// <returns></returns>
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

        /// <summary>
        /// Tìm loại tài khoản dựa tên mã loại tài khoản
        /// </summary>
        /// <param name="maLoai">Mã loại tài khoản cần tìm</param>
        /// <returns></returns>
        public DataTable TimLoaiTK(string maLoai)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimLoaiTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK",maLoai));
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

        /// <summary>
        /// Thêm loại tài khoản
        /// </summary>
        /// <param name="et">Class Loại Tài Khoản</param>
        /// <returns></returns>
        public bool ThemLoaiTK(ET_LoaiTK et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemLoaiTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
                cmd.Parameters.Add(new SqlParameter("@TenLoaiTK", et.TenLoai));
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

        /// <summary>
        /// Xóa loại tài khoản
        /// </summary>
        /// <param name="et">Class Loại Tài Khoản</param>
        /// <returns></returns>
        public bool XoaLoaiTK(ET_LoaiTK et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaLoaiTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
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

        /// <summary>
        /// Sửa loại tài khoản
        /// </summary>
        /// <param name="et">Class Loại Tài Khoản</param>
        /// <returns></returns>
        public bool SuaLoaiTK(ET_LoaiTK et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaLoaiTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
                cmd.Parameters.Add(new SqlParameter("@TenLoaiTK", et.TenLoai));
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
