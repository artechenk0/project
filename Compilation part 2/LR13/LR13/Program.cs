using System;

namespace LR13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            double a = double.Parse(Console.ReadLine()); 
            Console.Write("Введите N: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Power2(a, n));
        }
        static string Power2(double a, int n)
        {
            double result = 1;
            if (n == 0)
                return $"{a} в степени {n} = 1";
            else if (n > 0)
            {
                for (int i = 0; i < n; i++)
                    result *= a;
                return $"{a} в степени {n} = {result}";
            }
            else
            {
                for (int i = 0; i < n * -1; i++)
                    result *= a;
                return $"{a} в степени {n} = {1 / result}";
            }
        }
    }
}
