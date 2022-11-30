using System;
using System.Linq;

namespace LR31
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите {n} целых чисел(по одному)");
            int[] data = Enumerable.Range(0, n).Select(x => int.Parse(Console.ReadLine())).ToArray();

            Console.WriteLine($"верно ли, что сумма тех чисел ai , которые меньше 20,5, не превышает 50: {data.Where(x => x < 20.5).Sum() < 50}");
            Console.WriteLine($"верно ли, что сумма тех чисел ai, которые не превышают 10, кратна трем: {data.Where(x => x < 10).Sum() % 3 == 0}");

            Console.ReadLine();
        }
    }
}
