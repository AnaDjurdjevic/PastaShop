using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pasta_Shop.Model
{
    internal class Item
    {
        public double Quantity { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }
        public Pasta Pasta { get; set; }

        public Item() 
        {
            Pasta = new Pasta();
        }
    }
}
