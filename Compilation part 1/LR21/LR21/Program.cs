using System;

namespace LR21
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            int input = int.Parse(Console.ReadLine());
            int result = 1;
            for (int i = 1; i <= input; i++)
                result *= i;
            Console.WriteLine($"Результат: {result}");
            Console.ReadLine();
        }
    }
}
