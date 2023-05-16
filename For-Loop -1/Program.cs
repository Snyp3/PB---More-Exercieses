using System;

namespace For_Loop__1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int countYears = 18;
            double moneyLeft = money;


            for (int i = 1800; i <= year; i+=1)
            {

                
                if (i % 2 == 0)
                {
                    moneyLeft -= 12000;
                }
                else if (i % 2 == 1)
                {
                    moneyLeft -=   12000 + 50 * countYears;            
                        
                        
                }
                countYears++;
              
               
            }
            if (moneyLeft >= 0)
                {
                Console.WriteLine($"Yes! He will live a carefree life and will have {moneyLeft:f2} dollars left.");
                }
                else
                {
                Console.WriteLine($"He will need {Math.Abs(moneyLeft):f2} dollars to survive.");
                }
        }
    }
}
