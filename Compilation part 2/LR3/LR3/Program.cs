using System;

namespace LR3
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int data = rand.Next(1, 20);
            Console.WriteLine($"Число {data} является нечетным - {data % 2 != 0}");
        }
    }
}
