using System;

namespace Supermarket
{
    public class Apiece : Product
    {
        public Apiece(string name, int price, string category) : base(name, price, category)
        {

        }
        
        public override void PrintMessage(Product prod, double cost)
        {
            Console.WriteLine(prod.Name + "\tx" + prod.Price + "\t= " + cost);
        }

        /* 
         * specific data about products which sell apiece
        */
    }
}