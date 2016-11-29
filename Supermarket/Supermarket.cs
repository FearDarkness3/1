using System;
using System.Collections.Generic;

namespace Supermarket
{
    class Supermarket : ISupermarket, ICustomList
    {
        public readonly List<Product> ListOfProducts = new List<Product>();
        public Cart Cart;
        private readonly List<string> _proposition = new List<string>();

        private readonly List<Apiece> _apieceList = new List<Apiece>();
        private readonly List<ByWeight> _byWeightList = new List<ByWeight>();


        public Supermarket()
        {
            Cart = new Cart();
            
            CreateSupermarketProductsList();
            CreateProposition();

            _apieceList.ForEach(AddToList);
            _byWeightList.ForEach(AddToList);
            
        }
        private void CreateSupermarketProductsList()
        {
            _apieceList.Add(new Apiece("Черный чай", 25, "general"));
            _apieceList.Add(new Apiece("Хлеб", 6, "general"));
            _apieceList.Add(new Apiece("Шоколадка", 33, "general"));
            _apieceList.Add(new Apiece("Чипсы", 12, "general"));
            _apieceList.Add(new Apiece("Кетчуп", 16, "general"));
            _apieceList.Add(new Apiece("Пиво", 10, "alchohol"));
            _byWeightList.Add(new ByWeight("Печенье", 45, "general"));
            _byWeightList.Add(new ByWeight("Яблоко", 15, "general"));
            _byWeightList.Add(new ByWeight("Мясо", 70, "general"));
            _byWeightList.Add(new ByWeight("Колбаса", 58, "general"));
            _byWeightList.Add(new ByWeight("Рыба", 64, "general"));
        }
        private void CreateProposition()
        {
            _proposition.Add("general");
            //Proposition.Add("alchohol");
        }
        /// <summary>
        /// This method checks if the supermarket has the specific profuct in its list
        /// </summary>
        /// <param name="prod">item is the item we are going to check</param>
        /// <returns></returns>
        public bool ListContains(Product prod)
        {
            return ListOfProducts.Contains(prod);
        }
        public void AddToList(Product prod)
        {
            ListOfProducts.Add(prod);
        }
        public void RemoveFromList(Product prod)
        {
            ListOfProducts.Remove(prod);
        }
        //Is this a good design? 
        public void AddToCart(Product prod, double amount)
        {
            Cart.AddProductToCart(prod, amount);
        }

        private double GetDiscount(DiscountCard card)
        {
            if (card.Valid)
            {
                return card.Discount;
            }

            return 0;
        }
        private int IsProposed(string category)
        {
            if (_proposition.Contains(category))
            {
                return 1;
            }

            return 0;
        }

        // repetition???
        //public void Cashier(Cart cart, double totalPrice)
        //{
            
        //}
        public void CostCalculator(Cart cart, DiscountCard card)
        {
            double cost = 0;
            double discount = GetDiscount(card);

            foreach (var item in cart.Products)
            {
                if (ListContains(item.Key))
                {
                    double thisDiscount = discount * IsProposed(item.Key.Category);     
                    var temp = item.Key.PriceTotal(item.Value, thisDiscount);
                    cost += temp;

                    item.Key.PrintMessage(item.Key.Name, item.Value, temp);
                }
            }

            Console.WriteLine("\nСумма = " + cost);
        }
    }
}
