using System;

namespace Supermarket
{
    public class Apiece : Product
    {
        public Apiece(string name, int price, string category) : base(name, price, category)
        {

        }

        public override double PriceTotal(double amount, double discount)
        {
            return Price * amount * (1 - discount * 0.01);
        }

        public override void PrintMessage(string name, double price, double cost)
        {
            Console.WriteLine(name + "\tx" + price + "\t= " + cost);
        }

        /* 
         * specific data about products which sell apiece
        */
    }
}