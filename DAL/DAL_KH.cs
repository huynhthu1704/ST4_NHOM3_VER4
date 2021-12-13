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
        //connection
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        //method
        public DAL_KH()
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
                //Ném lỗi
                throw ex;
            }
            finally
            {
                // đóng kết nối
                conn.Close();
            }
            return dt;
        }
        public bool ThemKH(ET_KH et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_ThemKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm vào các tham số
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@HoTenKH", et.HoTenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                //thực thi
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

        public bool CheckTonTai(ET_KH et)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_TimKhachHang", conn);
                //thêm tham số
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
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
        public bool XoaKH(ET_KH et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_XoaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                //thực thi
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
                //đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool Sua(ET_KH et)
        {
            try
            {
                // mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_SuaKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // truyền tham số
                cmd.Parameters.Add(new SqlParameter("@MaKH", et.MaKH));
                cmd.Parameters.Add(new SqlParameter("@HoTenKH", et.HoTenKH));
                cmd.Parameters.Add(new SqlParameter("@GioiTinh", et.GioiTinh));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                // thực thi
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
                //đóng kết nối
                conn.Close();
            }
            return false;
        }
        public bool SuaTheKH(string maKH, string maThe)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_SuaTheKH", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKH", maKH));
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maThe));
                //thực thi
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
    }

}
