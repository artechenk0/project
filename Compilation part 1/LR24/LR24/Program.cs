using System;
using System.Linq;

namespace LR24
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int number = rand.Next(1, 100);
            Console.Write($"Число: {number}");

            Console.Write("\nВведите число а: ");
            int a = int.Parse(Console.ReadLine());
            bool checkA = number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray().Sum() < a ? true : false;

            Console.Write("\nВведите число b: ");
            int b = int.Parse(Console.ReadLine());
            int[] intArray = number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            int result = 1;
            for (int i = 0; i < intArray.Length; i++)
                result *= intArray[i];

            bool checkB = result > b;

            Console.Write("\nВведите число k: ");
            int k = int.Parse(Console.ReadLine());
            bool checkC = Math.Pow(10, number.ToString().ToCharArray().Length) == Math.Pow(10, k);

            Console.Write("\nВведите число m: ");
            int m = int.Parse(Console.ReadLine());
            bool checkD = number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).First() > m;

            Console.WriteLine($"\n{checkA}, {checkB}, {checkC}, {checkD}");
            Console.ReadLine();
        }
    }
}
