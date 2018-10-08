using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(3.5, 8);
            Square square = new Square(6.3);
            Circle circle = new Circle(2);

            rect.Print();
            square.Print();
            circle.Print();

            Console.ReadLine();
        }
    }
}
