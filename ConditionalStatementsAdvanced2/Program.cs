using System;

namespace ConditionalStatementsAdvanced2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string track = Console.ReadLine();

            double entryFeeJuniors = 0;
            double entryFeeSeniors = 0;
            if (track == "trail")
            {
                entryFeeJuniors = 5.50;
                entryFeeSeniors = 7;

            }
            else if (track == "cross-country")
            {
                entryFeeJuniors = 8;
                entryFeeSeniors = 9.50;
                int partesapents = juniors + seniors;
                if (partesapents >=50)
                {
                    entryFeeJuniors = entryFeeJuniors - entryFeeJuniors * 0.25;
                    entryFeeSeniors = entryFeeSeniors - entryFeeSeniors * 0.25;
                }
            }
            else if (track == "downhill")
            {
                entryFeeJuniors = 12.25;
                entryFeeSeniors = 13.75;
            }      
            else if (track == "road")
            {
                entryFeeJuniors = 20;
                entryFeeSeniors = 21.50;                                                                             
            }
            double totalJunior = juniors * entryFeeJuniors;
            double totalSenior = seniors * entryFeeSeniors;
            double sum = totalJunior + totalSenior;
            sum = sum - sum * 0.05;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              
            Console.WriteLine($"{sum:F2}");
        }

    }
}