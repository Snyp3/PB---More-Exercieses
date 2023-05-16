using System;

namespace ConditionalStatementsAdvanced5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string location = string.Empty;
            string placeToRest;
            double price = 0;

            if (budget <= 1000)
            {
                placeToRest = "Camp";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.65;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.45;
                }

            }
            else if (budget > 1000 && budget <= 3000)
            {
                placeToRest = "Hut";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.80;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.60;
                }

            }
            else
            {
                placeToRest = "Hotel";
                if (season == "Summer")
                {
                    location = "Alaska";
                    price = budget * 0.90;
                }
                else if (season == "Winter")
                {
                    location = "Morocco";
                    price = budget * 0.90;
                }
            }
            Console.WriteLine($"{location} - {placeToRest} - {price:F2}");
        }
    }
}
