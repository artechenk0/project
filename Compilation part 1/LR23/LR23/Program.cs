using System;
using System.Linq;

namespace LR23
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Дано натуральное число. Определить:\n" +
                $"1) сколько раз в нем встречается цифра а;\n" +
                $"2) количество его цифр, кратных z (значение z вводится с клавиатуры; z = 2, 3, 4\n" +
                $"3) сумму его цифр, больших a (значение a вводится с клавиатуры; 0 <= a <= 8\n" +
                $"4) сколько раз в нем встречаются цифры x и y");
            Console.Write($"\nВведите натуральное число: ");
            string number = Console.ReadLine();

            MethodA(number);
            MethodB(number);
            MethodC(number);
            MethodD(number);
            Console.ReadLine();
        }
        static void MethodA(string number)
        {
            Console.Write("Введите число а: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введенная цифра повторяется: {number.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Where(x => x == input).ToArray().Length} раз(а)");
        }
        static void MethodB(string number)
        {
            Console.Write("Введите число z: ");
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine($"Введенная цифр кратных {input}: {number.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Where(x => x % input == 0).ToArray().Length} шт");
        }
        static void MethodC(string number)
        {
            Console.Write("Введите число a: ");
            int input = int.Parse(Console.ReadLine());
            if (input >= 0 & input <= 8)
                Console.WriteLine($"Сумма равна: {number.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Where(x => x >= input).Sum()}");
            else
                Console.WriteLine("неправильное значение а!");
        }
        static void MethodD(string number)
        {
            Console.Write("Введите число x: ");
            int inputA = int.Parse(Console.ReadLine());
            Console.Write("Введите число y: ");
            int inputB = int.Parse(Console.ReadLine());
            Console.WriteLine($"Количество цифр больше Х: {number.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Where(x => x > inputA).ToArray().Length} шт" +
                $"\nКоличество цифр больше Y: {number.ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Where(x => x > inputB).ToArray().Length} шт");
        }
    }
}
