using System;

namespace For_Loop__6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());
            int priceWater = 20;
            int priceInternet = 15;
            int totalWater = priceWater * months;
            int totalInternet = priceInternet * months;
            double priceElectricity = 0;
            double totalElectricity = 0;
            double totalBills = 0;
            double priceOther = 0;
            double totalOther = 0;

            for (int month = 0; month < months; month++)
            {
                
                priceElectricity = double.Parse(Console.ReadLine());
                totalElectricity += priceElectricity;
                totalBills= priceElectricity + priceWater + priceInternet;
                priceOther = totalBills + totalBills * 0.2;
                totalOther += priceOther;

            }

            double averagePerMonth = (totalElectricity + totalWater + totalInternet + totalOther) / months;

            //•	1ви ред: "Electricity: {ток за всички месеци} lv"
            Console.WriteLine($"Electricity: {totalElectricity:f2} lv");
            //•	2ри ред: "Water: {вода за всички месеци} lv"
            Console.WriteLine($"Water: {totalWater:f2} lv");
           //•	3ти ред: "Internet: {интернет за всички месеци} lv"
           Console.WriteLine($"Internet: {totalInternet:f2} lv");
           //•	4ти ред: "Other: {други за всички месеци} lv"
           Console.WriteLine($"Other: {totalOther:f2} lv");
           //•	5ти ред: "Average: {средно всички разходи за месец} lv"
           Console.WriteLine($"Average: {averagePerMonth:f2} lv");

        }
    }
}
