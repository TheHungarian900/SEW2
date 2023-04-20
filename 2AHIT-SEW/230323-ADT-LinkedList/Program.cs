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
                    Console.WriteLine("Wählen Sie eines aus der folgenden Liste aus:");
                    Console.WriteLine("1. Ich möchte etwas am Anfang hinzufügen!");
                    Console.WriteLine("2. Ich möchte mir den ersten Hinzugefügten anschauen!");
                    Console.WriteLine("3. Ich möchte den ersten Hinzugefügten entfernen");
                    Console.WriteLine("4. Ich möchte etwas hinzufügen!");
                    Console.WriteLine("5. Ich möchte an einer bestimmten Stelle etwas entfernen!");
                    Console.WriteLine("6. Ich möchte etwas entfernen!");
                    Console.WriteLine("7. Move next!");
                    Console.WriteLine("8. Move last!");
                    Console.WriteLine("9. Move first!");
                    Console.WriteLine("10. Ich möchte alles löschen!");
                    Console.WriteLine("11. Exit! \n\n");

                    input1 = Console.ReadLine();
                    isOk1 = Int32.TryParse(input1, out selection);

                } while (selection < 1 || selection > 11);

                switch (selection)
                {
                    case 1:

                        Console.WriteLine("Eingabe:");
                        input2 = Console.ReadLine();
                        input.Enqueue(input2);


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

                        Console.WriteLine("Geben Sie etwas ein: ");
                        input.Insert(Console.ReadLine());

                        break;

                    case 5:

                        Console.WriteLine("Remove(T key) missing!");

                        break;

                    case 6:

                        try
                        {
                            Console.WriteLine(input.Remove() + " wurde entfernt! \n\n");
                        }
                        catch(InvalidOperationException e)
                        {
                            Console.WriteLine();
                        }

                        break;

                    case 7:

                        if(input.MoveNext() == false)
                        {
                            Console.WriteLine("Not possible!");
                        }

                        break;

                    case 8:

                        if(input.MoveLast() == false)
                        {
                            Console.WriteLine("Not possible!");
                        }

                        break;

                    case 9:

                        if (input.MoveFirst() == false)
                        {
                            Console.WriteLine("Not possible!");
                        }

                        break;

                    case 10:

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
            } while (selection != 11);
            

            


        }
    }
}
