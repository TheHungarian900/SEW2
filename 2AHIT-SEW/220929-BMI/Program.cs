using System;

namespace _220929_BMI
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1, input2, gender;
            double mass, height, bmi, factor;
            bool isOk1, isOk2;

            factor = 1;

            Console.WriteLine("BMI calculator!");

            Console.Write("Geben Sie Ihr Körpergewicht in Kilogramm an: ");
            input1 = Console.ReadLine();

            Console.Write("Geben Sie Ihre Höhe in cm an: ");
            input2 = Console.ReadLine();

            Console.Write("Geben Sie Ihr Geschlecht an (m/w): ");
            gender = Console.ReadLine();

            isOk1 = double.TryParse(input1, out mass);
            isOk2 = double.TryParse(input2, out height);

            height = height / 100;

            if(isOk1 == true && isOk2 == true)
            {

                bmi = mass / Math.Pow(height, 2);

                if(gender.Equals("m"))
                {
                    factor = 0.95;
                }
                else if(gender.Equals("w"))
                {
                    factor = 0.9;
                }


                if(bmi < 16)
                {
                   Console.WriteLine("Sie sind stark untergewichtig!");
                }
                else if(bmi >= 16 && bmi < 17)
                {
                   Console.WriteLine("Sie sind mäßig untergewichtig!");
                }
                else if(bmi >= 17 && bmi < 18.5)
                {
                   Console.WriteLine("Sie sind leicht untergewichtig!");
                }
                else if(bmi >= 18.5 && bmi < 25 * factor)
                {
                   Console.WriteLine("Sie haben ein normales Gewicht!");
                }
                else if(bmi >= 25 * factor && bmi < 30)
                {
                   Console.WriteLine("Sie haben Präadipositas!");
                }
                else if(bmi >= 30 && bmi < 35)
                {
                   Console.WriteLine("Sie haben Adipositas Grad |!");
                }
                else if(bmi >= 35 && bmi < 40)
                {
                   Console.WriteLine("Sie haben Adipositas Grad ||!");
                }
                else if(bmi >= 40)
                {
                   Console.WriteLine("Sie haben Adipositas Grad |||!");
                }
                else
                {
                    Console.WriteLine("Fehlerhafte Eingabe!");
                }
                Console.ReadKey();
            }
        }
    }
}
