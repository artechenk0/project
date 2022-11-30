using System;

namespace LR24
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();

            int m = rand.Next(1, 5);
            int n = rand.Next(1, 5);
            int k = rand.Next(1, n - 1);
            int[,] array = new int[m, n];
            int sum = 0;
            int op = 1;

            for (int i = 0; i < m; i++)
                for (int j = 0; j < n; j++)
                    array[i, j] = rand.Next(1, 10);
            for (int i = 0; i < m; i++)
            {
                sum += array[i, k];
                op *= array[i, k];
            }
            Console.WriteLine($"Сумма {k} столбца = {sum}, произвидение = {op}");
            Console.ReadLine();
        }
    }
}
