using System;
using System.Linq;

namespace LR19
{
    class Program
    {
        static void Main()
        {
            int count = 0;
            var rand = new Random();
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Введите K: ");
            int k = int.Parse(Console.ReadLine()); 

            int[] data = Enumerable.Range(0, n).Select(x => rand.Next(1, 10)).ToArray();
            int[] sortData = new int[data.Length];
            Console.WriteLine($"Исходный массив {string.Join(" ", data)}");
            for (int i = 0; i < data.Length; i++)
            {
                if (i != k)
                {
                    sortData[count] = data[i];
                    count++;
                }
            }
            Console.WriteLine($"Выходной массив: {string.Join(" ", sortData)}");
            Console.ReadLine();
        }
    }
}
