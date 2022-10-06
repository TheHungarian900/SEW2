using System;

namespace _220922_Zahlensumme
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe1, eingabe2;
            double zahl1, zahl2, summe;
            bool isOk1, isOk2;

            Console.WriteLine("Zahlenaddition");
            Console.Write("Geben Sie Zahl1 ein: ");
            eingabe1 = Console.ReadLine();

            Console.Write("Geben Sie Zahl2 ein: ");
            eingabe2 = Console.ReadLine();

            //Umwandlung von String in double ohne Fehlerprüfung
            //zahl1 = Convert.ToDouble(eingabe1);
            //zahl2 = Convert.ToDouble(eingabe2);

            //Umwandlung von String in double mit Fehlerprüfung
            //Rückgabewert true oder false bei Fehler
            //ggf. weitere Fehlerbehandlung

            isOk1 = Double.TryParse(eingabe1, out zahl1);
            isOk2 = Double.TryParse(eingabe2, out zahl2);

            if(isOk1 == true && isOk2 == true)
            {
                summe = zahl1 + zahl2;
                Console.WriteLine("Summe {0} + {1} = {2}", zahl1, zahl2, summe);
            }
            else
            {
                Console.WriteLine("Fehlerhafte Eingabe!");
            }
            Console.ReadKey();
        }
    }
}
