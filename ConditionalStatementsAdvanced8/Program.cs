using System;

namespace ConditionalStatementsAdvanced8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = int.Parse(Console.ReadLine());
            int y1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y2 = int.Parse(Console.ReadLine());
            double x= double.Parse(Console.ReadLine());
            double y= double.Parse(Console.ReadLine());

            if( x1<x2 && y1<y2)
            {
                if((x == x1|| x == x2) &&  (y >= y1 &&  y <= y2))
                {
                    Console.WriteLine("Border");
                }                                        
                else if ((y == y1 || y == y2) && (x >= x1 && x <= x2))
                {
                    Console.WriteLine("Border");
                }
                else
                {
                    Console.WriteLine("Inside / Outside");
                }
            }
        }
    }
}
