using System;
using System.Linq;

namespace LR17
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int count = 0;
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());
            int[] data = Enumerable.Range(0, n).Select(x => rand.Next(1, 10)).ToArray();
            int[] sortData = new int[data.Length];

            Console.WriteLine($"Исходный массив: {string.Join(" ", data)}");

            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 5)
                    sortData[count] = data[i] * 2;
                else
                    sortData[i] = data[i] / 2;
                count++;
            }
            Console.WriteLine($"Массив на выходе: {string.Join(" ", sortData)}");
            Console.ReadKey();
        }
    }
}
