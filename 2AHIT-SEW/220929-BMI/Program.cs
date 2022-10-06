using System;

namespace _220929_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3, sex;
            double kg, metre, bmi;
            bool isOk1, isOk2, isOk3;

            Console.WriteLine("BMI calculator!");

            Console.Write("Geben Sie Ihr Körpergewicht in Kilogramm an: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie Ihre Höhe in Meter an: ");
            input2 = Console.ReadLine();

            Console.Write("Geben Sie Ihr Geschlecht an (m/w): ");
            sex = Console.ReadLine();

            isOk1 = double.TryParse(input1, out kg);
            isOk2 = double.TryParse(input2, out metre);

            if(isOk1 == true && isOk2 == true)
            {

                bmi = kg / Math.Pow(metre, 2);

                if (sex[0] == 'm')
                {
                    if(bmi <= 15.2)
                    {
                        Console.WriteLine("Sie sind stark untergewichtig!");
                    }
                    else if(bmi > 15.2 && bmi < 16.15)
                    {
                        Console.WriteLine("Sie sind mäßig untergewichtig!");
                    }
                    else if(bmi >= 16.15 && bmi < 17.575)
                    {
                        Console.WriteLine("Sie sind leicht untergewichtig!");
                    }
                    else if(bmi >= 17.575 && bmi < 23.75)
                    {
                        Console.WriteLine("Sie haben ein normales Gewicht!");
                    }
                    else if(bmi >= 23.75 && bmi < 28.5)
                    {
                        Console.WriteLine("Sie haben Präadipositas!");
                    }
                    else if(bmi >= 28.5 && bmi < 31.5)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad |!");
                    }
                    else if(bmi >= 31.5 && bmi < 38)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad ||!");
                    }
                    else if(bmi >= 38)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad |||!");
                    }
                }
                else if(sex[0] == 'w')
                {
                    if(bmi <= 14.4)
                    {
                        Console.WriteLine("Sie sind stark untergewichtig!");
                    }
                    else if(bmi >= 14.4 && bmi < 15.3)
                    {
                        Console.WriteLine("Sie sind mäßig untergewichtig!");
                    }
                    else if(bmi >= 15.3 && bmi < 16.65)
                    {
                        Console.WriteLine("Sie sind leicht untergewichtig!");
                    }
                    else if(bmi >= 16.65 && bmi < 22.5)
                    {
                        Console.WriteLine("Sie haben ein normales Gewicht!");
                    }
                    else if(bmi >= 22.5 && bmi < 27)
                    {
                        Console.WriteLine("Sie haben Präadipositas!");
                    }
                    else if(bmi >= 27 && bmi < 31.5)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad |!");
                    }
                    else if(bmi >= 31.5 && bmi < 36)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad ||!");
                    }
                    else if(bmi >= 36)
                    {
                        Console.WriteLine("Sie haben Adipositas Grad |||!");
                    }
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                }

            }
        }
    }
}
