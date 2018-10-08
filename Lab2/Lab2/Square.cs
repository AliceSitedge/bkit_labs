using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Square : Rectangle, IPrint
    {
        public Square(double side)
            : base(side, side)
        {
            this.Type = "Квадрат";
        }

        public override string ToString()
        {
            return this.Type + " со стороной " + this.height.ToString()
                + " и площадью " + this.Area().ToString();
        }
    }
}
