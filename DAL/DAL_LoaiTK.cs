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

        public bool CheckTonTai(ET_LoaiTK et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimLoaiTaiKhoan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaLoaiTK", et.MaLoaiTK));
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
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

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
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

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
            }
            finally
            {
                conn.Close();
            }
            return false;
        }
    }
}
