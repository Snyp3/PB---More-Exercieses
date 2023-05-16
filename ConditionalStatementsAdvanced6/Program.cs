using System;

namespace ConditionalStatementsAdvanced6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double kmForMonth = double.Parse(Console.ReadLine());

            double pricePerKm = 0;
            if (kmForMonth <= 5000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.75;
                        break;
                    case "Summer":
                        pricePerKm = 0.90;
                        break;
                    case "Winter":
                        pricePerKm = 1.05;
                        break;

                }

            }
            else if (kmForMonth > 5000 && kmForMonth <= 10000)
            {
                switch (season)
                {
                    case "Spring":
                    case "Autumn":
                        pricePerKm = 0.95;
                        break;
                    case "Summer":
                        pricePerKm = 1.10;
                        break;
                    case "Winter":
                        pricePerKm = 1.25;
                        break;

                }
            }
            else if (kmForMonth > 10000 && kmForMonth <= 20000)
            {
                 switch(season)
                {
                    case "Spring":
                    case "Autumn":
                    case "Summer":
                    case "Winter":
                        pricePerKm = 1.45;
                        break;
                }
            }
            double totalEarn = kmForMonth * pricePerKm * 4;
            double afterTax = totalEarn - totalEarn * 0.10;

            Console.WriteLine($"{afterTax:F2}");




        }
    }
}
