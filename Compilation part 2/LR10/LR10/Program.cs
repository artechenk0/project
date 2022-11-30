using System;
using System.Linq;

namespace LR10
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int n = rand.Next(1,10);
            double value = 1;
            double[] data = Enumerable.Range(0, n).Select(x => Math.Round(rand.NextDouble() * 10, 1)).ToArray();
            Console.WriteLine($"Исходный массив на {n} элементов: {String.Join(" ", data)}\n");
            Console.Write("Массив на выходе: ");
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                    value *= data[i];
                Console.Write($"{value} ");
                value = 1;
            }
        }
    }
}
