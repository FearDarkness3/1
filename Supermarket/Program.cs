using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermarket billa = new Supermarket();
            DiscountCard goldenCard = new DiscountCard(5);

            billa.AddToCart(billa.ListOfProducts[8], 1.5);
            billa.AddToCart(billa.ListOfProducts[10], 2.2);
            billa.AddToCart(billa.ListOfProducts[1], 1);
            billa.AddToCart(billa.ListOfProducts[2], 1);
            billa.AddToCart(billa.ListOfProducts[5], 4);
            billa.AddToCart(billa.ListOfProducts[3], 3);
            billa.AddToCart(billa.ListOfProducts[7], 0.8);
            billa.AddToCart(billa.ListOfProducts[9], 2);


            billa.CostCalculator(billa.Cart, goldenCard);
            Console.ReadLine();

        }
    }
}
