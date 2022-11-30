using System;

namespace LR36
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите слово: ");
            string text = Console.ReadLine();
            Console.WriteLine($"Последний символ слова - {text[text.Length - 1]}");
            Console.ReadLine();
        }
    }
}
