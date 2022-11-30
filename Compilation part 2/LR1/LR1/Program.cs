using System;

namespace LR1
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int a = rand.Next(1, 25);
            Console.WriteLine($"Значение а: {a}\nS = {a * a}");
            Console.ReadKey();
        }
    }
}
