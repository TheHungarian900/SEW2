using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nsMath
{
    static class MathOperations
    {

        public const double PI = 3.1415926;
        public const double E = 2.718281828;

        public class NegativeArgumentException : Exception
        {
            public NegativeArgumentException() { }
            public NegativeArgumentException(string message) : base(message) { }
            public NegativeArgumentException(string message, Exception inner) : base(message, inner) { }
        }

        public static double Add(double a, double b) 
        {
            return a + b;
            
        }
        public static double Sub(double a, double b) 
        {
            return a - b;
        }
        public static double Mult(double a, double b) 
        {
            return a * b;
        }
        public static double Div(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return a / b;
            }
        }

        public static double Abs(double a) { return Math.Abs(a); }
        public static double Signum(double a)
        {
            if (a == 0) return 0;
            return (a < 0) ? -1 : 1;
        }

        public static long Factorial(long n)
        {
            checked
            {
                if (n == 1 || n == 0)
                {
                    return 1;
                }
                else
                {
                    return Factorial(n - 1) * n;
                }
            }
        }
    }
}
