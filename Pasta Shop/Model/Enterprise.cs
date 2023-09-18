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
    internal class Enterprise:Customer
    {
        public String JIB { get;set; }
        public String Name { get;set; }

        private static readonly string INSERT = @"INSERT INTO `enterprise`(JIB,Name,CUSTOMER_ACCOUNT_Username) VALUES (@pJIB, @pName,@pUsername)";
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
                    cmd.Parameters.AddWithValue("@pJIB", JIB);                    
                    cmd.Parameters.AddWithValue("@pName", Name);                    
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
