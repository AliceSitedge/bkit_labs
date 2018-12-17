using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Square : Rectangle
    {
        public Square(double side)
            : base(side, side)
        {
            this.Type = "Квадрат";
        }
    }
}
