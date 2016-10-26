using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    interface ICustomList
    {
        void AddToList(Product prod);
        void RemoveFromList(Product prod);
        bool ListContains(string item);
    }
}
