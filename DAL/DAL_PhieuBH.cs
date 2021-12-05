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
    public class DAL_PhieuBH
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_PhieuBH()
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
        public bool ThemPhieuBH(ET_PhieuBH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemPhieuBaoHanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuBH", et.MaBH));
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@NgayMua", et.NgayMua));
                cmd.Parameters.Add(new SqlParameter("@ThoiHanBH", et.ThoiHanBH));
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
        public bool CheckTonTai(ET_PhieuBH et)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimPhieuBaoHanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuBH", et.MaBH));
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

        public bool XoaPhieuBH(ET_PhieuBH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaPhieuBaoHanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuBH", et.MaBH));
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
        public bool Sua(ET_PhieuBH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaPhieuBaoHanh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaPhieuBH", et.MaBH));
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@NgayMua", et.NgayMua));
                cmd.Parameters.Add(new SqlParameter("@ThoiHanBH", et.ThoiHanBH));

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
