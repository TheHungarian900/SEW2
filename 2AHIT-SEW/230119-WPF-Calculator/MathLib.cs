using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _230119_WPF_Calculator
{
    static class MathLib
    {
        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double Sub(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static bool Divide(double num1, double num2, ref double result)
        {
            if(num2 != 0)
            {
                result = num1 / num2;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
