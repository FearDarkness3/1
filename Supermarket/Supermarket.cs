using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket
    {
        public Dictionary<string, Product> ListOfProducts = new Dictionary<string, Product>();
        public Dictionary<string, double> cart;
        public Supermarket()
        {
            cart = new Dictionary<string, double>();

            AddToList(new Apiece("Черный чай", 25));
            AddToList(new Apiece("Хлеб", 6));
            AddToList(new Apiece("Шоколадка", 33));
            AddToList(new Apiece("Чипсы", 12));
            AddToList(new Apiece("Кетчуп", 16));
            AddToList(new ByWeight("Печенье", 45));
            AddToList(new ByWeight("Яблоко", 15));
            AddToList(new ByWeight("Мясо", 70));
            AddToList(new ByWeight("Колбаса", 58));
            AddToList(new ByWeight("Рыба", 64));
        }
        public void AddToList(Product prod)
        {
            ListOfProducts.Add(prod.Name.ToLower(), prod);
        }

        public void RemoveFromList(Product prod)
        {
            ListOfProducts.Remove(prod.Name.ToLower());
        }

        public void AddToCart(string name, double amount)
        {
            cart.Add(name.ToLower(), amount);
        }
        public void PriceCalculator()
        {
            double price = 0;
            double temp = 0;

            foreach (var item in cart)
            {
                try
                {
                    if (ListOfProducts[item.Key] is Apiece)
                    {
                        temp = ListOfProducts[item.Key].Price * item.Value;
                        price += temp;

                        Console.WriteLine(item.Key + "\tx" + item.Value + "\t= " + temp);
                    }
                    else if (ListOfProducts[item.Key] is ByWeight)
                    {
                        // The calculation for products ByWeight is the same because we assume the amount we have is expressed in kilograms.
                        // The calculation will change if we express the amount in grams thats why we divide products by type.

                        temp = ListOfProducts[item.Key].Price * item.Value;
                        price += temp;

                        Console.WriteLine(item.Key + "\t" + item.Value + "kg " + "\t= " + temp);
                    }
                }
                catch (KeyNotFoundException)
                {
                    // this exception means there is no such product in this market so we dont need to pay for it
                    price += 0; // for clarity
                }
                
            }

            Console.WriteLine("\nСумма = " + price);
        }       
    }
}
