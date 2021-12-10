using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Circle:Shape
    {
        private double r;

        public Circle()
        {
            r = 0;
        }
        public Circle(string name, double r) : base(name)
        {
            this.r = r;
        }
        public new double P()
        {
            return 2 * Pi * r;
        }
        public new double S()
        {
            return r * r * Pi;
        }
        public override string ToString()
        {
            return base.ToString() + $"r={r}, P={P()}, S={S()}";
        }
    }
}
