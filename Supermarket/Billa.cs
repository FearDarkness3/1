using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Supermarket
{
    class Billa : ISupermarket
    {
        public List<Product> Products { get; private set; }
        private readonly List<string> _discountProductList = new List<string>();
        public IRepository Warehouse { get; private set; }

        public Cart Cart;
        public Billa(IRepository warehouse)
        {
            Cart = new Cart();
            Warehouse = warehouse;
            CreateSupermarketProductsList(warehouse);
            CreateDiscountProposition();
        }

        public void CreateSupermarketProductsList(IRepository warehouse)
        {
            Products = warehouse.GetAllProducts();
        }

        private void CreateDiscountProposition()
        {
            _discountProductList.Add("general");
            //Proposition.Add("alchohol");
        }
        public void DisplayProductList()
        {
            Warehouse.DisplayProductList();
        }
        public void AddToCart(string productName, double amount)
        {
            Product prod = Warehouse.GetProduct(productName);

            if (prod != null)
            {
                try
                {
                    if (prod is ByWeightProduct)
                    {
                        var convertedProd = (ByWeightProduct)prod;
                        Cart.AddByWeightProductToCart(convertedProd, amount);
                    }
                    else if (prod is ApieceProduct && amount % 1 == 0)
                    {
                        var convertedProd = (ApieceProduct)prod;
                        int intAmount = (int)amount;
                        Cart.AddApieceProductToCart(convertedProd, intAmount);
                    }
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The amount for ApieceProduct product should be int");
                }
            }
        }
        public void CheckOut(DiscountCard card)
        {
            double cost = 0;
            double discount = GetDiscount(card);

            foreach (var item in Cart.Products)
            {
                double currentItemCost = CalculateCostOfCartItem(item, discount);
                cost += currentItemCost;

                CheckMessage(item, currentItemCost);
            }

            Console.WriteLine("\nTotal Price = " + cost);
        }
        private void CheckMessage(CartItem item, double cost)
        {
            double amount = item.GetAmount();
            item.PrintMessage(amount, cost);
        }

        private double CalculateCostOfCartItem(CartItem item, double discount)
        {
            Product currentProduct = item.Product;
            double amount = item.GetAmount();

            double thisDiscount = discount * IsProposed(currentProduct.Category);
            double totalCost = currentProduct.PriceTotal(amount, thisDiscount);

            return totalCost;
        }
        private bool ListContains(Product prod)
        {
            return Products.Contains(prod);
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
    }
}
