using System;
using System.Linq;

namespace LR18
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значения через пробел: ");
            Console.WriteLine($"Сумма введенных значений: {Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray().Sum()}");
            Console.ReadLine();
        }
    }
}
