using System;
using System.Linq;

namespace LR
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число p: ");
            double p = double.Parse(Console.ReadLine());
            Console.WriteLine($"Введите {n} вещественных чисел(по одному)");

            double[] data = Enumerable.Range(0, n).Select(x => double.Parse(Console.ReadLine())).Where(x => x > p).ToArray();
            Console.WriteLine($"Числа больше p: {string.Join(" ", data)}");
            Console.ReadLine();
        }
    }
}
