// Ngọc Thư
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ET;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DAL_TonKho
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_TonKho()
        {
            conn = Connection.conn;
        }

        // Hiển thị ds tồn kho
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

        // Thêm tồn kho
        public bool ThemTonKho(ET_TonKho et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemTonKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
                cmd.Parameters.Add(new SqlParameter("@SL", et.SoLuong));
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

        // Check tồn tại theo kho
        public bool CheckTonTaiTheoKho(string maHH, string maKho)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimTonKhoTheoKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
                cmd.Parameters.Add(new SqlParameter("@MaKho", maKho));
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

        // Check tồn tại theo mã hàng hóa
        public bool CheckTonTai(string maHH)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimTonKho", conn);
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
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return false;
        }

        // Lấy số lượng tồn kho
        public int LaySL(string maHH, string maKho)
        {
            dt = null;
            int sl = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimTonKhoTheoKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
                cmd.Parameters.Add(new SqlParameter("@MaKho", maKho));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    sl = int.Parse(dt.Rows[0][2].ToString());
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
            return sl;
        }

        // Sửa tồn kho
        public bool SuaTonKho(ET_TonKho et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaTonKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
                cmd.Parameters.Add(new SqlParameter("@SL", et.SoLuong));

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
        
        // Đếm tồn kho
        public int DemTonKho(string maHH)
        {
            dt = null;
            int sl = 0;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_DemTonKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
                sl = (int)cmd.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            return sl;
        }
    }
}
