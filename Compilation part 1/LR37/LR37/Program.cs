using System;

namespace LR37
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите слово начиная с конца: ");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
                Console.Write(word[i]);

            Console.ReadLine();
        }
    }
}
