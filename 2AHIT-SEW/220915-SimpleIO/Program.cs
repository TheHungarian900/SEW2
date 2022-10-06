using System;

namespace _220915_SimpleIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string vorname, nachname, schuelerkennzahl;

            Console.Write("Geben Sie Ihren Vornamen ein: ");
            vorname = Console.ReadLine();

            Console.Write("Geben Sie Ihren Nachnamen ein: ");
            nachname = Console.ReadLine();

            Console.Write("Geben Sie Ihr Schülerkennzahl ein: ");
            schuelerkennzahl = Console.ReadLine();

            Console.WriteLine("Ihr Name ist {0} {1} und Ihr Schuelerkennzahl lautet {2}", vorname, nachname, schuelerkennzahl);
        }
    }
}
