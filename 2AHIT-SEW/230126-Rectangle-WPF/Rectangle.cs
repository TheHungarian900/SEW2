using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230126_Rectangle_WPF
{
    class Rectangle
    {
        double length, width, mass;
        readonly double areaDensity;
        public const string DeveloperName = "Daniel Gyarmati";

        public Rectangle()
        {
            length = 0;
            this.width = 0;
            areaDensity = 0;
        }
        public Rectangle(double length, double width, double areaDensity)
        {
            this.length = length;
            this.width = width;
            this.areaDensity = areaDensity;
        }

        //public
        public double GetCircumference()
        {
            return 2 * (length + width);
        }
        public double GetArea()
        {
            return length * width;
        }
        public double GetMass()
        {
            return getArea() * areaDensity;
        }

        //private
        private double getCircumference()
        {
            return 2 * (length + width);
        }
        private double getArea()
        {
            return length * width;
        }
        private double getMass()
        {
            return getArea() * areaDensity;
        }

        //properties
        public double Length
        {
            get { return length; }
            set
            {
                Math.Abs(value);
                length = value;
            }
        }

        // max = (a>b)?a:b

        public double Width
        {
            get { return width; }
            set
            {
                Math.Abs(value);
                width = value;
            }
        }
        
        public double Area
        {
            get { return Math.Abs(getArea()); }
        }
        public double Circumference
        {
            get { return Math.Abs(getCircumference()); }
        }
        public double Mass
        {
            get {return Math.Abs(getMass()); }
        }
    }

    
}
