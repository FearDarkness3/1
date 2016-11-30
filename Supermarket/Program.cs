using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            ISupermarket billa = new Billa();
            DiscountCard goldenCard = new GoldenCard();

            billa.DisplayProductList();
            var temp = billa.GetProduct("Bread");
            billa.AddToCart(billa.GetProduct("Bread"), 1.5);
            billa.AddToCart(billa.GetProduct("meat"), 2.2);
            billa.AddToCart(billa.GetProduct("beer"), 1);
            billa.AddToCart(billa.GetProduct("chocolate"), 1);
            billa.AddToCart(billa.GetProduct("black tea"), 4);
            billa.AddToCart(billa.GetProduct("cookies"), 3);
            billa.AddToCart(billa.GetProduct("fish"), 0.8);
            billa.AddToCart(billa.GetProduct("sausage"), 2);


            billa.CheckOut(goldenCard);
            Console.ReadLine();

        }
    }
}
