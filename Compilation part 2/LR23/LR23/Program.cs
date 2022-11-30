using System;

namespace LR23
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();

            int m = rand.Next(2, 5);
            int n = rand.Next(2, 5);

            int[,] array = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = 5 * j;
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
