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
    public class DAL_NhanVien
    {
        private SqlConnection _conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DAL_NhanVien()
        {
            _conn = Connection.conn;
        }
        //method
        public DataTable LayDS()
        {

            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_LayNhanVien", _conn);
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

        public bool ThemNhanVien(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_ThemNhanVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@HoNV", et.HoNV));
                cmd.Parameters.Add(new SqlParameter("@TenNV", et.TenNV));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SoDT));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CCCD", et.CCCD1));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", et.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgayVaoLam", et.NgayVaoLam));
                cmd.Parameters.Add(new SqlParameter("@MaBP", et.MaBP));
                cmd.Parameters.Add(new SqlParameter("@MaTK", et.MaTK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool SuaNhanVien(ET_NhanVien et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_SuaNhanVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
                cmd.Parameters.Add(new SqlParameter("@HoNV", et.HoNV));
                cmd.Parameters.Add(new SqlParameter("@TenNV", et.TenNV));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SoDT));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@CCCD", et.CCCD1));
                cmd.Parameters.Add(new SqlParameter("@NgaySinh", et.NgaySinh));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@NgayVaoLam", et.NgayVaoLam));
                cmd.Parameters.Add(new SqlParameter("@MaBP", et.MaBP));
                cmd.Parameters.Add(new SqlParameter("@MaTK", et.MaTK));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }

        public bool XoaNhanVien(String et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_XoaNhanVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNV", et));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool CheckTonTai(ET_NhanVien et)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimNhanVien", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNV", et.MaNV));
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
                _conn.Close();
            }
            return false;
        }
        public bool CheckTonTaiMaTK(string et)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimTaiKhoan", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", et));
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
                _conn.Close();
            }
            return false;
        }

        public DataTable TimNVTheoTKDN(string maTK)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimNVTheoTKDN", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaTK", maTK));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }
    }
}
