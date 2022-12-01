using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221201_QuadSolver
{
    class QuadSolver
    {
        public static string Evaluate(double a, double b, double c)
        {
            double D;        //Diskriminante
            double x1, x2;   //Solutions

            if(a == 0)
            {
                if (b != 0)
                {
                    x1 = -c / b;
                    return "Eine reelle Lösung: " + x1;
                }
                else
                {
                    return "Blödsinn!";
                }
            }
            else if(b == 0)
            {
                double x1Squared = -c / a;

                if (x1Squared < 0)
                {
                    return "Komplex";
                }
                else
                {
                    x1 = Math.Sqrt(x1Squared);
                    x2 = -x1;

                    return "Zwei reelle Lösungen x1 = " + x1 + " x2 = " + x2;
                }
            }

            D = Math.Pow(b, 2) - 4 * a * c;

            if(D == 0)
            {
                return "Eine Lösung: " + (-b / (2 * a));
            }
            else if(D > 0)
            {
                x1 = (-b - Math.Sqrt(D)) / (2 * a);
                x2 = (-b + Math.Sqrt(D)) / (2 * a);

                return "Zwei reelle Lösungen x1 = " + x1 + " x2 = " + x2;
            }
            else
            {
                return "Komplex";
            }
        }
    }
}
