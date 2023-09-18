﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_Shop.Model
{
    
    public class Account
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlPastaShop"].ConnectionString;

        public string Username { get;set; }
        public string Password { get;set; }
        public virtual bool Insert()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_customer";
                cmd.Parameters.AddWithValue("@pUsername", Username);
                cmd.Parameters["@pUsername"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pPassword", Password);
                cmd.Parameters["@pPassword"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@pStatus", MySqlDbType.Int32);
                cmd.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int success = Convert.ToInt32(cmd.Parameters["@pStatus"].Value);
                if (success == 1)
                    return true;
            }
            catch (MySqlException ex)
            {
                Trace.WriteLine(ex.Message + ex.StackTrace);
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return false;
        }
        //public virtual bool Update(Account account);
        //public virtual bool Delete(Account account);

        //public DataTable Select()
        //{
        //    MySqlConnection conn = new MySqlConnection(connectionString);
        //    DataTable dt = new DataTable();
        //    try
        //    {
        //        string query = "SELECT Username FROM pasta_shop.account";
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        MySqlDataReader reader = cmd.ExecuteReader();
        //        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
        //        conn.Open();
        //        adapter.Fill(dt);
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //    return dt;
        //}

        //public bool Delete(Account account)
        //{
        //    bool isSuccess = false;
        //    MySqlConnection conn = new MySqlConnection(connectionString);
        //    try
        //    {
        //        string query = "DELETE FROM pasta_shop.account WHERE Username=@Username";
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        cmd.Parameters.AddWithValue("Username",account.Username);
        //        conn.Open();
        //        int rows = cmd.ExecuteNonQuery();
        //        if (rows > 0)
        //        {
        //            isSuccess = true;
        //        }
        //        else
        //        {
        //            isSuccess = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    finally
        //    {
        //        conn.Close ();
        //    }
        //    return isSuccess;
        //}
        //public bool Update(Account account) 
        //{ 
        //    bool isSuccess = false;
        //    MySqlConnection conn = new MySqlConnection("Server=localhost;Database=pasta_shop;UserId = student; Password=studentana1*;");
        //    try
        //    {
        //        string query = "UPDATE pasta_shop.account SET Username=@Username, Password=@Password WHERE ";
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //    }
        //    catch(Exception ex)
        //    {

        //    }
        //   finally 
        //    { 
        //        conn.Close();
        //    }
        //    return isSuccess;
        //}
    }
}
