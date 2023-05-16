using System;

namespace Conditionstatements2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Когато е на работа, стопанинът му си играе с него по 63 минути на ден.
            //•	Когато почива, стопанинът му си играе с него по 127 минути на ден.
            // 30000 минути в годината 365 дни

            int dayOffCount = int.Parse(Console.ReadLine());



            int workDays = (365 - dayOffCount) * 63;
            
            
            int dayOff = dayOffCount * 127;
            int totalPlayTime = workDays + dayOff;
            int playTimeDiference = Math.Abs(30000 - totalPlayTime);
            int hoursDiference = playTimeDiference /60;
            int minutesDiference = playTimeDiference % 60;

            if (totalPlayTime > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hoursDiference} hours and {minutesDiference} minutes more for play");
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hoursDiference} hours and {minutesDiference} minutes less for play");
            }
        }
    }
}
