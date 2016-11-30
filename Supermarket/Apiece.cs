using System;

namespace Supermarket
{
    public class Apiece : Product
    {
        public Apiece(string name, int price, string category) : base(name, price, category)
        {

        }
        
        public override void PrintMessage(double amount, double cost)
        {
            Console.WriteLine(Name + "\t\tx" + amount + "\t= " + cost);
        }

        /* 
         * specific data about products which sell apiece
        */
    }
}