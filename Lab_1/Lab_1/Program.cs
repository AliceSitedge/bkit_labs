using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            do
            {
                double a, b, c;
                a = ReadIndex("A");
                b = ReadIndex("B");
                c = ReadIndex("C");

                //Console.WriteLine("Вы ввели коэффициенты: A = {0}, B = {1}, C = {2}.", a, b, c);

                double d = b * b - 4 * a * c;
                if (d == 0)
                {
                    double x = -b / 2 / a;
                    Console.WriteLine("Один корень: x = {0:F3}.", x);
                }
                else if (d > 0)
                {
                    double x1, x2;
                    x1 = (-b - Math.Sqrt(d)) / 2 / a;
                    x2 = (-b + Math.Sqrt(d)) / 2 / a;
                    Console.WriteLine("2 действительных корня: x1 = {0:F3}, x2 = {1:F3}.", x1, x2);
                }
                else
                {
                    double a1, a2;
                    a1 = -b / 2 / a;
                    a2 = Math.Sqrt(-d) / 2 / a;
                    Console.WriteLine("2 комплексных корня: x1 = {0:F3} - {1:F3}*i, x2 = {0:F3} + {1:F3}*i.", a1, a2);
                }

                Console.WriteLine("Продолжить? (1/0)");
                string str = Console.ReadLine();
                answer = int.Parse(str);
            } while (answer != 0);
        }

        static double ReadIndex(string index)
        {
            Console.Write("Введите коэффициент " + index + ": ");
            double ind;
            string str;
            bool check;
            do
            {
                str = Console.ReadLine();
                check = double.TryParse(str, out ind);
                if (!check)
                    Console.WriteLine("Введите число.");
            }
            while (!check);

            return ind;
        }
    }
}
