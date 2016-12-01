using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class CartItem
    {
        public Product Product { get; protected set; }
        public Double Amount { get; set; }

        public CartItem(Product prod, double amount)
        {
            Product = prod;
            Amount = amount;
        }
    }
}
