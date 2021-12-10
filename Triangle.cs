using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Triangle:Shape
    {
        public double a, b, c;
        public Triangle() : base()
        {
            a = b = c = 0;
        }
        public Triangle(string name,double a,double b,double c) : base(name)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public new double P()
        {
            return a + b + c;
        }
        public new double S()
        {
            return Math.Sqrt(P() / 2 * (P() / 2 - a) * (P() / 2 - b) * (P() / 2 - c));
        }
        public override string ToString()
        {
            return base.ToString() + $"a={a}, b={b}, c={c}, P={P()}, S={S()}";
        }
    }
}
