namespace Supermarket
{
    interface ICustomProduct
    {
        double PriceTotal(double amount, double discount);
        void PrintMessage(string name, double price, double cost);
    }
}
