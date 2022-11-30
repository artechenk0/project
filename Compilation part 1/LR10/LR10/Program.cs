using System;

namespace LR10
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            if (x > 0)
                Console.WriteLine($"Результат: {Math.Sin(Math.Pow(x, 2))}");
            else
                Console.WriteLine($"Результат: {1 + 2 * Math.Pow(Math.Sin(x), 2)}");

            Console.ReadLine();
        }
    }
}
