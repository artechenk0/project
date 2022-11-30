using System;

namespace LR5
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите двухзначное число: ");
            string input = Console.ReadLine();

            char[] data = input.ToCharArray();
            Console.WriteLine($"Результат: {data[1]}{data[0]}");
            Console.ReadLine();
        }
    }
}
