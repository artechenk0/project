using System;

namespace LR8
{
    class Program
    {
        static void Main()
        {
            bool x = false;
            bool y = true;
            bool z = false;
            Console.WriteLine("X = Ложь, Y = Истина, Z = Ложь\n");
            Console.WriteLine($"X или Z: {x || z}\n" +
                $"X и Y: {x && y}\n" +
                $"X и Z: {x && z}");
            Console.ReadLine();
        }
    }
}
