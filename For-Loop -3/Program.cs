using System;

namespace For_Loop__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cargoCount = int.Parse(Console.ReadLine());
            int tonsBus = 0;
            int tonsTruck = 0;
            int tonsTrain = 0;
            double totalTons = 0;
            int cargoWeight = 0;

            for (int cargo = 1; cargo <= cargoCount; cargo++)
            {
                cargoWeight = int.Parse(Console.ReadLine());


                if (cargoWeight <= 3)
                {
                    tonsBus += cargoWeight;
                    totalTons += cargoWeight;

                }
                else if (cargoWeight <= 11)
                {
                    tonsTruck += cargoWeight;
                    totalTons += cargoWeight;
                }
                else
                {
                    tonsTrain += cargoWeight;
                    totalTons += cargoWeight;
                }

            }
                double averagePricePerTon = (tonsTrain * 120 + tonsBus * 200 + tonsTruck * 175) / totalTons;
            Console.WriteLine($"{averagePricePerTon:f2}");
            Console.WriteLine($"{tonsBus / totalTons * 100:f2}%");
            Console.WriteLine($"{tonsTruck / totalTons * 100:f2}%");
            Console.WriteLine($"{tonsTrain / totalTons * 100:f2}%");

        }
    }
}
