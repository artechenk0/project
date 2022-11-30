using System;

namespace LR2
{
    class Program
    {
        static void Main()
        {
            MethodA();
            MethodB();
            MethodC();
            MethodD();
            Console.ReadLine();
        }
        static void MethodA()
        {
            int sum = 1;
            for (int i = 8; i <= 15; i++)
                sum *= i;
            Console.WriteLine($"Сумма равна: {sum}");
        }
        static void MethodB()
        {
            Console.Write($"Произвидение всех чисел от а до 20\n" +
                $"Введите число а: ");
            long input = long.Parse(Console.ReadLine());
            if (input >= 1 || input <= 20)
            {
                long sum = 1;
                for (int i = 1; i <= 20; i++)
                    sum *= i;
                Console.WriteLine($"Сумма равна: {sum}");
            }
        }
        static void MethodC()
        {
            Console.Write($"Произвидение всех чисел от 1 до b\n" +
                $"Введите число b: ");
            int input = int.Parse(Console.ReadLine());
            if (input >= 1 || input <= 20)
            {
                int sum = 1;
                for (int i = 1; i <= input; i++)
                    sum *= i;
                Console.WriteLine($"Сумма равна: {sum}");
            }
        }
        static void MethodD()
        {
            Console.Write($"Произвидение всех чисел от a до b\n" +
                $"Введите число a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b = int.Parse(Console.ReadLine());
            int sum = 1;
            if (b >= a)
            {
                for (int i = a; i <= b; i++)
                    sum *= i;
                Console.WriteLine($"Сумма равна: {sum}");
            }
        }
    }
}
