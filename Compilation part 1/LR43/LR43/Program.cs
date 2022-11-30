using System;

namespace LR43
{
    class Program
    {
        static void Main()
        {
            for (var i = 0; i < Console.WindowHeight; i++)
            {
                for (var j = 0; j < Console.WindowWidth; j++)
                {
                    if ((i > 0 && i < Console.WindowHeight - 1) && (j > 0 && j < Console.WindowWidth - 1))
                        Console.Write(' ');
                    else
                        Console.Write('*');
                }
            }
            Console.ReadLine();
        }
    }
}
