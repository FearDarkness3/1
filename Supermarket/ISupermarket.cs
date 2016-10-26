using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    interface ISupermarket
    {        
        void AddToCart(string name, double amount);
        void CostCalculator();
    }
}
