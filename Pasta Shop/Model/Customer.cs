using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pasta_Shop.Model
{
    public class Customer:Account
    {
        public String Address { get; set; }
        public String Telephone { get; set; }
        public Location Location;

        public override bool Insert()
        {
            MySqlConnection conn = null;
            MySqlCommand cmd;
            try
            {
                conn = MySqlUtil.GetConnection();
                cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "add_customer";
                cmd.Parameters.AddWithValue("@pUsername",Username);
                cmd.Parameters["@pUsername"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pAddress", Address);
                cmd.Parameters["@pAddress"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pTelephone", Telephone);
                cmd.Parameters["@pTelephone"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pPostNumber", Location);
                cmd.Parameters["@pPostNumber"].Direction = ParameterDirection.Input;
                cmd.Parameters.AddWithValue("@pLocationName", Location);
                cmd.Parameters["@pLocationName"].Direction = ParameterDirection.Input;
                cmd.Parameters.Add("@pStatus", MySqlDbType.Int32);
                cmd.Parameters["@pStatus"].Direction = ParameterDirection.Output;
                cmd.ExecuteNonQuery();
                int success = Convert.ToInt32(cmd.Parameters["@pStatus"].Value);
                if (success == 1)
                    return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                MySqlUtil.CloseQuietly(conn);
            }
            return false;
        }
    }

}
