using System;

namespace _220926_Cylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2;
            double surface, volume, height, r;
            bool isOk1, isOk2;

            Console.WriteLine("Cylinder calculation!");

            Console.Write("Geben Sie die Höhe des Zylinders ein: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie den Radius des Zylinders ein: ");
            input2 = Console.ReadLine();

            isOk1 = double.TryParse(input1, out height);
            isOk2 = double.TryParse(input2, out r);

            if(isOk1 == true && isOk2 == true)
            {

                volume = Math.Pow(r, 2) * Math.PI * height;
                surface = 2 * Math.Pow(r, 2) * Math.PI + 2 * r * Math.PI * height;

                Console.WriteLine("Das Volumen des Zylinders beträgt: {0}", volume);
                Console.WriteLine("Die Oberfläche des Zylinders beträgt: {0}", surface);

            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            Console.ReadKey();
        }
    }
}
