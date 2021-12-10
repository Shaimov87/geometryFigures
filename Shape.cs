using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Shape
    {
       public const double Pi = 3.14; 
       public double P()
        {
            return 0;
        }
        public double S()
        {
            return 0;
        }

        public string Name { get; set; }

        public Shape()
        {
            Name = "Empty";
            
        }
        public Shape(string name)
        {
            Name = name;
        }
        public override string ToString()
        {
            return Name ;
        }
    }
}
