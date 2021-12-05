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
    public  class DAL_DanhMucHH
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_DanhMucHH()
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
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool ThemDM(ET_DanhMucHH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemDanhMucHH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                cmd.Parameters.Add(new SqlParameter("@TenDM", et.TenDM));
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
        public bool CheckTonTai(ET_DanhMucHH et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimDanhMucHH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
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

        public bool XoaDM(ET_DanhMucHH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaDanhMucHH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
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
        public bool Sua(ET_DanhMucHH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaDanhMucHH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                cmd.Parameters.Add(new SqlParameter("@TenDM", et.TenDM));

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
