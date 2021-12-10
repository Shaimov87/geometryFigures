using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Square:Shape
    {
        private double a;

        public Square() : base()
        {
            a = 0;
        }
        public Square(string name,double a) : base(name)
        {
            this.a = a;
        }
        public new double P()
        {
            return a * 4;
        }
        public new double S()
        {
            return a * a;
        }
        public override string ToString()
        {
            return base.ToString() + $"a={a}, P={P()}, S={S()}";
        }
    }
}
