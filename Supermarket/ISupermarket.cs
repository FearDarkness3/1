using System.Collections.Generic;

namespace Supermarket
{
    interface ISupermarket
    {
        void AddToCart(string productName, double amount);
        void CheckOut(DiscountCard card);
        void DisplayProductList();
    }
}
