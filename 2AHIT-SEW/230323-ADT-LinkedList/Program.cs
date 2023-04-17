using System;

namespace _230323_ADT_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input2, input1;
            int selection;
            bool isOk1;

            LinkedList<string> input = new LinkedList<string>();

            do
            {
                do
                {
                    Console.WriteLine("Wählen Sie eines aus der folgenden Liste aus: \n\n");
                    Console.WriteLine("1. Ich möchte etwas am Anfang hinzufügen! \n");
                    Console.WriteLine("2. Ich möchte mir den letzten Hinzugefügten anschauen! \n");
                    Console.WriteLine("3. Ich möchte den ersten Hinzugefügten entfernen");
                    Console.WriteLine("4. Ich möchte etwas hinzufügen! \n");
                    Console.WriteLine("5. Ich möchte die Liste auf einen Eintrag überprüfen! \n");
                    Console.WriteLine("6. Ich möchte etwas entfernen");
                    Console.WriteLine("7. Ich möchte alles löschen! \n");
                    Console.WriteLine("8. Exit! \n\n\n");

                    input1 = Console.ReadLine();
                    isOk1 = Int32.TryParse(input1, out selection);

                } while (selection < 1 || selection > 8);

                switch (selection)
                {
                    case 1:

                        Console.WriteLine("Eingabe: \n\n");
                        input2 = Console.ReadLine();
                        input.Enqueue(input2);


                        break;

                    case 2:

                        try
                        {
                            Console.WriteLine(input.Peek() + " wurde als letztes hinzugefügt. \n\n\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;


                    case 3:

                        try
                        {
                            Console.WriteLine(input.Dequeue() + " wurde entfernt! \n\n\n");
                        }
                        catch (InvalidOperationException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case 4:

                        try
                        {

                        }

                        break;

                    case 5:

                        try
                        {

                        }

                        break;

                    case 6:

                        try
                        {

                        }

                        break;

                    case 7:

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
            } while (selection != 8);
            

            


        }
    }
}
