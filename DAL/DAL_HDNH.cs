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
    public class DAL_HDNH
    {
        private SqlConnection _conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;

        public DAL_HDNH()
        {
            _conn = Connection.conn;
        }

        // Lấy danh sách hóa đơn nhập hàng
        public DataTable LayDS(string tenSP)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand(tenSP, _conn);
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

        // Thêm hóa đơn nhâp hàng
        public bool ThemHDNH(ET_HDNH et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_ThemHDNH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@TongTien", et.TongTien));
                cmd.Parameters.Add(new SqlParameter("@TraTruoc", et.TraTruoc));
                cmd.Parameters.Add(new SqlParameter("@CongNo", et.CongNo));

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

        // Sửa hóa đơn nhập hàng
        public bool SuaHDNH(ET_HDNH et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_SuaHDNH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@TongTien", et.TongTien));
                cmd.Parameters.Add(new SqlParameter("@TraTruoc", et.TraTruoc));
                cmd.Parameters.Add(new SqlParameter("@CongNo", et.CongNo));
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

        // Xóa hóa đơn nhập hàng
        public bool XoaHDNH(ET_HDNH et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_XoaHDNH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
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

        // Check tồn tại hóa đơn nhập hàng
        public bool CheckTonTai(string maHD)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimHDNH", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHD));
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
    }
}
