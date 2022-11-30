using System;

namespace LR
{
    class Program
    {
        static void Main()
        {
            string data = "Сегодня хороший день";
            string count = "";

            for (int i = data.Length - 1; i >= 0; i--)
            {
                if (data[i] == 'е')
                {
                    count = i.ToString();
                    break;
                }
            }

            Console.WriteLine($"Последний индекс равен: {count}");
            count = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == 'е')
                {
                    count = i.ToString();
                    break;
                }
            }
            Console.WriteLine($"Первый индекс равен: {count}");
            Console.ReadLine();
        }
    }
}
