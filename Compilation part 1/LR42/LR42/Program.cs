using System;

namespace LR42
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"{ ((1 + Math.Sin(1)) / 3) + ((5 + Math.Sin(5)) / 3) + ((3 + Math.Sin(3)) / 3) }");
            Console.WriteLine($"{ ((2 + Math.Sin(2)) / (Math.Sin(5) + 5)) + ((6 + Math.Sin(6)) / (Math.Sin(3) + 3)) + ((1 + Math.Sin(1)) / (Math.Sin(4) + 4)) }");
            Console.WriteLine($"{ ((1 + Math.Sin(4)) / (Math.Sin(4) + 1)) + ((7 + Math.Sin(5)) / (Math.Sin(5) + 7)) + ((3 + Math.Sin(2)) / (Math.Sin(2) + 3)) }");
            Console.WriteLine($"{ ((2 + Math.Sin(3)) / (Math.Sin(3) + 2)) + ((1 + Math.Sin(5)) / (Math.Sin(1) + 5)) + ((7 + Math.Sin(4)) / (Math.Sin(3) + 7)) }");
            Console.ReadLine();
        }
    }
}
