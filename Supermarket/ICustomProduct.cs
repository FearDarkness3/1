namespace Supermarket
{
    interface ICustomProduct
    {
        double PriceTotal(double amount, double discount);
        void PrintMessage(Product product, double cost);
    }
}
