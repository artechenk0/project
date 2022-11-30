using System;
using System.Linq;

namespace LR20
{
    class Program
    {
        static void Main()
        {
            int temp;
            var rand = new Random();

            int[] a = Enumerable.Range(0, 6).Select(x => rand.Next(1, 10)).ToArray();
            Console.WriteLine($"Дан массив: {string.Join(" ", a)}");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                Console.WriteLine($"{i} - этап: {string.Join(" ", a)}");
            }
            Console.ReadLine();

        }
    }
}
