using System;
using System.Threading.Tasks;

namespace ConditionalStatements7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelTipe = Console.ReadLine();
            int fuelInCar = int.Parse(Console.ReadLine());

            if (fuelTipe == "Diesel")      // fuelTipe == "Gasoline" || fuelTipe == "Gas")
            {
                if (fuelInCar >= 25)
                {
                    Console.WriteLine("You have enough diesel.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with diesel!");
                }
            }
            else if (fuelTipe == "Gasoline")
            {
                if (fuelInCar >= 25)
                {
                    Console.WriteLine("You have enough gasoline.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gasoline!");
                }
            }
            else if (fuelTipe == "Gas")
            {
                if (fuelInCar >= 25)
                {
                    Console.WriteLine("You have enough gas.");
                }
                else
                {
                    Console.WriteLine("Fill your tank with gas!");
                }

            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
        }
    }
}
