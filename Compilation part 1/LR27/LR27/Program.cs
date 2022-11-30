using System;
using System.Linq;

namespace LR27
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите число а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число c: ");
            int c = int.Parse(Console.ReadLine());

            if (a <= b)
                Console.WriteLine($"Числа, делимые на с: {string.Join(" ", Enumerable.Range(a, b).Where(x => x % c == 0).Select(x => x.ToString()).ToArray())}");
            Console.ReadLine();
        }
    }
}
