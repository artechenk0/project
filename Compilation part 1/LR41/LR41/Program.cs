using System;
using System.Linq;

namespace LR41
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите слово: ");
            Console.WriteLine($"В данном слове {Console.ReadLine().GroupBy(x => x).Select(x => x.Key.ToString()).ToArray().Count()} различных символов");
            Console.ReadLine();
        }
    }
}
