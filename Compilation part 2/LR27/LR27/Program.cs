using System;

namespace LR27
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int value = rand.Next(32,126);
            Console.WriteLine($"Символ с кодировой {value} - {(char)value}");
            Console.ReadLine();
        }
    }
}
