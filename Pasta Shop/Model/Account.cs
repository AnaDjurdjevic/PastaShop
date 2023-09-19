using System.Configuration;

namespace Pasta_Shop.Model
{

    public abstract class Account
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["MySqlPastaShop"].ConnectionString;

        public string Username { get; set; }
        public string Password { get; set; }

        public static Account User;
        public abstract bool Insert();

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

    }
}
