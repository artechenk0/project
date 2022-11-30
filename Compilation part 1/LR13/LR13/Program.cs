using System;

namespace LR13
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"1. два неполных условных оператора\n" +
                $"2. один неполный условный оператор\n");
            int input = int.Parse(Console.ReadLine());
            
            Console.Write("Введите число a: ");
            double a = double.Parse(Console.ReadLine());
            
            Console.Write("Введите число b: ");
            double b = double.Parse(Console.ReadLine());
            
            switch (input)
            {
                case 1:
                    MethodA(a, b);
                    break;
                case 2:
                    MethodB(a, b);
                    break;
            }
            Console.ReadLine();
        }
        static void MethodA(double a, double b)
        {
            if (a > b)
                Console.WriteLine("Число а > b");
            if (a < b)
                Console.WriteLine("Число а < b");
        }

        static void MethodB(double a, double b)
        {
            double maxValue = a;
            string mes = "Число a > b";
            if (b > a)
            {
                maxValue = b;
                mes = "Число a < b";
            }
            Console.WriteLine(mes);
        }
    }
}
