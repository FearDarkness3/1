using System;

namespace Supermarket
{
    class ByWeight : Product
    {
        public ByWeight(string name, int price, string category) : base(name, price, category)
        {

        }
        
        public override void PrintMessage(double amount, double cost)
        {
            Console.WriteLine(Name + "\t\t" + amount + "kg " + "\t= " + cost); 
        }
        /* 
         * specific data about products which sell by weight
        */
    }
}