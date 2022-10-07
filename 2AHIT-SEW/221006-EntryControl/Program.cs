using System;

namespace _221006_EntryControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string password; //registration
            string pw;       //log in
            string username; //registration
            int wrong = 0;
            int tries = 3;

            //registration
            Console.WriteLine("Registrierung!");
            Console.Write("\n");

            Console.Write("Benutzername: ");
            username = Console.ReadLine();

            Console.Write("Passwort: ");
            password = Console.ReadLine();

            Console.Write("\n");
            do
            {
                //log in
                if(wrong == 0)
                {
                    Console.WriteLine("Anmeldung!");
                }
                Console.Write("\n");

                Console.Write("Passwort: ");
                pw = Console.ReadLine();

                if(pw == password)
                {
                    Console.WriteLine("Zutritt gewährt!");
                }
                else
                {
                    wrong += 1;
                    tries -= 1;
                    Console.WriteLine("Zutritt Verweigert!");
                    Console.WriteLine("Anzahl der falschen Versuche: {0}", wrong);
                    Console.WriteLine("Zahl der noch verbleibenden Versuche: {0}", tries);
                }
                   
            } while (wrong < 3 && pw != password);

            Console.ReadKey();
        }
    }
}
