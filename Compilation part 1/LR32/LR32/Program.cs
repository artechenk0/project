using System;

namespace LR32
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i >= j) 
                        Console.Write(5 + " ");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > 0; j--)
                {
                    if (i < j)
                        Console.Write(1 + " ");
                    else 
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
