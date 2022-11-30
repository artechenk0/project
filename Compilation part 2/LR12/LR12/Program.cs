using System;

namespace LR12
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            while (count < 3)
            {
                Console.Write("Введите индекс A: ");
                int a = int.Parse(Console.ReadLine()); 
                Console.Write("Введите индекс B: ");
                int b = int.Parse(Console.ReadLine()); 
                Console.Write("Введите индекс C: ");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine(RootsCount(a, b, c));
                count++;
            }
        }
        static string RootsCount(int a, int b, int c)
        {
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
                return "Нет действующих корней";
            else if (d == 0)
                return $"x = {-(b / 2 * a)}";
            else
                return $"x1 = {(-b + Math.Sqrt(d)) / 2 * a}; x2 = {(-b - Math.Sqrt(d)) / 2 * a}";
        }
    }
}
