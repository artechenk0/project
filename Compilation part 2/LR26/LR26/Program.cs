using System;

namespace LR26
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write("Введите размерность квадратной матрицы: ");
            int count = int.Parse(Console.ReadLine());
            int mean = 0;

            int[,] data = new int[count, count];
            for (int i = 0; i < count; i++)
                for (int j = 0; j < count; j++)
                    data[i, j] = rand.Next(1, 10);
            for (int i = 0; i < count; i++)
                mean += data[i, i];
            Console.WriteLine($"Среднее арифметическое диагонали: {mean / count}");
            Console.ReadLine();
        }
    }
}
