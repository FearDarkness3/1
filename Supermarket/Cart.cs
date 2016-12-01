using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Cart
    {
        public List<CartItem> Products { get; set; }

        public Cart()
        {
            Products = new List<CartItem>();
        }
        public void AddProductToCart(Product prod, double amount)
        {
            if (prod is ByWeight)
            {
                Products.Add(new CartItem(prod, amount));
            }
            else
            {
                try
                {
                    if (amount % 1 == 0)
                    {
                        Products.Add(new CartItem(prod, amount));
                    }
                    else
                    {
                        throw new ArgumentException("amount argument should be integer for products of Apiece type");
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("Wrong input! Please, use integer value for input.");
                }
            }
            
        }

        public void RemoveProductFromCart(CartItem cartItem)
        {
            if (Products.Contains(cartItem))
            {
                Products.Remove(cartItem);
            }
        }
    }
}
