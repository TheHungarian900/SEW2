using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230126_Rectangle_WPF
{
    class Rectangle
    {
        double length, width, area, circumference;

        public Rectangle()
        {
            length = 0;
            this.width = 0;
        }

        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
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

        //private
        private double getCircumference()
        {
            if (length < 0)
            {
                length *= -1;
            }
            else if (width < 0)
            {
                width *= -1;
            }

            return 2 * (length + width);
        }

        private double getArea()
        {
            if (length < 0)
            {
                length *= -1;
            }
            else if (width < 0)
            {
                width *= -1;
            }

            return length * width;
        }

        //properties
        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        public double Area
        {
            get { return getArea(); }
        }
        public double Circumference
        {
            get { return getCircumference(); }
        }
    }

    
}
