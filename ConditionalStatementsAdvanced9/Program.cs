using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ConditionalStatementsAdvanced9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            while (x <=10)
            {
                Console.WriteLine(x);
                x++;
            }
        }
    }
}
