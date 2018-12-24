using System;
using System.Security.Cryptography.X509Certificates;

namespace Lab6_1
{
    delegate int PlusOrMinus(int p1, int p2);
    class Program
    {
        static int Plus(int p1, int p2)
        {
            return p1 + p2;
        }
        
        static int Minus(int p1, int p2)
        {
            return p1 - p2;
        }

        static void PlusOrMinusMethod(
            string str,
            int i1,
            int i2,
            PlusOrMinus PlusOrMinusParam)
        {
            int Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        static void PlusOrMinusMethodFunc(
            string str,
            int i1,
            int i2,
            Func<int, int, int> PlusOrMinusParam)
        {
            int Result = PlusOrMinusParam(i1, i2);
            Console.WriteLine(str + Result.ToString());
        }

        public static void Main(string[] args)
        {
            int i1 = 3;
            int i2 = 2;

            Console.WriteLine("Передача в качестве параметра разработанного делегата:");
            PlusOrMinusMethod("Плюс: ", i1, i2, Plus);
            PlusOrMinusMethod("Минус: ", i1, i2, Minus);

            Console.WriteLine("\nПередача в качестве параметра лямбда-выражения:");
            PlusOrMinusMethod(
                "Плюс: ",
                i1,
                i2,
                (int x, int y) =>
                {
                    int z = x + y;
                    return z;
                }
            );

            PlusOrMinusMethod(
                "Минус: ",
                i1,
                i2,
                (int x, int y) =>
                {
                    int z = x - y;
                    return z;
                }
            );

            Console.WriteLine("\nИспользование обобщенного делегата Func< >:");
            PlusOrMinusMethodFunc("Плюс: ", i1, i2, Plus);
            PlusOrMinusMethodFunc("Минус: ", i1, i2, Minus);
            

            Console.ReadLine();
        }
    }
}