using System;
using System.Text;

namespace FirstSteps5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            w *= 100;
            h = h * 100 - 100;    //Ограничения: 3 ≤ h ≤ w ≤ 100

            

            double workH = Math.Floor (h / 70);
            double workW = Math.Floor (w / 120);

            double countWorkPlace = workH * workW -3;

            Console.WriteLine(Math.Floor(countWorkPlace));
        }
    }
}
