using System;
using System.Collections.Generic;

namespace LR3
{
    class Program
    {
        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Kate");
            queue.Enqueue("Sam");
            queue.Enqueue("Alice");
            queue.Enqueue("Tom");

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.WriteLine();

            Console.WriteLine();
            string firstItem = queue.Dequeue();
            Console.WriteLine($"Извлеченный элемент: {firstItem}");
            Console.WriteLine();

            foreach (string item in queue)
                Console.WriteLine(item);
            Console.ReadLine();
        }
    }
}
