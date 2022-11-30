using System;
using System.Linq;

namespace LR29
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"Введите {n} целых чисел(по одному)");

            int[] data = Enumerable.Range(0, n).Select(x => int.Parse(Console.ReadLine())).ToArray();

            MethodA(data);
            MethodB(data);

            Console.ReadLine();
        }
        static void MethodA(int[] data)
        {
            int count = 0;
            int value = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (value <= data[i])
                {
                    value = data[i];
                    count = i;
                }
            }
            Console.WriteLine($"Индекс максимального значения: {count}");
        }
        static void MethodB(int[] data)
        {
            int count = 0;
            int value = data[0];
            for (int i = 0; i < data.Length; i++)
            {
                if (value > data[i])
                {
                    value = data[i];
                    count = i;
                }
            }
            Console.WriteLine($"Индекс минимального значения: {count}");
        }
    }
}
