using System;

namespace LR40
{
    class Program
    {
        static void Main()
        {
            string data = "Сегодня хороший день123";
            Console.WriteLine(data);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= '0' && data[i] <= '9')
                    Console.Write(data[i]);
            }
            Console.ReadLine();
        }
    }
}
