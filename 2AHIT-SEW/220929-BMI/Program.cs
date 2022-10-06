using System;

namespace _220929_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, input3, gender;
            double kg, metre, bmi, factor;
            bool isOk1, isOk2, isOk3;

            factor = 1;

            Console.WriteLine("BMI calculator!");

            Console.Write("Geben Sie Ihr Körpergewicht in Kilogramm an: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie Ihre Höhe in Meter an: ");
            input2 = Console.ReadLine();

            Console.Write("Geben Sie Ihr Geschlecht an (m/w): ");
            gender = Console.ReadLine();

            isOk1 = double.TryParse(input1, out kg);
            isOk2 = double.TryParse(input2, out metre);

            if(isOk1 == true && isOk2 == true)
            {

                bmi = kg / Math.Pow(metre, 2);

                if(gender.Equals("m"))
                {
                    factor = 0.95;
                }
                else if(gender.Equals("w"))
                {
                    factor = 0.9;
                }


                if(bmi < 16 * factor)
                {
                   Console.WriteLine("Sie sind stark untergewichtig!");
                }
                else if(bmi >= 16 * factor && bmi < 17 * factor)
                {
                   Console.WriteLine("Sie sind mäßig untergewichtig!");
                }
                else if(bmi >= 17 * factor && bmi < 18.5 * factor)
                {
                   Console.WriteLine("Sie sind leicht untergewichtig!");
                }
                else if(bmi >= 18.5 * factor && bmi < 25 * factor)
                {
                   Console.WriteLine("Sie haben ein normales Gewicht!");
                }
                else if(bmi >= 25 * factor && bmi < 30 * factor)
                {
                   Console.WriteLine("Sie haben Präadipositas!");
                }
                else if(bmi >= 30 * factor && bmi < 35 * factor)
                {
                   Console.WriteLine("Sie haben Adipositas Grad |!");
                }
                else if(bmi >= 35 * factor && bmi < 40 * factor)
                {
                   Console.WriteLine("Sie haben Adipositas Grad ||!");
                }
                else if(bmi >= 40 * factor)
                {
                   Console.WriteLine("Sie haben Adipositas Grad |||!");
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                }

            }
        }
    }
}
