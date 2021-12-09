// Đức Trí
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
     public class DAL_KhuyenMai
    {
        private SqlConnection _conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DAL_KhuyenMai()
        {
            _conn = Connection.conn;
        }
        //method
        public DataTable LayDS()
        {
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_DSKM", _conn);
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
                _conn.Close();
            }
            return dt;
        }

        public bool ThemKhuyenMai(ET_KhuyenMai et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_ThemKhuyenMai", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKM", et.MaKM));
                cmd.Parameters.Add(new SqlParameter("@TenKM", et.TenKM));
                cmd.Parameters.Add(new SqlParameter("@GiaTriKM", et.GiaTriKM));
                cmd.Parameters.Add(new SqlParameter("@NgayBatDauKM", et.NgayBD));
                cmd.Parameters.Add(new SqlParameter("@NgayKetThucKM", et.NgayKT));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool SuaKuyenMai(ET_KhuyenMai et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_SuaKhuyenMai", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKM", et.MaKM));
                cmd.Parameters.Add(new SqlParameter("@TenKM", et.TenKM));
                cmd.Parameters.Add(new SqlParameter("@GiaTriKM", et.GiaTriKM));
                cmd.Parameters.Add(new SqlParameter("@NgayBatDauKM", et.NgayBD));
                cmd.Parameters.Add(new SqlParameter("@NgayKetThucKM", et.NgayKT));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }

        public bool XoaKhuyenMai(string et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_XoaKhuyenMai", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKM", et));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool CheckTonTai(ET_KhuyenMai et)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimKhuyenMai", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKM", et.MaKM));
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
                _conn.Close();
            }
            return false;
        }

        public DataTable LayKMTheoMa(string maKM)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimKhuyenMai", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKM", maKM));
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
                _conn.Close();
            }
            return dt;
        }
    }
}
