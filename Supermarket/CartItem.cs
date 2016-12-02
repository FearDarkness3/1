using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    abstract class CartItem
    {
        public Product Product { get; protected set; }

        public abstract double GetAmount();
        
        public abstract void PrintMessage(double amount, double cost);
    }
}
