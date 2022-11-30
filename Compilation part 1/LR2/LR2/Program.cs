using System;

namespace LR2
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите число а: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {(a * a + 10) / Math.Sqrt((a * a) + 1)}");
            Console.ReadLine();
        }
    }
}
