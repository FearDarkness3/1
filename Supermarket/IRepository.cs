using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    interface IRepository
    {
        List<Product> GetAllProducts();
        Product GetProduct(string prodName);
        void DisplayProductList();
    }
}
