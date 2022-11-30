using System;
using System.Linq;

namespace LR9
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            double[] data = Enumerable.Range(0, 10).Select(x => Math.Round(rand.NextDouble() * 10, 3)).ToArray();
            Console.WriteLine($"Даны 10 вещественных чисел: {string.Join(" ", data)}\nСумма равна: {data.Sum()}");
        }
    }
}
