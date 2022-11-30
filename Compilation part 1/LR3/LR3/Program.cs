using System;

namespace LR3
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите число а: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write($"Введите число b: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write($"Введите число c: ");
            double c = double.Parse(Console.ReadLine());

            double tempA = a;
            double tempB = b;
            double tempC = c;
            b = tempC;
            a = tempB;
            c = tempA;

            Console.WriteLine($"А: {a}, B: {b}, C: {c}");

            b = tempA;
            c = tempB;
            a = tempC;

            Console.WriteLine($"А: {a}, B: {b}, C: {c}");
            Console.ReadLine();
        }
    }
}
