﻿/// Đức Trí
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
    public class DAL_Kho
    {
        private SqlConnection _conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        public DAL_Kho()
        {
            _conn = Connection.conn;
        }
        //method
        public DataTable LayDSKho()
        {

            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_DSKho", _conn);
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

        public bool ThemKho(ET_Kho et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_ThemKho", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
                cmd.Parameters.Add(new SqlParameter("@TenKho", et.TenKho));
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
        public bool SuaKho(ET_Kho et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_SuaKho", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
                cmd.Parameters.Add(new SqlParameter("@TenKho", et.TenKho));
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

        public bool XoaKho(String et)
        {
            bool flag = false;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_XoaKho", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //them tham so
                cmd.Parameters.Add(new SqlParameter("@MaKho", et));
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
        public bool CheckTonTai(ET_Kho et)
        {
            dt = null;
            try
            {
                _conn.Open();
                cmd = new SqlCommand("sp_TimKho", _conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@MaKho", et.MaKho));
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
                _conn.Close();
            }
            return false;
        }
    }
}
