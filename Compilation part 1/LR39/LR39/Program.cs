using System;

namespace LR39
{
    class Program
    {
        static void Main()
        {
            string data = "Сегодня хороший день";
            Console.WriteLine(data);
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == ' ')
                {
                    data = data.Remove(i, 1);
                    data = data.Insert(i, "_");
                }
            }
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
