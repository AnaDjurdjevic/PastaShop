using MySql.Data.MySqlClient;
using System;
using System.Data;
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
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_individual";
                cmd.Parameters.AddWithValue("@pPostNumber", Location.PostNumber);
                cmd.Parameters["@pPostNumber"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pLocationName", Location.Name);
                cmd.Parameters["@pLocationName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pAddress", Address);
                cmd.Parameters["@pAddress"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pTelephone", Telephone);
                cmd.Parameters["@pTelephone"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pUsername", Username);
                cmd.Parameters["@pUsername"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pPassword", Password);
                cmd.Parameters["@pPassword"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pFirstName", FirstName);
                cmd.Parameters["@pFirstName"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pLastName", LastName);
                cmd.Parameters["@pLastName"].Direction = ParameterDirection.Input;
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
    }
}
