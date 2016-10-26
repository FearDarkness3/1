using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Supermarket : ISupermarket, ICustomList
    {
        private Dictionary<string, Product> ListOfProducts = new Dictionary<string, Product>();
        public Dictionary<string, double> cart;

        private List<Apiece> ApieceList = new List<Apiece>();
        private List<ByWeight> ByWeightList = new List<ByWeight>();


        public Supermarket()
        {
            cart = new Dictionary<string, double>();

            CreateSupermarketProductsList();

            ApieceList.ForEach(x => AddToList(x));
            ByWeightList.ForEach(x => AddToList(x));
            //AddToList(new Apiece("Черный чай", 25));
            //AddToList(new Apiece("Хлеб", 6));
            //AddToList(new Apiece("Шоколадка", 33));
            //AddToList(new Apiece("Чипсы", 12));
            //AddToList(new Apiece("Кетчуп", 16));
            //AddToList(new ByWeight("Печенье", 45));
            //AddToList(new ByWeight("Яблоко", 15));
            //AddToList(new ByWeight("Мясо", 70));
            //AddToList(new ByWeight("Колбаса", 58));
            //AddToList(new ByWeight("Рыба", 64));
        }
        private void CreateSupermarketProductsList()
        {
            ApieceList.Add(new Apiece("Черный чай", 25));
            ApieceList.Add(new Apiece("Хлеб", 6));
            ApieceList.Add(new Apiece("Шоколадка", 33));
            ApieceList.Add(new Apiece("Чипсы", 12));
            ApieceList.Add(new Apiece("Кетчуп", 16));
            ByWeightList.Add(new ByWeight("Печенье", 45));
            ByWeightList.Add(new ByWeight("Яблоко", 15));
            ByWeightList.Add(new ByWeight("Мясо", 70));
            ByWeightList.Add(new ByWeight("Колбаса", 58));
            ByWeightList.Add(new ByWeight("Рыба", 64));
        }
        public bool ListContains(string item)
        {
            // This method checks if supermarket has the specific product in its ProductList
            return ListOfProducts.ContainsKey(item);
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
        public void CostCalculator()
        {
            double cost = 0;
            double temp = 0;

            foreach (var item in cart)
            {
                if (ListContains(item.Key))
                {
                    temp = ListOfProducts[item.Key].PriceTotal(item.Value);
                    cost += temp;

                    ListOfProducts[item.Key].PrintMessage(item.Key, item.Value, temp);
                }
            }

            Console.WriteLine("\nСумма = " + cost);
        }
    }
}
