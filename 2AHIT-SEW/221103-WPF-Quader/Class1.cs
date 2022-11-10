using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221103_WPF_Quader
{
    class QuaderCalculation
    {

        public static double calcVolume(double length, double width, double height)
        {
            return length * width * height;
        }
        public static double calcSurface(double length, double width, double height)
        {
            return 2 * (length * height + height * width + width * length);
        }

    }
}
