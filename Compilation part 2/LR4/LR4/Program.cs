using System;

namespace LR4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            int data = rand.Next(-10, 10);
            Console.WriteLine($"Значение по умолчанию: {data}");
            if (data > 0)
                Console.WriteLine($"Число {data} положительное: a = {data++}");
            else
                Console.WriteLine($"Число {data} не положительное: a = {data -= 2}");
        }
    }
}
