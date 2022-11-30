using System;
using System.Linq;

namespace LR18
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write($"Введите значение N: ");
            int n = int.Parse(Console.ReadLine());
            int[] data = Enumerable.Range(0, n).Select(x => rand.Next(1,10)).ToArray();
            Console.WriteLine($"Исходный массив: {string.Join(" ", data)}");
            bool check = data.Any(x => x % 2 == 0 && x != 0);
            if (check == true)
            {
                int index = data.Where(x => x % 2 == 0).FirstOrDefault();
                Console.WriteLine($"Перый четный элемент равен - {index}");
                for (int i = 0; i < data.Length; i++)
                    data.SetValue(data[i] * index, i);
                Console.WriteLine($"Полученный массив: {string.Join(" ", data)}");
            }
            else
                Console.WriteLine($"Массив отстался без изминений!");

            Console.ReadKey();
        }
    }
}
