using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    /*
     * We have 2 types of products: 
     * 
     * 1.Apiece products have a set price for 1 unit;
     * 2.ByWeight products habe a set price for 1 kilogram of that product;
    */
    public abstract class Product
    {
        public string Name { get; private set; }
        public int Price { get; private set; }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }

    public class Apiece : Product
    {
        public Apiece(string name, int price) : base(name, price)
        {

        }
        
        /* 
         * specific data about products which sell apiece
        */
    }

    class ByWeight : Product
    {
        public ByWeight(string name, int price) : base(name, price)
        {

        }

        /* 
         * specific data about products which sell by weight
        */
    }
}
