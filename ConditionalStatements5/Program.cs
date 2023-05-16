using System;

namespace ConditionalStatements5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double foodPerDayDog = double.Parse(Console.ReadLine());
            double foodPerDayCat = double.Parse(Console.ReadLine());
            double foodPerDayTurtle = double.Parse(Console.ReadLine());          

            double needetFoodDog = foodPerDayDog * days;
            double needetFoodCat = foodPerDayCat * days;
            double needetFoodTurtle =(foodPerDayTurtle * days)/ 1000; 

            double totalFoodNeedet =needetFoodCat + needetFoodDog + needetFoodTurtle;

            if (foodLeft > totalFoodNeedet)
                {
                Console.WriteLine($"{Math.Floor(foodLeft - totalFoodNeedet)} kilos of food left");
                }
            else
            {
                Console.WriteLine($"{Math.Ceiling(totalFoodNeedet - foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
