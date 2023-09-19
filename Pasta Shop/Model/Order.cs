using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_Shop.Model
{
    internal class Order
    {
        public int ConfirmationNumber { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public Customer Customer { get; set; }
    }
}
