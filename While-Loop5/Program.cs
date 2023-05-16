using System;
using System.Threading;

namespace While_Loop5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            int num = 0;
            double totalNum = 0;

            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());    
                totalNum += num;
            }
            Console.WriteLine($"{totalNum/n:f2}");
        }
    }
}
