/// Đức Trí
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
    public class DAL_BoPhan
    {
        private SqlConnection _conn;
        SqlCommand cmdBoPhan;
        SqlDataAdapter daBoPhan;
        DataTable dtBoPhan;

        public DAL_BoPhan()
        {
            _conn = Connection.conn;
        }
        //method
        /// <summary>
        /// Lấy Danh Sách Bộ phận
        /// </summary>
        /// <returns></returns>

        public DataTable LayDSBoPhan(string tenSP)
        {
            try
            {
                _conn.Open();
                cmdBoPhan = new SqlCommand(tenSP, _conn);
                cmdBoPhan.CommandType = CommandType.StoredProcedure;
                daBoPhan = new SqlDataAdapter(cmdBoPhan);
                dtBoPhan = new DataTable();
                daBoPhan.Fill(dtBoPhan);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return dtBoPhan;
        }
        /// <summary>
        /// Thêm Bộ phận vào database
        /// </summary>
        /// <param name="et">Class Bộ phận</param>
        /// <returns></returns>
        public bool ThemBoPhan(ET_BoPhan et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                if (string.IsNullOrEmpty(et.MaQL))
                {
                    cmdBoPhan = new SqlCommand("sp_ThemBoPhanKhCoQL", _conn);
                } else
                {
                    cmdBoPhan = new SqlCommand("sp_ThemBoPhan", _conn);
                }
               
                cmdBoPhan.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmdBoPhan.Parameters.Add(new SqlParameter("@MaBP", et.MaBP));
                cmdBoPhan.Parameters.Add(new SqlParameter("@TenBP", et.TenBP));
                cmdBoPhan.Parameters.Add(new SqlParameter("@SDT", et.SoDT));
                if (!string.IsNullOrEmpty(et.MaQL))
                {
                    cmdBoPhan.Parameters.Add(new SqlParameter("@MaQL", et.MaQL));
                }
                if (cmdBoPhan.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        /// <summary>
        /// Sửa lại Bộ phận 
        /// </summary>
        /// <param name="et">class Bộ phận</param>
        /// <returns></returns>
        public bool SuaBoPhan(ET_BoPhan et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmdBoPhan = new SqlCommand("sp_SuaBoPhan", _conn);
                cmdBoPhan.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmdBoPhan.Parameters.Add(new SqlParameter("@MaBP", et.MaBP));
                cmdBoPhan.Parameters.Add(new SqlParameter("@TenBP", et.TenBP));
                cmdBoPhan.Parameters.Add(new SqlParameter("@SDT", et.SoDT));
                cmdBoPhan.Parameters.Add(new SqlParameter("@MaQL", et.MaQL));
                if (cmdBoPhan.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }

        /// <summary>
        /// Xoá bộ Phận
        /// </summary>
        /// <param name="et">Mã bộ phận cần xoá</param>
        /// <returns></returns>
        public bool XoaBoPhan(string et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmdBoPhan = new SqlCommand();
                cmdBoPhan.CommandType = CommandType.StoredProcedure;
                cmdBoPhan.CommandText = "sp_XoaBoPhan";
                cmdBoPhan.Connection = _conn;
                //them tham so
                cmdBoPhan.Parameters.Add(new SqlParameter("@MaBP", et));
                if (cmdBoPhan.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        /// <summary>
        /// Kiểm tra Bộ phận có chưa
        /// </summary>
        /// <param name="et">class bộ phận</param>
        /// <returns></returns>
        public bool CheckTonTai(ET_BoPhan et)
        {
            dtBoPhan = null;
            try
            {
                _conn.Open();
                cmdBoPhan = new SqlCommand("sp_TimBoPhan", _conn);
                cmdBoPhan.CommandType = CommandType.StoredProcedure;
                cmdBoPhan.Parameters.Add(new SqlParameter("@MaBP", et.MaBP));
                daBoPhan = new SqlDataAdapter(cmdBoPhan);
                dtBoPhan = new DataTable();
                daBoPhan.Fill(dtBoPhan);
                if (dtBoPhan.Rows.Count > 0)
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
                _conn.Close();
            }
            return false;
        }
    }
}
