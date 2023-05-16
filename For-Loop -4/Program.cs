using System;

namespace For_Loop__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double countTop = 0;
            double countBetween3 = 0;
            double countBetween4 = 0;
            double countFail = 0;
            double averageEvaluation = 0;

            for (int student = 1; student <= studentCount; student++)
            {
                double evaluation = double.Parse(Console.ReadLine());

                if (evaluation >= 2.00 && evaluation <= 2.99)
                {
                    countFail++;
                    averageEvaluation += evaluation;
                }
                else if (evaluation >= 3.00 && evaluation <= 3.99)
                {
                    countBetween3++;
                    averageEvaluation += evaluation;
                }
                else if (evaluation >= 4.00 && evaluation <= 4.99)
                {
                    countBetween4++;
                    averageEvaluation += evaluation;

                }
                else if (evaluation >= 5.00) 
                {
                    countTop++;
                    averageEvaluation += evaluation;
                }
            }            
            Console.WriteLine($"Top students: {countTop / studentCount * 100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {countBetween4 / studentCount * 100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {countBetween3 / studentCount * 100:f2}%");
            Console.WriteLine($"Fail: {countFail / studentCount * 100:f2}%");
            Console.WriteLine($"Average: {averageEvaluation / studentCount:f2}");
        }
    }
}
