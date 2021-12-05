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
    public class DAL_HangHoa
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_HangHoa()
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


        public bool ThemHH(ET_HangHoa et)
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(et.MaKM))
                {
                    cmd = new SqlCommand("sp_ThemHangHoaKhKM", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                    cmd.Parameters.Add(new SqlParameter("@TenHH", et.TenHH));
                    cmd.Parameters.Add(new SqlParameter("@DVTinh", et.DonVT));
                    cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                    cmd.Parameters.Add(new SqlParameter("@BaoHanh", et.BaoHanh));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    cmd = new SqlCommand("sp_ThemHangHoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                    cmd.Parameters.Add(new SqlParameter("@TenHH", et.TenHH));
                    cmd.Parameters.Add(new SqlParameter("@DVTinh", et.DonVT));
                    cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                    cmd.Parameters.Add(new SqlParameter("@BaoHanh", et.BaoHanh));
                    cmd.Parameters.Add(new SqlParameter("@MaKM", et.MaKM));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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

        public bool CheckTonTai(string maHH)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimHangHoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
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

        public bool XoaHH(ET_HangHoa et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaHangHoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
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
        public bool Sua(ET_HangHoa et)
        {
            try
            {
                conn.Open();
                if (string.IsNullOrEmpty(et.MaKM))
                {
                    cmd = new SqlCommand("sp_ThemHangHoaKhKM", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                    cmd.Parameters.Add(new SqlParameter("@TenHH", et.TenHH));
                    cmd.Parameters.Add(new SqlParameter("@DVTinh", et.DonVT));
                    cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                    cmd.Parameters.Add(new SqlParameter("@BaoHanh", et.BaoHanh));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
                }
                else
                {
                    cmd = new SqlCommand("sp_SuaHangHoa", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                    cmd.Parameters.Add(new SqlParameter("@TenHH", et.TenHH));
                    cmd.Parameters.Add(new SqlParameter("@DVTinh", et.DonVT));
                    cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                    cmd.Parameters.Add(new SqlParameter("@MaDM", et.MaDM));
                    cmd.Parameters.Add(new SqlParameter("@BaoHanh", et.BaoHanh));
                    cmd.Parameters.Add(new SqlParameter("@MaKM", et.MaKM));
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        return true;
                    }
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
        public DataTable LayTT(string maHH)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimHangHoa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
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
    }
}
