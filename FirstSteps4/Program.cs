using System;

namespace FirstSteps4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruit = double.Parse(Console.ReadLine());
            int kgVegetable = int.Parse(Console.ReadLine());
            int kgFruit = int.Parse(Console.ReadLine());

            double incVegetable = vegetables * kgVegetable;
            double incFruit = fruit * kgFruit;
            double totalInc = incVegetable + incFruit;
            double totalIncEuro = totalInc / 1.94;
            Console.WriteLine("{0:F2}", totalIncEuro);
        }
    }
}
