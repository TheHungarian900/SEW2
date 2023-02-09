using System;

namespace _230209_Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of 10 to 0: " + Sum(10));

            Console.WriteLine("Sum as recursion");
        }

        //Recursion Example - Sum from i to 0
        public static int Sum(int i)
        {
            if (i == 0)
                return 0;
            else
                return i + Sum(i - 1);
        }
    }
}
