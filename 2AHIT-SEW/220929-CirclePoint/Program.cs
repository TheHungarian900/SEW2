using System;


namespace _220929_CirclePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;
            double r, xp, yp, d;
            bool isOk1, isOk2, isOk3;

            Console.WriteLine("Circle with Center (Point)");

            Console.Write("Geben Sie den Radius vom Kreis ein: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie Punkt x ein: ");
            input2 = Console.ReadLine();

            Console.Write("Geben Sie Punkt y ein: ");
            input3 = Console.ReadLine();

            isOk1 = double.TryParse(input1, out r);
            isOk2 = double.TryParse(input2, out xp);
            isOk3 = double.TryParse(input3, out yp);

            

            if (isOk1 == true && isOk2 == true && isOk3 == true)
            {
                d = Math.Sqrt(Math.Pow(xp, 2) + Math.Pow(yp, 2));

                if (d == r)
                {
                    Console.WriteLine("Ihr Punkt liegt am Kreis.");
                }
                else if (d < r)
                {
                    Console.WriteLine("Ihr Punkt liegt innerhalb des Kreises.");
                }
                else if (d > r)
                {
                    Console.WriteLine("Ihr Punkt liegt außerhalb des Kreises.");
                }
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            Console.ReadKey();
        }
    }
}
