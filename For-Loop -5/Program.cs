using System;

namespace For_Loop__5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            

            double gameLength = double.Parse(Console.ReadLine());
            int invalidNumbers = 0;
            int countOne = 0; // 0 to 9
            int countTwo = 0; // 10 to 19
            int countThree = 0; // 20 to 29
            int countFour = 0; // 30 to 39 
            int countFive = 0; // 40 to 50

            double totalPoints = 0;


            for (int gamePart = 1; gamePart <= gameLength; gamePart++)
            {

                int gamePoints = int.Parse(Console.ReadLine());

                if (gamePoints > 50 ||  gamePoints <  0)
                {
                    invalidNumbers++;
                    totalPoints = totalPoints / 2;
                    
                }
                else if (gamePoints == 0 || gamePoints <= 9 )
                {
                    countOne++;
                    totalPoints += + gamePoints * 0.2;

                }
                else if (gamePoints <= 19)
                {
                    countTwo++;
                    totalPoints += gamePoints * 0.3;
                }
                else if ( gamePoints <= 29)
                {
                    countThree++;
                    totalPoints +=  gamePoints * 0.4;
                }
                else if ( gamePoints <= 39)
                {
                    countFour++;
                    totalPoints += 50;
                }
                else if ( gamePoints <= 50)
                {
                    countFive++;
                    totalPoints += 100;

                }            
            }

            // •	1ви ред: "{Краен резултат}"
            Console.WriteLine($"{totalPoints:f2}");
            // •	2ри ред: "From 0 to 9: {процент в интервала}%"
            Console.WriteLine($"From 0 to 9: {countOne / gameLength * 100:f2}%");
            // •	3ти ред: "From 10 to 19: {процент в интервала}%"
            Console.WriteLine($"From 10 to 19: {countTwo / gameLength * 100:f2}%");
            // •	4ти ред: "From 20 to 29: {процент в интервала}%"
            Console.WriteLine($"From 20 to 29: {countThree / gameLength * 100:f2}%");
            // •	5ти ред: "From 30 to 39: {процент в интервала}%"
            Console.WriteLine($"From 30 to 39: {countFour / gameLength * 100:f2}%");
            // •	6ти ред: "From 40 to 50: {процент в интервала}%"
            Console.WriteLine($"From 40 to 50: {countFive / gameLength * 100:f2}%");
            // •	7ми ред: "Invalid numbers: {процент в интервала}%"
            Console.WriteLine($"Invalid numbers: {invalidNumbers / gameLength * 100:f2}%");
            // Всички числа трябва да са форматирана до вторият знак след запетаята











        }
    }
}
