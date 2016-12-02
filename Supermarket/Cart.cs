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
        public void AddApieceProductToCart(ApieceProduct prod, int amount)
        {
            Products.Add(new ApieceCartItem(prod, amount));
        }

        public void AddByWeightProductToCart(ByWeightProduct prod, double amount)
        {
            Products.Add(new ByWeightCartItem(prod, amount));
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
