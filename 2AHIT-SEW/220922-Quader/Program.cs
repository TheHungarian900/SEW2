using System;

namespace _220922_Quader
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3;
            double length, width, height, volume, surface;
            bool isOk1, isOk2, isOk3;

            Console.WriteLine("Quaderberechnung");

            Console.Write("Geben Sie die Länge des Quaders ein: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie die Breite des Quaders ein: ");
            input2 = Console.ReadLine();

            Console.Write("Geben Sie die Höhe des Quaders ein: ");
            input3 = Console.ReadLine();

            //converting string to double

            isOk1 = Double.TryParse(input1, out length);
            isOk2 = Double.TryParse(input2, out width);
            isOk3 = Double.TryParse(input3, out height);

            if(isOk1 == true && isOk2 == true && isOk3 == true)
            {
                volume = length * width * height;
                surface = 2 * (length * width + width * height + height * length);

                Console.WriteLine("Das Volumen des Quaders beträgt: {0}", volume);
                Console.WriteLine("Die Oberfläche des Quaders beträgt: {0}", surface);
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            Console.ReadKey();
        }
    }
}
