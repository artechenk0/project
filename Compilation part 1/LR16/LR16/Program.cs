using System;

namespace LR15
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите число: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write($"Введите количество: ");
            double count = double.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
                Console.Write($"{number} ");
            Console.ReadLine();
            
        }
    }
}
