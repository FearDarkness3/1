using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Supermarket
{
    class Billa : ISupermarket
    {
        public List<Product> ListOfProducts { get; private set; }
        private readonly List<string> _discountProductList = new List<string>();
        public List<string> ProductNameList { get; private set; }

        private readonly List<Apiece> _apieceList = new List<Apiece>();
        private readonly List<ByWeight> _byWeightList = new List<ByWeight>();

        public Cart Cart;
        public Billa()
        {
            Cart = new Cart();
            ListOfProducts = new List<Product>();

            CreateSupermarketProductsList();
            CreateDiscountProposition();

            _apieceList.ForEach(AddToList);
            _byWeightList.ForEach(AddToList);

            CreateProductNameList();
        }
        private void CreateSupermarketProductsList()
        {
            _apieceList.Add(new Apiece("Black tea", 25, "general"));
            _apieceList.Add(new Apiece("Bread", 6, "general"));
            _apieceList.Add(new Apiece("Chocolate", 33, "general"));
            _apieceList.Add(new Apiece("Chips", 12, "general"));
            _apieceList.Add(new Apiece("Ketchup", 16, "general"));
            _apieceList.Add(new Apiece("Beer", 10, "alchohol"));
            _byWeightList.Add(new ByWeight("Cookies", 45, "general"));
            _byWeightList.Add(new ByWeight("Apple", 15, "general"));
            _byWeightList.Add(new ByWeight("Meat", 70, "general"));
            _byWeightList.Add(new ByWeight("Sausage", 58, "general"));
            _byWeightList.Add(new ByWeight("Fish", 64, "general"));
        }


        private void CreateDiscountProposition()
        {
            _discountProductList.Add("general");
            //Proposition.Add("alchohol");
        }
        /// <summary>
        /// This method checks if the supermarket has the specific profuct in its list
        /// </summary>
        /// <param name="prod">item is the item we are going to check</param>
        /// <returns></returns>
        private bool ListContains(Product prod)
        {
            return ListOfProducts.Contains(prod);
        }


        private void CreateProductNameList()
        {
            ProductNameList = new List<string>();

            ListOfProducts.ForEach(x => ProductNameList.Add(x.Name));
        }


        public Product GetProduct(string productName)
        {
            return ListOfProducts.Find(x => x.Name.ToLower() == productName.ToLower());
        }

        public void DisplayProductList()
        {
            Console.WriteLine("Products we have in store:\n");
            ProductNameList.ForEach(Console.WriteLine);
            Console.WriteLine();
        }
        private void AddToList(Product prod)
        {
            if (!ListOfProducts.Contains(prod))
            {
                ListOfProducts.Add(prod);
            }
        }
        private void RemoveFromList(Product prod)
        {
            if (ListOfProducts.Contains(prod))
            {
                ListOfProducts.Remove(prod);
            }
        }

        public void AddToCart(Product prod, double amount)
        {
            if (ListContains(prod))
            {
                Cart.AddProductToCart(prod, amount);
            }
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
            if (_discountProductList.Contains(category))
            {
                return 1;
            }

            return 0;
        }

        public void CheckOut(DiscountCard card)
        {
            double cost = 0;
            double discount = GetDiscount(card);

            foreach (var item in Cart.Products)
            {
                double currentItemCost = CalculateCostOfCartItem(item, discount);
                cost += currentItemCost;

                item.Key.PrintMessage(item.Value, currentItemCost);
            }

            Console.WriteLine("\nTotal Price = " + cost);
        }

        private double CalculateCostOfCartItem(KeyValuePair<Product, double> item, double discount)
        {
            Product currentProduct = item.Key;
            double amount = item.Value;

            double thisDiscount = discount * IsProposed(currentProduct.Category);
            double totalCost = currentProduct.PriceTotal(amount, thisDiscount);

            return totalCost;
        }
    }
}
