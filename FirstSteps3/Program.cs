using System;

namespace FirstSteps3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = double.Parse(Console.ReadLine());
            double f = c * 9/5 + 32;
            Console.WriteLine("{0:F2}",f);
        }
    }
}
