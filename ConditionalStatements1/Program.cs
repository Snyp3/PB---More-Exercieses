using System;

namespace ConditionalStatements1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double debitP1 = P1 * H ;
            double debitP2 = P2 * H ;

            double debit = debitP1 + debitP2 ;
            
           
            if (V >= debit)
            {
                Console.WriteLine($"The pool is {debit/V *100:F2}% full. Pipe 1: {(debitP1 / debit) * 100:F2}%. Pipe 2: {(debitP2/debit) * 100:F2}%.");
            }
            else           
            {
                Console.WriteLine($"For {H:F2} hours the pool overflows with {debit - V:F2} liters.");
            }
        }
    }
}
