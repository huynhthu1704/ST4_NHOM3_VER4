﻿///Đức Trí
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
    public class DAL_NCC
    {
        private SqlConnection _conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DAL_NCC()
        {
            _conn = Connection.conn;
        }
        public DataTable LayDSNCC()
        {

            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_DSNCC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (SqlException)
            {

            }
            finally
            {
                _conn.Close();
            }
            return dt;
        }

        public bool ThemNCC(ET_NCC et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_ThemNCC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@TenNCC", et.TenNCC));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", et.Email));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool SuaNCC(ET_NCC et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_SuaNCC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et.MaNCC));
                cmd.Parameters.Add(new SqlParameter("@TenNCC", et.TenNCC));
                cmd.Parameters.Add(new SqlParameter("@DiaChi", et.DiaChi));
                cmd.Parameters.Add(new SqlParameter("@SDT", et.SDT));
                cmd.Parameters.Add(new SqlParameter("@Email", et.Email));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }

        public bool XoaNCC(string et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_XoaNCC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et));
                if (cmd.ExecuteNonQuery() > 0)
                {
                    flag = true;
                }
            }
            catch (SqlException)
            {
            }
            finally
            {
                _conn.Close();
            }
            return flag;
        }
        public bool CheckTonTai(ET_NCC et)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimNCC", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaNCC", et.MaNCC));
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
            }
            catch (SqlException)
            {

            }
            finally
            {
                _conn.Close();
            }
            return false;
        }
    }
}
