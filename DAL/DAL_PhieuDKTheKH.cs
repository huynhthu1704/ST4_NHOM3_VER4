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
        //connection
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        //method
        public DAL_PhieuDKTheKH()
        {
            conn = Connection.conn;
        }
        public DataTable HienThi(string tenSP)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand(tenSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException ex)
            {
                //ném lỗi
                throw ex;
            }
            finally
            {
                //đóng kết nối
                conn.Close();
            }
            return dt;
        }

        public bool ThemPhieuDK(ET_PhieuDKTheKH et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_ThemPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm các tham số
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
                //ném lỗi
                throw ex;
            }
            finally
            {
                //đóng kết nối
                conn.Close();
            }
            return false;
        }

        public bool CheckTonTai(ET_PhieuDKTheKH et)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_TimPhieuDKTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaPhieu", et.MaPhieu));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                //thực thi
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex)
            {
                //ném lỗi
                throw ex;
            }
            finally
            {
                //đóng kết nối
                conn.Close();
            }
            return false;
        }
    }
}
