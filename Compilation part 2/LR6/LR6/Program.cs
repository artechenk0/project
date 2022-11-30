using System;

namespace LR6
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int a = rand.Next(0,5);
            int b = rand.Next(10,15);
            Console.Write($"Значение а = {a}, b = {b}. Диапозон от а до b: ");
            for (int i = a; i <= b; i++)
                Console.Write($"{i} ");
        }
    }
}
