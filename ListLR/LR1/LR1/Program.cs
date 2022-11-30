using System;

namespace LR1
{
    class Program
    {
        static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            while (true)
            {
                Console.Write("\n1. Вывод всех элементов\n" +
                    "2. Вставка элемента справа\n" +
                    "3. Поиск элемента\n" +
                    "4. Удаление элемента\n" +
                    "5. Очистка списка\n" +
                    "6. Измeнение элемента\n" +
                    "7. Выйти\n" +
                    "Выберите действие: ");
                switch (int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine();
                        foreach (var item in linkedList)
                            Console.Write($"{item} "); break;
                    case 2:
                        linkedList.Add(Console.ReadLine()); break;
                    case 3:
                        bool isPresent = linkedList.Contains(Console.ReadLine());
                        Console.WriteLine(isPresent == true ? "Элемент присутствует" : "Элемент отсутствует"); break;
                    case 4:
                        linkedList.Remove(Console.ReadLine()); break;
                    case 5:
                        linkedList.Clear(); break;
                    case 6:
                        Console.Write("Введите элемент, который хотите изменить, затем введите его новое значение: ");
                        linkedList.Edit(Console.ReadLine(), Console.ReadLine()); break;
                    default: break;
                }
            }
        }
    }
}
