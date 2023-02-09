using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230126_Rectangle_WPF
{
    class Circle
    {
        double radius, xm, ym, area, circumference;

        public Circle()
        {
            this.radius = 0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        //Konstruktorverkettung
        public Circle(double radius, double xm, double ym) : this(radius)
        {
            this.xm = xm;
            this.ym = ym;
        }

        //public
        public double GetCircumference()
        {
            return 2 * radius * Math.PI;
        }

        public double GetArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }

        //private
        private double getCircumference()
        {
            if (radius < 0)
            {
                radius *= -1;
            }

            return 2 * radius * Math.PI;
        }

        private double getArea()
        {
            if (radius < 0)
            {
                radius *= -1;
            }

            return Math.Pow(radius, 2) * Math.PI;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double Area
        {
            get { return Math.Abs(getArea()); }
        }
        public double Circumference
        {
            get { return Math.Abs(getCircumference()); }
        }
    }
}
