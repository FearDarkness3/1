namespace Supermarket
{
    interface ISupermarket
    {        
        void AddToCart(Product prod, double amount);
        void CostCalculator(Cart cart, DiscountCard card);
    }
}
