using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _221221_Zahlenfeld_WPF
{
    static class ArrayMethods
    {
        public static bool Mittelwert(double[] f, int amount, int n, out double mw)
        {
            mw = 0;
            n--;
            if (0 <= n && n < amount && n <= f.Length)
            {
                n++;
                for (int i = 0; i < n; i++)
                {
                    mw += f[i];
                }
                mw = mw / n;
                return true;
            }

            return false;
        }
        public static bool Minimum(double[] f, int amount, int n, out double min)
        {
            min = f[0];
            n--;
            if (0 <= n && n < amount && n <= f.Length)
            {
                n++;
                for (int i = 0; i < n; i++)
                {
                    if(f[i] < min)
                    {
                        min = f[i];
                    }
                }
                return true;
            }
            min = 0;
            return false;
        }
        public static bool Maximum(double[] f, int amount, int n, out double max)
        {
            max = f[0];
            n--;

            if (0 <= n && n < amount && n <= f.Length)
            {
                n++;
                for (int i = 0; i < n; i++)
                {
                    if (f[i] > max)
                    {
                        max = f[i];
                    }
                }
                return true;
            }
            max = 0;
            return false;
        }
        public static bool Search(double[] f, double n, out double firstFound, out double search)
        {
            search = 0;
            firstFound = 0;

            for (int i = f.Length; i > 0; i--)
            {
                if (n == f[i-1])
                {
                    firstFound = i;
                    search++;
                }
            }

            if(search > 0)
            {
                return true;
            }
            else
            {
                n = -1;
                return false;
            }
        }
    }
}
