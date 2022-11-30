using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project06
{
    static class Sequence
    {
        static Random rand = new Random();
        static int Count = 100;
        public static double[] Array = new double[Count];
        public static double[] NewArray = new double[Count];

        public static double[] MainSequence()
        {
            GenerateFirstArray(); //Генерируем массив с равномерным распределением
            SortArray(); //Сортировка по возрастанию
            GenerateNewArray(); // Генерируем массив разности соседник элементов
            return NewArray;
        }

        public static void GenerateNewArray()
        {
            NewArray[0] = Array[0];

            for (int i = 1; i < Count; i++)
            {
                NewArray[i] = Array[i] - Array[i - 1];
            }
        }
        public static void GenerateFirstArray()
        {
            for (int i = 0; i < Count; i++)
            {
                Array[i] = Math.Round(rand.NextDouble() * (100 - 1) + 1 , 3);
            }
        }
        public static void SortArray()
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j] > Array[j + 1])
                    {
                        double z = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = z;
                    }
                }
            }
        }
    }
}
