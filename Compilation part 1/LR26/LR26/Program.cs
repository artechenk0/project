using System;

namespace LR26
{
    class Program
    {
        static void Main()
        {
            MethodA();
            Console.WriteLine();
            MethodB();
            Console.ReadLine();
        }
        static void MethodA()
        {
            int num = 100;
            while (num >= 80)
            {
                Console.Write($"{num} ");
                num--;
            }
        }
        static void MethodB()
        {
            int num = 100;
            do
            {
                Console.Write($"{num} ");
                num--;
            } while (num >= 80);
        }
    }
}
