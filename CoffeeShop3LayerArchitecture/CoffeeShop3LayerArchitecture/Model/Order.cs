using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop3LayerArchitecture.Model
{
    public class Order
    {
        public string Name { set; get; }
        public string Item { set; get; }
        public int Quantity { set; get; }
        public double TotalPrice { set; get; }
        public string SearchName { set; get; }
        public int Id { set; get; }
    }
}
