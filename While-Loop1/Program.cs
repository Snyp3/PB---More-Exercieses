using System;

namespace While_Loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int detergent = int.Parse(Console.ReadLine()) * 750;
           
            int count = 0;                       
            int detergentUsed = detergent;
            int countdishes = 0;
            int countpots = 0;
            int addWash = 0;
            string index;



            while ((index = Console.ReadLine()) != "End" )
            {
                count++;
                addWash = int.Parse(index);
                
                
                if (count != 3)
                {
                    detergentUsed -= addWash * 5;
                    countdishes += addWash;
                                
                }
                else
                {                   
                    
                    detergentUsed -= addWash * 15;
                    countpots += addWash;
                    count = 0;
                }

                if (detergentUsed < 0)
                {
                       Console.WriteLine($"Not enough detergent, {Math.Abs(detergentUsed)} ml. more necessary!");
                    break;
                }              
            }
            
            
            if (detergentUsed >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{countdishes} dishes and {countpots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergentUsed} ml.");
            }
           
            
            


        }
    }
}
