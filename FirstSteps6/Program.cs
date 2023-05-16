using System;

namespace FirstSteps6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceMackerel = double.Parse(Console.ReadLine()); // скумрия
            double priceSprinkle = double.Parse(Console.ReadLine()); // цаца
            double kgBenito = double.Parse(Console.ReadLine());   // паламуд
            double kgSafrid = double.Parse(Console.ReadLine()); 
            int clam = int.Parse(Console.ReadLine());

            double priceBenito = priceMackerel + priceMackerel * 0.60;
            double priceSafrid = priceSprinkle + priceSprinkle * 0.80;
            double priceClam = clam * 7.50;
            double totalBenito = kgBenito * priceBenito;
            double totalSafrid = kgSafrid * priceSafrid;

            Console.WriteLine("{0:F2}",   totalSafrid + priceClam  + totalBenito);


        }
    }
}
