using System;

namespace Conditional_StatementsAdvanced4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string car = string.Empty;
            string classTipe = string.Empty;
            double carPrice = 0;

            if (budget <=  100)
            {
                classTipe = "Economy class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    carPrice = budget * 0.35;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    carPrice = budget * 0.65;
                }
            }
            else if ( budget > 100 && budget <= 500)
            {
                classTipe = "Compact Class";
                if (season == "Summer")
                {
                    car = "Cabrio";
                    carPrice = budget * 0.45;
                }
                else if (season == "Winter")
                {
                    car = "Jeep";
                    carPrice = budget * 0.80;
                }
            }
            else
            {
                classTipe = "Luxury class";
                car = "Jeep";
                carPrice = budget * 0.90;
            }
            Console.WriteLine(classTipe);
            Console.WriteLine($" {car} - {carPrice:F2}");
           

        }
    }
}
