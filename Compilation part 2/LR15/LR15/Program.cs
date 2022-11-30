using System;

namespace LR15
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение N: ");
            int n = int.Parse(Console.ReadLine());
            int[] data = new int[n];
            data[0] = 2;
            for (int i = 1; i < data.Length; i++)
                data[i] = data[i - 1] * 2;
            Console.WriteLine($"Полученный массив: {string.Join(" ", data)}");
            Console.ReadKey();
        }
    }
}
