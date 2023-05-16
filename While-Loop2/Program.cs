using System;


namespace While_Loop2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int addNumber = 0;
            int sumExpected = int.Parse(Console.ReadLine());           
            double averageCard = 0;
            double averageCash = 0;
            int count = 0;
            double cardCount = 0;
            double cashCount = 0;
            


            while ((input = Console.ReadLine()) != "End")
            {

                addNumber = int.Parse(input);
                count++;
                if (count == 1)
                {
                    if (addNumber > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else if (addNumber <= 100)
                    {
                        averageCash += addNumber;
                        Console.WriteLine("Product sold!");
                        cashCount++;
                        
                    }
                    
                }
                if (count == 2)
                {
                    
                    if (addNumber < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {
                        averageCard += addNumber;
                        Console.WriteLine("Product sold!");
                        cardCount++;
                        
                    }
                    count = 0;
                
            } 

                double gatheredSum = averageCard + averageCash;
                double card = averageCard / cardCount;
                double cash = averageCash / cardCount;

                if(sumExpected <= gatheredSum)
                {
                    
                    Console.WriteLine($"Average CS: {cash:F2}");
                    Console.WriteLine($"Average CC: {card:F2}");
                    break;
                       
                }

                
            }    
            if (input == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    
                }

        }
    }
}
