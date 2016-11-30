using System.Collections.Generic;

namespace Supermarket
{
    interface ISupermarket
    {
        void AddToCart(Product prod, double amount);
        void CheckOut(DiscountCard card);
        List<string> ProductNameList { get; }
        void DisplayProductList();
        Product GetProduct(string productName);
    }
}
