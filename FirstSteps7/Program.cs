using System;

namespace FirstSteps7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());  
            double h = double.Parse(Console.ReadLine());

            double frontSide = ((x * x) * 2) - (1.2 * 2) ;
            double sideSide = ((x * y) * 2) - ((1.5 * 1.5)*2);
            double roofSide = ((x * y) * 2);
            double roofFront = ((x * h/2) * 2);

            double downSideTotal = frontSide + sideSide;
            double roofTotal = roofFront + roofSide;

            double paintGreen = downSideTotal / 3.4;
            double paintRed = roofTotal / 4.3;

            Console.WriteLine("{0:F2}", paintGreen);
            Console.WriteLine("{0:F2}", paintRed);
                


        }
    }
}
