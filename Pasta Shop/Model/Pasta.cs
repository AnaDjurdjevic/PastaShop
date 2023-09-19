using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_Shop.Model
{
    internal class Pasta
    {
        public int IdPasta { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double Quantity { get; set; }
        public Employee Employee { get; set; }
    }
}
