using System;

namespace _230323_ADT_LinkedQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1;
            int selection;
            bool isOk1;

            LinkedQueue<string> input = new LinkedQueue<string>();

            do
            {
                do
                {
                    Console.WriteLine("Wählen Sie eines aus der folgenden Liste aus:");
                    Console.WriteLine("1. Ich möchte etwas hinzufügen!");
                    Console.WriteLine("2. Ich möchte mir den ersten Hinzugefügten anschauen!");
                    Console.WriteLine("3. Ich möchte den ersten Hinzugefügten entfernen!");
                    Console.WriteLine("4. Ich möchte alles löschen!");
                    Console.WriteLine("5. Exit! \n\n");

                    input1 = Console.ReadLine();
                    isOk1 = Int32.TryParse(input1, out selection);
                } while (selection < 1 || selection > 5);

                switch (selection)
                {
                    case 1:

                        Console.WriteLine("Eingabe:");
                        input.Enqueue(Console.ReadLine());

                        break;

                    case 2:

                        try
                        {
                            Console.WriteLine(input.Peek() + " wurde als erstes hinzugefügt. \n\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;


                    case 3:

                        try
                        {
                            Console.WriteLine(input.Dequeue() + " wurde entfernt! \n\n");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 4:

                        try
                        {
                            input.Clear();
                            Console.WriteLine("Es wurde alles entfernt!");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                }

            } while (selection != 5);

        }
    }
}
