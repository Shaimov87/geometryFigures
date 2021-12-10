using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometryFigures
{
    class Program
    {
        //const double Pi = 1.14;
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle("rect", 5, 5);
            Console.WriteLine(rect);
            Square square = new Square("square", 3);
            Console.WriteLine(square);
            Circle circle = new Circle("circle", 6);
            Console.WriteLine(circle);
            Triangle triangle = new Triangle("triangle", 2, 3, 4);
            Console.WriteLine(triangle);
        }
    }
}
