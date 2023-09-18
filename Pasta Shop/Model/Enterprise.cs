using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Diagnostics;
using Org.BouncyCastle.Utilities.Collections;

namespace Pasta_Shop.Model
{
    internal class Enterprise : Customer
    {
        public String JIB { get; set; }
        public String Name { get; set; }

        private static readonly string INSERT = @"INSERT INTO `enterprise`(JIB,Name,CUSTOMER_ACCOUNT_Username) VALUES (@pJIB, @pName,@pUsername)";
        public override bool Insert()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_enterprise";
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
                cmd.Parameters.AddWithValue("@pJIB", JIB);
                cmd.Parameters["@pJIB"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pName", Name);
                cmd.Parameters["@pName"].Direction = ParameterDirection.Input;
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