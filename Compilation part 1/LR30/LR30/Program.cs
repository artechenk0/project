using System;
using System.Linq;

namespace LR30
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите число p: ");
            int p = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите {n} целых чисел(по одному)");
            int[] data = Enumerable.Range(0, n).Select(x => int.Parse(Console.ReadLine())).ToArray();
            Console.WriteLine($"Верно ли, что сумма чисел bi меньше p? - {data.Sum() < p}");
            Console.ReadLine();
        }
    }
}
