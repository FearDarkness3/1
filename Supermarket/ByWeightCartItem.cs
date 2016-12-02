using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class ByWeightCartItem : CartItem
    {
        public double Amount { get; set; }

        public ByWeightCartItem(ByWeightProduct prod, double amount)
        {
            Product = prod;
            Amount = amount;
        }
        public override void PrintMessage(double amount, double cost)
        {
            Console.WriteLine(Product.Name + "\t\t" + amount + "kg " + "\t= " + cost);
        }
        public override double GetAmount()
        {
            return Amount;
        }
    }
}
