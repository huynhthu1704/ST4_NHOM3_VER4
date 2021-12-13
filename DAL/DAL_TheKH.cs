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
    public class DAL_TheKH
    {
        //connection
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;

        //method
        public DAL_TheKH()
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

        public DataTable LayTheKHTheoMa(string maTheKH)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_LayTheKHTheoMa", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maTheKH));
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

        public bool ThemTheKhachHang(string maThe, int tinhTrang)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_ThemTheKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm các tham số
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maThe));
                //cmd.Parameters.Add(new SqlParameter("@LoaiThe", et.LoaiThe));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", tinhTrang));
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
        public bool CheckTonTai(string maKH)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_TimTheKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm các tham số
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maKH));
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

        public bool Xoa(string maThe)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_XoaTheKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm các tham số
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
        public bool SuaLoaiThe(ET_TheKH et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_SuaTheKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", et.MaTheKH));
                cmd.Parameters.Add(new SqlParameter("@LoaiThe", et.LoaiThe));
                cmd.Parameters.Add(new SqlParameter("@TinhTrang", et.TinhTrang));
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
        
        public bool SuaTheKH(string tenSP,string maThe, string tenTrongSP, int tt)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand(tenSP, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                // thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaTheKH", maThe));
                cmd.Parameters.Add(new SqlParameter(tenTrongSP, tt));
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
                //đóng kêt nối
                conn.Close();
            }
            return false;
        }


    }
}
