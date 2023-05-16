using System;

namespace ConditionalStatementsAdvanced3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hrizantemi = int.Parse(Console.ReadLine());
            int rozi = int.Parse(Console.ReadLine());
            int laleta = int.Parse(Console.ReadLine());
            string season = Console.ReadLine(); // Spring, Summer, Аutumn, Winter
            string holyday = Console.ReadLine();

            double priceHrizantemi = 0;
            double priceRozi = 0;
            double priceLaleta = 0;
            double totalPrice = 0;
            int flowersCount = 0;
            if (season == "Spring" || season == "Summer")
            {
                
                    priceHrizantemi = 2.00;
                    priceRozi = 4.10;
                    priceLaleta = 2.50;
               
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceHrizantemi = 3.75;
                priceRozi = 4.50;
                priceLaleta = 4.15;
            }
            flowersCount = rozi + laleta + hrizantemi;
            double totalHrizantemi = hrizantemi * priceHrizantemi;
            double totalRozi= rozi * priceRozi;
            double totalLaleta = laleta * priceLaleta;
            

            if (holyday == "Y")
            {
                totalPrice = totalHrizantemi + totalRozi + totalLaleta;
                totalPrice += totalPrice * 0.15;
            }
            else if(holyday == "N")
            {
                totalPrice = totalHrizantemi + totalRozi + totalLaleta ; 
            }
            
             if (laleta > 7 && season == "Spring")
            {
                totalPrice -= totalPrice * 0.05;
            }
            else if (rozi >= 10 && season == "Winter")
            {
                totalPrice -= totalPrice * 0.1;
            }
            if (flowersCount > 20)
            {
                totalPrice -= totalPrice * 0.20;
                
            }
            totalPrice += 2;
            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
