using System;

namespace LR4
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите значение в кг: ");
            double input = double.Parse(Console.ReadLine());

            Console.Write($"Масса в центнеров: {input / 100}");
            Console.ReadLine();
        }
    }
}
