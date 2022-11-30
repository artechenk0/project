using System;

namespace LR44
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число: ");
            double number = double.Parse(Console.ReadLine());
            Console.Write("\nВведите степень: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат: {RecursiveFunc(n, number)}");
            Console.ReadLine();
        }
        static double RecursiveFunc(int n, double num)
        {
            if (n == 0)
                return 1;
            if (n == 1)
                return num;
            else
            {
                n--;
                return num * RecursiveFunc(n, num);
            }
        }
    }
}
