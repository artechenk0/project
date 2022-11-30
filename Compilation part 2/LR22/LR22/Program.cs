using System;
using System.Linq;

namespace LR22
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int[] ox = Enumerable.Range(0, 5).Select(x => rand.Next(0, 10)).ToArray();
            int[] oy = Enumerable.Range(0, 5).Select(x => rand.Next(0, 10)).ToArray();
            double r = 0;
            Console.WriteLine($"Даны точки:\n{string.Join(" ", ox)}\n{string.Join(" ", oy)}");

            for (int i = 0; i < ox.Length - 1; i++)
                if (r < Math.Sqrt(Math.Pow(ox[i + 1] - ox[i], 2) + Math.Pow(oy[i + 1] - oy[i], 2)))
                    r = Math.Sqrt(Math.Pow(ox[i + 1] - ox[i], 2) + Math.Pow(oy[i + 1] - oy[i], 2));
            
            Console.WriteLine($"самая больщая удаленность точки(ек) от 0ых координат = {r}");
            Console.ReadLine();
        }
    }
}
