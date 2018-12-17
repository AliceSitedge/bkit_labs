using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3.5, 8);
            Square square = new Square(6.3);
            Circle circle = new Circle(2);

            Console.WriteLine("===== Коллекция класса ArrayList =====");
            ArrayList al = new ArrayList();
            al.Add(rect);
            al.Add(square);
            al.Add(circle);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (var x in al) Console.WriteLine(x);
            al.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (var x in al) Console.WriteLine(x);


            Console.WriteLine("/n===== Коллекция класса List<Figure> =====");
            List<Figure> fl = new List<Figure>();
            fl.Add(rect);
            fl.Add(square);
            fl.Add(circle);
            Console.WriteLine("\nПеред сортировкой:");
            foreach (var x in fl) Console.WriteLine(x);
            fl.Sort();
            Console.WriteLine("\nПосле сортировки:");
            foreach (var x in fl) Console.WriteLine(x);

            Console.WriteLine("/n===== Разреженная матрица =====\n");
            Matrix<Figure> matrix = new Matrix<Figure>(3, 3, 3, new FigureMatrixCheckEmpty());
            matrix[0, 0, 1] = rect;
            matrix[1, 1, 2] = square;
            matrix[2, 2, 1] = circle;
            Console.WriteLine(matrix.ToString());

            Console.WriteLine("====== Класс SimpleStack ======\n");
            SimpleStack<Figure> stack = new SimpleStack<Figure>();
            stack.Push(rect);
            stack.Push(square);
            stack.Push(circle);
            while (stack.Count > 0)
            {
                Figure f = stack.Pop();
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }
    }
}
