using System;

namespace LR19
{
    class Program
    {
        static void Main()
        {
            int count = 1;
            for (int i = 3; i <= 24; i += 3)
            {
                count *= 2;
                Console.WriteLine($"В {i} часа(ов) {count} амеб");
            }
            Console.ReadLine();
        }
    }
}
