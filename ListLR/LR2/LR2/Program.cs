using System;

namespace LR2
{
    class Program
    {
        static DoubleLinkedList<object> List = new DoubleLinkedList<object>();
        static void Main()
        {
            while (true)
            {
                Console.Write("Что Вы хотите сделать?\n" +
                   "1. Добавить элемент\n" +
                   "2. Удалить элемент\n" +
                   "3. Вывести все элементы\n" +
                   "4. Очистить список\n" +
                   "5. Выйти из программы\n" +
                   "Выберите действие: ");

                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        AddElement(); break;
                    case 2:
                        RemoveAtList(); break;
                    case 3:
                        AllElements(); break;
                    case 4:
                        List.Clear(); break;
                    case 5: break;
                }
            }
        }
        static void AllElements()
        {
            int i = 0;
            if (List.IsEmpty)
            {
                Console.WriteLine("Элементов в списке нет!");
                return;
            }
            Console.Write("Элементы в списке: ");
            foreach (var data in List)
            {
                Console.Write($"{data} ");
                i++;
            }
            Console.WriteLine();
        }

        static void AddElement()
        {
            Console.Write("Что Вы хотите добавить: ");
            string data = Console.ReadLine();
            List.Add(data);
        }

        static void RemoveAtList()
        {
            AllElements();

            if (List.IsEmpty)
                return;

            Console.Write("Введите элемент, который хотите удалить: ");
            string delete = Console.ReadLine();

            List.Remove(delete);
        }
    }
}
