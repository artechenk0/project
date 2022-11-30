using System;

namespace LR5
{
    class Program
    {
        static void Main()
        {
            var rand = new Random();
            int data = rand.Next(1,6);
            Console.WriteLine($"Значение оценки: {data}");

            switch (data)
            {
                case 1:
                    Console.WriteLine("Плохо");
                    break;
                case 2:
                    Console.WriteLine("Неудовлетворительно");
                    break;
                case 3:
                    Console.WriteLine("Удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("Хорошо");
                    break;
                case 5:
                    Console.WriteLine("Отлично");
                    break;
                default:
                    Console.WriteLine("Ошибка");
                    break;
            }
        }
    }
}
