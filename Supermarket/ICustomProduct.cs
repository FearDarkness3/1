using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    interface ICustomProduct
    {
        double PriceTotal(double amount);
        void PrintMessage(string name, double price, double cost);
    }
}
