using System;

namespace LR45
{
    class Program
    {
        static void Main()
        {
            string[] data = new string[10];
            for (int i = 0; i < data.Length; i++)
            {
                Console.Write($"Введите {i + 1} значение: ");
                data[i] = Console.ReadLine();
            }
            Console.WriteLine($"Результат: {string.Join(" ", data)}");
            Console.ReadLine();
        }
    }
}
