using System;

namespace Supermarket
{
    class ByWeight : Product
    {
        public ByWeight(string name, int price, string category) : base(name, price, category)
        {

        }
        
        public override void PrintMessage(Product prod, double cost)
        {
            Console.WriteLine(prod.Name + "\t" + prod.Price + "kg " + "\t= " + cost); 
        }
        /* 
         * specific data about products which sell by weight
        */
    }
}