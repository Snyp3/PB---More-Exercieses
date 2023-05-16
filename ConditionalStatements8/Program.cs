using System;


namespace ConditionalStatements8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelQuantity = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double fuelPrice = 0 ;
            if (fuelType == "Gas")
            {
                
                if (clubCard == "Yes")
                {
                    fuelPrice = fuelQuantity * 0.85;
                }
                else if (clubCard == "No")
                {
                    fuelPrice = fuelQuantity * 0.93;
                }
            }
            else if(fuelType == "Gasoline")
            {
                
                if (clubCard == "Yes")
                {
                    fuelPrice = fuelQuantity * 2.04;
                }
                else if (clubCard == "No")
                {
                    fuelPrice = fuelQuantity * 2.22;
                }
            }
            else if (fuelType == "Diesel")
            {
                fuelPrice = fuelQuantity * 2.33;
                if (clubCard == "Yes")
                {
                    fuelPrice = fuelQuantity * 2.21;
                }
                else if (clubCard == "No")
                {
                    fuelPrice = fuelQuantity * 2.33;
                }
            }
            if (fuelQuantity >= 20 &&  fuelQuantity <= 25)
            {
                fuelPrice = fuelPrice - fuelPrice * 0.08;
            }
            else if (fuelQuantity > 25)
            {
                fuelPrice = fuelPrice - fuelPrice * 0.1;
            }

            Console.WriteLine($"{fuelPrice:f2} lv.");
 

        }
    }
}
