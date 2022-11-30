using System;
using System.Text.RegularExpressions;

namespace LR28
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите строку: ");
            string data = Console.ReadLine();

            Console.WriteLine(Regex.Matches(data, @"[A-Z, a-z]").Count);
            Console.ReadLine();
        }
    }
}
