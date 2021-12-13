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
    public class DAL_ChiTietHD
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_ChiTietHD()
        {
            conn = Connection.conn;
        }

        // Hiển thị chi tiết hóa đơn
        public DataTable HienThiDS(string tenSP)
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
        
        // Lấy chi tiết hóa đơn theo mã hóa đơn
        public DataTable LayCTHDTheoMaHD(string maHD)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_LayCTHDThemMaHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHD));
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

        // Thêm chi tiết hóa đơn
        public bool ThemCTHD(ET_ChiTietHD et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemChiTietHD", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@SL", et.SL)); 
                cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                cmd.Parameters.Add(new SqlParameter("@KhuyenMai", et.KhuyenMai));
                cmd.Parameters.Add(new SqlParameter("@Thanhtien", et.ThanhTien));
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
