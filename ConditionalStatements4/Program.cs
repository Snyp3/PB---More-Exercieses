using System;

namespace ConditionalStatements4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            //•	Такси.Начална такса: 0.70 лв.Дневна тарифа: 0.79 лв. / км.Нощна тарифа: 0.90 лв. / км.
            //•	Автобус.Дневна / нощна тарифа: 0.09 лв. / км.Може да се използва за разстояния минимум 20 км.
            //•	Влак.Дневна / нощна тарифа: 0.06 лв. / км.Може да се използва за разстояния минимум 100 км.
            double price = 0;
            if (distance < 20)
            {
                if (timeOfDay == "day")
                {
                    price = distance * 0.79 + 0.70;
                }
                else if (timeOfDay == "night")
                {
                    price = distance * 0.90 + 0.70;
                }
            }
            else if (distance < 100)
            {
                price = distance * 0.09;
            }
            else 
            {
                price = distance * 0.06;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
