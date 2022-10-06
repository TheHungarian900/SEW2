using System;

namespace _220922_Verbrauch
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2;
            double km, litres, consumption;
            bool isOk1, isOk2;

            Console.WriteLine("Durchschnittsverbrauch");

            Console.Write("Wieviele Kilometer sind Sie gefahren: ");
            input1 = Console.ReadLine();

            Console.Write("Wieviel Liter Benzin haben Sie verbraucht: ");
            input2 = Console.ReadLine();

            isOk1 = Double.TryParse(input1, out km);
            isOk2 = Double.TryParse(input2, out litres);

            if(isOk1 == true && isOk2 == true)
            {
                consumption = (100 * litres) / km;
                Console.WriteLine("Ihr Durchschnittsverbrauch beträgt: {0}", consumption);
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            Console.ReadKey();
        }
    }
}
