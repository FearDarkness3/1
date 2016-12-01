using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Supermarket
{
    class Billa : ISupermarket
    {
        public List<Product> Products { get; private set; }
        private readonly List<string> _discountProductList = new List<string>();
        
        public Cart Cart;
        public Billa()
        {
            Cart = new Cart();

            Products = CreateSupermarketProductsList();
            CreateDiscountProposition();
        }

        // Here better to return List<Product> and assign it in constructor OR return void and assign List<Product> in method?
        public List<Product> CreateSupermarketProductsList()
        {
            var wareHouse = new Warehouse();
            var supermarketProductsList = wareHouse.Products;

            return supermarketProductsList;
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
            return Products.Contains(prod);
        }

        private Product GetProduct(string productName)
        {
            return Products.Find(x => x.Name.ToLower() == productName.ToLower());
        }

        public void DisplayProductList()
        {
            Console.WriteLine("Products we have in store:\n");
            Products.ForEach(p => Console.WriteLine(p.Name));
            Console.WriteLine();
        }
        public void AddToCart(string productName, double amount)
        {
            Product prod = GetProduct(productName);

            if (prod != null)
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

                item.Product.PrintMessage(item.Amount, currentItemCost);
            }

            Console.WriteLine("\nTotal Price = " + cost);
        }

        private double CalculateCostOfCartItem(CartItem item, double discount)
        {
            Product currentProduct = item.Product;
            double amount = item.Amount;

            double thisDiscount = discount * IsProposed(currentProduct.Category);
            double totalCost = currentProduct.PriceTotal(amount, thisDiscount);

            return totalCost;
        }
    }
}
