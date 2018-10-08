using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    abstract class Figure
    {
        string _Type;
        public string Type
        {
            get
            {
                return this._Type;
            }
            protected set
            {
                this._Type = value;
            }
        }
        public abstract double Area();
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
