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
    public class DAL_ChiTietNhapHang
    {
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        public DAL_ChiTietNhapHang()
        {
            conn = Connection.conn;
        }

        // Hiển thi chi tiết nhập hàng
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

        // Thêm chi tiết nhập hàng
        public bool ThemCTNH(ET_ChiTietNH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_ThemChiTietNhapHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@SL", et.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", et.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
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

        // Check tồn tại chi tiết nhập hàng
        public bool CheckTonTai(string maHD, string maHH)
        {
            dt = null;
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_TimChiTietNhapHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHD));
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

        // Xóa chi tiết nhập hàng
        public bool XoaCTNH(string maHD, string maHH)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_XoaChiTietNhapHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", maHD));
                cmd.Parameters.Add(new SqlParameter("@MaHH", maHH));
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

        // Sửa chi tiết nhập hàng
        public bool SuaCTNH(ET_ChiTietNH et)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("sp_SuaChiTietNhapHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaHD", et.MaHD));
                cmd.Parameters.Add(new SqlParameter("@MaHH", et.MaHH));
                cmd.Parameters.Add(new SqlParameter("@SL", et.SoLuong));
                cmd.Parameters.Add(new SqlParameter("@Gia", et.Gia));
                cmd.Parameters.Add(new SqlParameter("@ThanhTien", et.ThanhTien));
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));

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
