using System;

namespace LR11
{
    class Program
    {
        public static double A;
        public static double B;
        public static double C;
        public static double D;
        static void Main()
        {
            var rand = new Random();
            PowerA234(A = Math.Round(rand.NextDouble() * 10, 1) ,ref B, ref C, ref D);
            Console.WriteLine($"Дано A = {A}; B = {B}; C = {C}; D = {D}");

            PowerA234(A = Math.Round(rand.NextDouble() * 10, 1), ref B, ref C, ref D);
            Console.WriteLine($"Дано A = {A}; B = {B}; C = {C}; D = {D}");

            PowerA234(A = Math.Round(rand.NextDouble() * 10, 1), ref B, ref C, ref D);
            Console.WriteLine($"Дано A = {A}; B = {B}; C = {C}; D = {D}");

            PowerA234(A = Math.Round(rand.NextDouble() * 10, 1), ref B, ref C, ref D);
            Console.WriteLine($"Дано A = {A}; B = {B}; C = {C}; D = {D}");

            PowerA234(A = Math.Round(rand.NextDouble() * 10, 1), ref B, ref C, ref D);
            Console.WriteLine($"Дано A = {A}; B = {B}; C = {C}; D = {D}");
        }
        static void PowerA234(double A, ref double B, ref double C, ref double D)
        {
            B = Math.Pow(A, 2);
            C = Math.Pow(A, 3);
            D = Math.Pow(A, 4);
        }
    }
}
