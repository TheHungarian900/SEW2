using System;

namespace _221011_HighLowQuiz
{
    class Program
    {
        public static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(1, 100);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("HighLow-Ratespiel!");

            string input1;
            double rand, tries = 0, input2;
            bool isOk;

            rand = RandomNumber(1, 100);

            Console.Write("Geben Sie eine Zahlen von 1-100 ein: ");

            do
            {
                input1 = Console.ReadLine();

                isOk = double.TryParse(input1, out input2);

                if(isOk == true && input2 <= 100 && input2 >= 1)
                {
                    if(input2 < rand)
                    {
                        Console.WriteLine("Zu klein!");
                    }
                    else if(input2 > rand)
                    {
                        Console.WriteLine("Zu Groß!");
                    }
                    else if(input2 == rand)
                    {
                        Console.WriteLine("Richtig!");
                    }
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");

                    Console.Write("Geben Sie eine Zahl von 1-100 ein: ");
                }

                tries++;

            } while (input2 != rand);

            Console.WriteLine("Versuche insgesamt: {0}", tries);

            Console.ReadKey();
        }
    }
}
