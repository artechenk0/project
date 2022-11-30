using System;
using System.Linq;

namespace LR21
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            Console.Write("Введите N: ");
            int[] array = Enumerable.Range(0, int.Parse(Console.ReadLine())).Select(x => rand.Next(1, 3)).ToArray();
            Console.WriteLine($"Дан массив с {array.Length} элементов: {string.Join(" ", array)}");
            int[] sortArray = new int[array.Length * 2];         
            int SortArrayIndex = 0;                              
            for (int i = 0; i < array.Length; i++)
            {
                sortArray[SortArrayIndex++] = array[i];
                if (i == array.Length - 1 || array[i] != array[i + 1])
                    sortArray[SortArrayIndex++] = 0;
            }
            Console.WriteLine($"Результат: {string.Join(" ", sortArray)}");
            Console.ReadLine();
        }
    }
}
