using System;

namespace LR29
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write($"Введите строку: ");
            string s = Console.ReadLine();
            int n = rand.Next(10, 15);
            int length = s.Length - n;
            if (length > 0)
                s = s.Substring(length);
            if(length < 0)
                s = s.Insert(0, new string('.', -length));
            Console.WriteLine($"Полученная строка: {s}");
            Console.ReadLine();
        }
    }
}
