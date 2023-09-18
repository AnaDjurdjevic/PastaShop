using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;

namespace Pasta_Shop.Model
{
    internal class Individual : Customer
    {
        public String FirstName { get; set; }
        public String LastName { get; set; }

        private static readonly string INSERT = @"INSERT INTO `individual`(FirstName,LastName,CUSTOMER_ACCOUNT_Username) VALUES (@pFirstName, @pLastName,@pUsername)";
        public override bool Insert()
        {
            if (base.Insert())
            {
                MySqlConnection conn = null;
                MySqlCommand cmd;
                try
                {
                    conn = MySqlUtil.GetConnection();
                    cmd = conn.CreateCommand();
                    cmd.CommandText = INSERT;
                    cmd.Parameters.AddWithValue("@pUsername", Username);
                    cmd.Parameters.AddWithValue("@pFirstName", FirstName);
                    cmd.Parameters.AddWithValue("@pLastName", LastName);
                    cmd.ExecuteNonQuery();
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
            }
            return false;
        }
    }
}
