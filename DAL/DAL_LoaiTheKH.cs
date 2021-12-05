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
    public class DAL_LoaiTheKH
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DAL_LoaiTheKH()
        {
            conn = Connection.conn;
        }

        // Lấy danh sách loại thẻ KH
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

        // Check thẻ có tồn tại hay không, nếu tồn tại trả về true
        public bool CheckTonTai(ET_LoaiTheKH et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimLoaiTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ma", et.MaLoaiThe));
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
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        // Thêm LoaiTheKH
        public bool ThemLoaiTheKH(ET_LoaiTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemLoaiTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ma", et.MaLoaiThe));
                cmd.Parameters.Add(new SqlParameter("@Ten", et.TenLoaiThe));
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

        // Xóa LoaiTheKH
        public bool XoaLoaiTheKH(ET_LoaiTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaLoaiTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ma", et.MaLoaiThe));
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

        // Sửa LoaiTheKH
        public bool SuaLoaiTheKH(ET_LoaiTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaLoaiTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Ma", et.MaLoaiThe));
                cmd.Parameters.Add(new SqlParameter("@Ten", et.TenLoaiThe));
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
