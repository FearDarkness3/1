using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Supermarket billa = new Supermarket();
                        
            billa.AddToCart("Мясо", 1.5);
            billa.AddToCart("яБлОкО", 2.2);
            billa.AddToCart("хлеб", 1);
            billa.AddToCart("Зонтик", 1);
            billa.AddToCart("Чипсы", 3);
            billa.AddToCart("РыБа", 0.8);
            billa.AddToCart("Ноутбук", 2);

            billa.PriceCalculator();

            Console.ReadLine();

        }
    }
}
