using System;

namespace LR25
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int m = 5;
            int n = 5;
            int k1 = 2;
            int k2 = 3;

            int[,] array = new int[m, n];
            Console.Write("Дан массив:\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array[i, j] = rand.Next(1, 10);
                    Console.Write($"{array[i, j]} ");
                }
                Console.WriteLine();    
            }
                
            for (int i = 0; i < m; i++)
            {
                int temp = array[i, k1];
                array[i, k1] = array[i, k2];
                array[i, k2] = temp;
            }
            Console.Write("Полученный массив:\n");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write($"{array[i, j]} ");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
