using System;

namespace ConditionalStatementsAdvanced7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine(); //- “Winter”, “Spring” или “Summer”;
            string groupKind = Console.ReadLine(); //-“boys”, “girls” или “mixed”;
            int studentCount = int.Parse(Console.ReadLine());
            int overNightStays = int.Parse(Console.ReadLine());

            double pricePerNight = 0;
            string sportKind = string.Empty;
            double totalNeedet = 0;

            if (season == "Winter")
            {
                switch (groupKind)
                {
                    case "boys":
                        pricePerNight = 9.60;
                        sportKind = "Judo";
                        break;
                    case "girls":
                        pricePerNight = 9.60;
                        sportKind = "Gymnastics";
                        break;
                    case "mixed":
                        pricePerNight = 10;
                        sportKind = "Ski";                        
                        break;
                }
                
                

            }
            else if (season == "Spring")
            {
                switch (groupKind)
                {
                    case "boys":
                        pricePerNight = 7.20;
                        sportKind = "Tennis";
                        break;
                    case "girls":
                        pricePerNight = 7.20;
                        sportKind = "Athletics";
                        break;
                    case "mixed":
                        pricePerNight = 9.50;
                        sportKind = "Cycling";
                        break;
                }


            }                                                    
            else if (season == "Summer")
            {
                switch (groupKind)
                {
                    case "boys":
                        pricePerNight = 15;
                        sportKind = "Football";
                        break;
                    case "girls":
                        pricePerNight = 15;
                        sportKind = "Volleyball";
                        break;
                    case "mixed":
                        pricePerNight = 20;
                        sportKind = "Swimming";
                        break;
                }
 
            }
            totalNeedet = studentCount * pricePerNight * overNightStays;

            if (studentCount >= 50)
            {
                totalNeedet -= totalNeedet * 0.50;
            }
            else if (studentCount >= 20 &&  studentCount < 50)
            {
                totalNeedet -= totalNeedet * 0.15;
            }
            else if (studentCount >= 10 && studentCount < 20)
            {
                totalNeedet -= totalNeedet * 0.05;
            }

            Console.WriteLine($"{sportKind} {totalNeedet:f2} lv.");
        }
    }
}
