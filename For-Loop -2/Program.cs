using System;

namespace For_Loop__2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int treated = 0;
            int untreated = 0;
            int doctors = 7;
            int count = 1;

            for (int day = 1; day <= period; day++)
            {
                int days = int.Parse(Console.ReadLine());
                int patients = days;

                 if (day % 3 == 0 )
                {
                    if (untreated > treated)
                    {
                        doctors++;
                    }                    
                   
                }

                if (patients < doctors)
                {
                    treated += patients;
                   
                }
                else 
                {
                    treated += doctors;
                    untreated += (patients - doctors);
                    
                }
               
            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Untreated patients: {untreated}.");
        }
    }
}
