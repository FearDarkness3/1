using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class ApieceCartItem : CartItem
    {
        public int Amount { get; set; }

        public ApieceCartItem(ApieceProduct prod, int amount)
        {
            Product = prod;
            Amount = amount;
        }
        public override void PrintMessage(double amount, double cost)
        {
            Console.WriteLine(Product.Name + "\t\tx" + amount + "\t= " + cost);
        }

        public override double GetAmount()
        {
            return Amount;
        }
    }
}
