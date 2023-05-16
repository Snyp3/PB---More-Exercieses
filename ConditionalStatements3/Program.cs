using System;

namespace ConditionalStatements3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grape = int.Parse(Console.ReadLine());
            double grapeSquareM = double.Parse(Console.ReadLine());
            int wineNeedet = int.Parse(Console.ReadLine());
            int workerCount = int.Parse(Console.ReadLine());

            double totalGrape = grape * grapeSquareM;
            double wineLiters = (totalGrape*0.4) / 2.5;         

            //•	Ако произведеното вино е по-малко от нужното:
            //            o   “”
            //            
            if (wineLiters >= wineNeedet)
            {
                double wineLeft = wineLiters - wineNeedet ;
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wineLiters)} liters.");
                Console.WriteLine($"{Math.Ceiling(wineLeft)} liters left -> {Math.Ceiling(wineLeft / workerCount)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(wineNeedet - wineLiters)} liters wine needed.");
                
            }

        }
    }
}
