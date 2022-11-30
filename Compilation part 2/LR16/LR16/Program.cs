using System;
using System.Linq;

namespace LR16
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int index = 0;
            int[] data = Enumerable.Range(0, 10).Select(x => rand.Next(1,100)).ToArray();
            Console.WriteLine($"ИСходный массив: {string.Join(" ", data)}");
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < data[data.Length - 1] && data[i] > data[0])
                    index = i;
            }
            Console.WriteLine($"Результат: {index}");
            Console.ReadKey();
        }
    }
}
