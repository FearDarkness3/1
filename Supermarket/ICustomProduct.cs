namespace Supermarket
{
    interface ICustomProduct
    {
        double PriceTotal(double amount, double discount);
        void PrintMessage(double amount, double cost);
    }
}
