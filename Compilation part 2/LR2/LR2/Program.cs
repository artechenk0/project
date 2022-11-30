using System;

namespace LR2
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение массы в кг: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine($"Значение массы в целых тоннах: {a / 1000}");
        }
    }
}
