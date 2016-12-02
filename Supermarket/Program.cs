using System;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            IRepository wh = new Warehouse();
            ISupermarket billa = new Billa(wh);
            DiscountCard goldenCard = new GoldenCard();

            billa.DisplayProductList();
            billa.AddToCart("Bread", 1);
            billa.AddToCart("meat", 2.2);
            billa.AddToCart("beer", 1);
            billa.AddToCart("chocolate", 1);
            billa.AddToCart("black tea", 4);
            billa.AddToCart("cookies", 3);
            billa.AddToCart("fish", 0.8);
            billa.AddToCart("sausage", 2);


            billa.CheckOut(goldenCard);
            Console.ReadLine();

        }
    }
}
