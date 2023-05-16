using System;

namespace ConditionalStatementsAdvanced1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string category = Console.ReadLine();
            int groupCount = int.Parse(Console.ReadLine());

            double ticketPrice = 0;
            double travelPrice = 0;
            if (category == "VIP" )
            {
                ticketPrice = 499.99;
            }
            else if (category == "Normal")
            {
                ticketPrice = 249.99;
            }
            ticketPrice = ticketPrice * groupCount;
            if (groupCount <= 4)
            {
                travelPrice = budget - budget * 0.25;
            }
            else if (groupCount <= 9)
            {
                travelPrice = budget - budget * 0.40;
            }
            else if (groupCount <= 24) 
            {
                travelPrice = budget - budget * 0.50;
            }
            else if (groupCount <= 49)
            {
                travelPrice = budget - budget * 0.60;
            }
            else if (groupCount >= 50)
            {
                travelPrice = budget - budget * 0.75;
            }

            double totalPrice = travelPrice + ticketPrice;

            if (budget > totalPrice)
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Yes! You have {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeedet = totalPrice - budget;
                Console.WriteLine($"Not enough money! You need {moneyNeedet:f2} leva.");
            }
          


        }
    }
}
