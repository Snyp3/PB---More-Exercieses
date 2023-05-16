using System;
using System.Threading;

namespace For_Loop__8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int maxDiference = int.MinValue;
            
            int count = 0;
            int value = 0;
            int oldValue = 0;

            for (int i = 1; i <= number; i++)
            {
                
                int one = int.Parse(Console.ReadLine());
                int two = int.Parse(Console.ReadLine());
                value = one + two;

                if (i == 1)
                {
                    oldValue = value;
                }
                if (oldValue == value)
                {
                    count++;
                }
                else if (oldValue != value)
                {
                    if (i<number)
                    {
                        oldValue = value;
                    }
                    else
                    {
                    maxDiference = Math.Abs(oldValue - value);
                    }
                    
                }
      
            }
            
            if (count == number)
            {
                Console.WriteLine($"Yes, value={value}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiference}");
            }
        
        }
    }
}
