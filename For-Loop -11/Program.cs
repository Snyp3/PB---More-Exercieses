using System;

namespace For_Loop__11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double oddSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenSum = 0;
            bool even = false;
            bool odd = false;

            for (int i = 0; i < numbers; i++)
            {
                double number = double.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    evenSum += number;

                    if (number >= evenMax)
                    {
                        
                        evenMax = number;
                    }
                    if (number <= evenMin)
                    {
                        evenMin = number;
                        
                    }

                }
                else
                {
                    
                    oddSum += number;
                    if (number >= oddMax)
                    {
                        oddMax = number;
                    }
                    if (number <= oddMin)
                    {
                        oddMin = number;
                    }
                   
                    
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2}");
            Console.WriteLine($"OddMin={oddMin:f2}");
            Console.WriteLine($"OddMax={oddMax:f2}");
            Console.WriteLine($"EvenSum={evenSum:f2}");
            Console.WriteLine($"EvenMin={evenMin:f2}");
            Console.WriteLine($"EvenMax={evenMax:f2}");
        }
    }
}
