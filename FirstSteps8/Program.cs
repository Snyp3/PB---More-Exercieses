using System;

namespace FirstSteps8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r = double.Parse(Console.ReadLine());

            double calculatedArea = r * r * Math.PI;
            double calculatedParameter = 2 * Math.PI * r;

            Console.WriteLine("{0:F2}",calculatedArea);
            Console.WriteLine("{0:F2}",calculatedParameter);
        }
    }
}
