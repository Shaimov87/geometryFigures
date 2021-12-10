using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Rectangle : Shape 
    {
        private double a, b;

        public Rectangle():base()
        {
            a = b = 0;
        }
        public Rectangle(string name,double a,double b):base(name)
        {
            this.a = a;
            this.b = b;
        }

        public new  double  P ()
        {
            return (a+b)*2;
        }
        public new double S()
        {
            return a * b;
        }

        public override string ToString()
        {
            return base.ToString()+$" a={a}, b={b}, P={P()}, S={S()}";
        }
    }
}
