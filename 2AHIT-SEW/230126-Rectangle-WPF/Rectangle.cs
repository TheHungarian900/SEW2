using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230126_Rectangle_WPF
{
    class Rectangle
    {
        double length, width;

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }

        public double GetCircumference()
        {
            return 2 * (length + width);
        }

        public double GetArea()
        {
            return length * width;
        }
    }

    class Circle
    {
        double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetCircumference()
        {
            return 2 * radius * Math.PI;
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }
}
