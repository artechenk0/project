using System;

namespace LR8
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int a = rand.Next(20,40);
            int b = rand.Next(1, 19);
            int count = 0;
            Console.WriteLine($"Длина отрезка а = {a}, b = {b}");

            while (a > b && a >= 0)
            {
                a -= b;
                count++;
            }

            Console.WriteLine($"количество отрезков B, размещенных на отрезке A = {count}");
        }
    }
}
