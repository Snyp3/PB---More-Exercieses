using System;

namespace ConditionalStatements6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magnolias = int.Parse(Console.ReadLine());
            int hyacinth = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactus = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            //•	Магнолии – 3.25 лева
            //•	Зюмбюли – 4 лева
            //•	Рози – 3.50 лева
            //•	Кактуси – 8 лева

            double priceMagnolias = magnolias * 3.25;
            double priceHyacinth = hyacinth * 4;
            double priceRoses = roses * 3.50;
            double priceCactus = cactus * 8;

            double totalPrice = priceMagnolias + priceHyacinth + priceRoses + priceCactus;
            double totalTax = totalPrice * 0.05;

            double totalEarn =totalPrice - totalTax;

            if (totalEarn >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(totalEarn - giftPrice)} leva.");
            }
            else
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(giftPrice - totalEarn)} leva.");
            }



        }
    }
}
