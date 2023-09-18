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
    public abstract class Customer:Account
    {
        public String Address { get; set; }
        public String Telephone { get; set; }
        public Location Location { get; set; }

        public Customer() 
        { 
            Location = new Location();
        }
        public abstract override bool Insert();
    }

}
