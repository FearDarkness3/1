using System.Collections.Generic;

namespace Supermarket
{
    interface ISupermarket
    {        
        void AddToCart(Product prod, double amount);
        void Cashier(Cart cart, DiscountCard card);
        List<Product> ListOfProducts { get; set; }
        Cart GetCart();
    }
}
