using System;

namespace LR14
{
    class Program
    {
        static void Main()
        {
            int minSquare;
            int thisSquare;
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            minSquare = Square();

            for (int i = 1; i < n; i++)
            {
                thisSquare = Square();
                if (thisSquare < minSquare)
                    minSquare = thisSquare;
            }
            Console.WriteLine($"Минимальное значение площади = {minSquare}");
        }
        static int Square()
        {
            Console.Write("Введите значение A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите значение B: ");
            int b = int.Parse(Console.ReadLine());

            return a * b;
        }
    }
   
}
