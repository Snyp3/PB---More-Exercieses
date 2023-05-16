using System;

namespace For_Loop__7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxStadionSeats = int.Parse(Console.ReadLine());
            int totalFans = int.Parse(Console.ReadLine());

            double countA = 0;
            double countB = 0;
            double countV = 0;
            double countG = 0;

            for (int fan = 0; fan < totalFans; fan++)
            {
                string sector = Console.ReadLine();

                if (sector == "A")
                {
                    countA++;
                }
                else if (sector == "B")
                {
                    countB++;
                }
                else if(sector == "V")
                {
                    countV++;
                }
                else if (sector == "G")
                {
                    countG++;
                }
                    
            }
            double stadionOccupied = countA + countB + countV + countG;
            Console.WriteLine($"{countA / totalFans * 100:f2}%");
            Console.WriteLine($"{countB / totalFans * 100:f2}%");
            Console.WriteLine($"{countV / totalFans * 100:f2}%");
            Console.WriteLine($"{countG / totalFans * 100:f2}%");
            Console.WriteLine($"{stadionOccupied / maxStadionSeats * 100:f2}%");
        }
    }
}
