using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Cart
    {
        public Dictionary<Product, double> Products { get; set; }

        public Cart()
        {
            Products = new Dictionary<Product, double>();
        }
        public void AddProductToCart(Product prod, double amount)
        {
            Products.Add(prod, amount);
        }

        public void RemoveProductFromCart(Product prod)
        {
            if (Products.ContainsKey(prod))
            {
                Products.Remove(prod);
            }
        }
    }
}
