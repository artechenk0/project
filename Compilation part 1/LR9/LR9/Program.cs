using System;

namespace LR9
{
    class Program
    {
        static void Main()
        {
            Console.Write($"Введите число А: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write($"Введите число В: ");
            double b = double.Parse(Console.ReadLine());

            Console.Write($"Введите число С: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"каждое из чисел А и В больше 100 - {a > 100 && b > 100}\nтолько одно из чисел А и В четное - {a % 2 == 0 || b % 2 == 0}\n" +
                $"Каждое из чисел А, В, С кратно трем - {a % 3 == 0 && b % 3 == 0 && c % 3 == 0}\nтолько одно из чисел А, В и С меньше 50 - " +
                $"{(a < 50 && b > 50 && c > 50) || (a > 50 && b < 50 && c > 50) || (a > 50 && b > 50 && c < 50)}\n" +
                $"Хотя бы одно из чисел А, В, С отрицательно - {a < 0 || b < 0 || c < 0}\nхотя бы одно из чисел А и В положительно - {a > 0 || b > 0}");
            Console.ReadLine();
        }
    }
}
