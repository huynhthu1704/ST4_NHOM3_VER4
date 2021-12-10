//Thanh Quốc
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
    public class DAL_PhieuDKTheKH
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_PhieuDKTheKH()
        {
            conn = Connection.conn;
        }
        public DataTable HienThi(string tenSP)
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

        public bool ThemPhieuDK(ET_PhieuDKTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", et.MaPhieu));
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", et.MaTheKH));
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
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
        public bool CheckTonTai(ET_PhieuDKTheKH et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", et.MaPhieu));
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

        public bool CapNhatTKH(string et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_CapNhapTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", et));
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

        public bool XoaPhieuDK(ET_PhieuDKTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", et.MaPhieu));
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
        public bool Sua(ET_PhieuDKTheKH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", et.MaPhieu));
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", et.MaTheKH));
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));

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
