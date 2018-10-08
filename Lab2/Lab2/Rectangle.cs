using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Rectangle : Figure, IPrint
    {
        public double height { get; protected set; }
        public double width { get; protected set; }
        public Rectangle(double h, double w)
        {
            this.height = h;
            this.width = w;
            this.Type = "Прямоугольник";
        }

        public override double Area()
        {
            return this.height * this.width;
        }

        public override string ToString()
        {
            return this.Type + " со сторонами " + this.height.ToString() + " и "
                + this.width.ToString() + " и площадью " + this.Area().ToString();
        }

        public void Print()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
