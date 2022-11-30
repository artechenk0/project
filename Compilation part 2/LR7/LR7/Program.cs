using System;

namespace LR7
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int n = rand.Next(1,10);
            int k = rand.Next(1, 3);
            double result = 1; 
            double sum = 0;
            Console.WriteLine($"Значение n = {n}, значение k = {k}");
            for (int i = 1; i <= n; i++)
            {
                if (k == 1)
                    sum += i;
                for (int j = 1; j < k; j++)
                    result = i * i;
                sum += result;
            }
            Console.WriteLine($"Полученный результат: {sum}");
        }
    }
}
