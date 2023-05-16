using System;

namespace ConditionalStatementsAdvanced10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            while (input >= 0)
            {
                Console.WriteLine($"Result: {input * 2:F2}");
                input = double.Parse(Console.ReadLine());  
            }

            Console.WriteLine("Negative number!");
        }
    }
}
