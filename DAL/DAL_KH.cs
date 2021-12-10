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
    public class DAL_KH
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_KH()
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

        public DataSet LayDSChoRP()
        {
            DataSet ds;
            try
            {
                conn.Open();
                ds = new DataSet();
                ds.Tables.Add(new DataTable("KhachHang"));
                SqlCommand cmd = new SqlCommand("sp_LayKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds.Tables["KhachHang"]);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return ds;
        }

        public bool ThemKH(ET_KH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@HoTenKH", et.HoTenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
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

        public bool CheckTonTai(ET_KH et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
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
        public bool XoaKH(ET_KH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool Sua(ET_KH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@HoTenKH", et.HoTenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
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
        public bool SuaTheKH(string maKH, string maThe)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", maKH));
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maThe));
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
