using System;
using System.Linq;

namespace LR25
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите натуральное число: ");
            string input = Console.ReadLine();

            Console.Write("\nВведите число а: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("\nВведите число b: ");
            int b = int.Parse(Console.ReadLine());

            int countA = input.ToCharArray().Select(x => int.Parse(x.ToString())).Where(x => x == a).ToArray().Length;
            int countB = input.ToCharArray().Select(x => int.Parse(x.ToString())).Where(x => x == b).ToArray().Length;

            Console.Write($"\nВерно ли, что цифра a встречается в нем реже, чем цифра b ? -- {countA < countB}");
            Console.ReadLine();
        }
    }
}
