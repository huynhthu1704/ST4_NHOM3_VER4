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
    public class DAL_DVT
    {
        //connection
        private SqlConnection conn;
        private DataTable dt;
        private SqlCommand cmd;
        private SqlDataAdapter da;
        //method
        public DAL_DVT()
        {
            conn = Connection.conn;
        }

        public DataTable HienThiDS(string tenSP)
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

        public bool ThemDVT(ET_DVT et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_ThemDonViTinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaDVT", et.MaDVT));
                cmd.Parameters.Add(new SqlParameter("@TenDVT", et.TenDVT));
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
        public bool XoaDVT(ET_DVT et)
        {
            try
            {
                //mở kêt nối
                conn.Open();
                cmd = new SqlCommand("sp_XoaDonViTinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaDVT", et.MaDVT));
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

        public bool SuaDVT(ET_DVT et)
        {
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_SuaDonViTinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //thêm tham số
                cmd.Parameters.Add(new SqlParameter("@MaDVT", et.MaDVT));
                cmd.Parameters.Add(new SqlParameter("@TenDVT", et.TenDVT));
                //thục thi
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
        public bool CheckTonTai(ET_DVT et)
        {
            dt = null;
            try
            {
                //mở kết nối
                conn.Open();
                cmd = new SqlCommand("sp_TimDonViTinh", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham số
                cmd.Parameters.Add(new SqlParameter("@MaDVT", et.MaDVT));
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
