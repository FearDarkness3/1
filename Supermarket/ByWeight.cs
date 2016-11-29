using System;

namespace Supermarket
{
    class ByWeight : Product
    {
        public ByWeight(string name, int price, string category) : base(name, price, category)
        {

        }
        public override double PriceTotal(double amount, double discount)
        {
            return Price * amount * (1 - discount * 0.01);
        }

        public override void PrintMessage(string name, double price, double cost)
        {
            Console.WriteLine(name + "\t" + price + "kg " + "\t= " + cost); 
        }
        /* 
         * specific data about products which sell by weight
        */
    }
}