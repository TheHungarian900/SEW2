using System;

namespace _230523_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {

            MeansOfTransportation mot = new MeansOfTransportation();
            LandVehicle lv = new LandVehicle();
            CarWithEngine cwe = new CarWithEngine();

            int select = 0;
            do
            {
                Console.WriteLine("1. Car with an Engine");
                Console.WriteLine("2. Land Vehicle");
                Console.WriteLine("3. Means of Transportation");
                Console.WriteLine("4. Exit");

                select = Int32.Parse(Console.ReadLine());

                if (select >= 1 && select <= 3)
                {

                    Console.WriteLine("Height");
                    cwe.Height = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Width");
                    cwe.Width = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Length");
                    cwe.Length = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Weigth");
                    cwe.Weight = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Price");
                    cwe.Price = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Velocity");
                    cwe.Velocity = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Construction year");
                    cwe.ConstructionYear = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Brand");
                    cwe.Brand = Console.ReadLine();

                    Console.WriteLine("Serial number");
                    cwe.SerialNumber = Console.ReadLine();

                    Console.WriteLine("Type of Power");
                    cwe.TypeOfPower = Console.ReadLine();

                }

                switch (select)
                {
                    case 1:

                        Console.WriteLine("Distance driven");
                        cwe.DistanceDriven = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Horse power");
                        cwe.HorsePower = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Tire pressure");
                        cwe.TirePressure = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Consumption");
                        cwe.Consumption = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Power usage");
                        cwe.PowerUsage = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Fuel");
                        cwe.Fuel = Double.Parse(Console.ReadLine());

                        Console.WriteLine("Number of Doors");
                        cwe.NumberOfDoors = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Number of Tires");
                        cwe.NumberOfTires = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Torque");
                        cwe.Torque = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("License plate");
                        cwe.LicensePlate = Console.ReadLine();

                        Console.WriteLine("Type of tires");
                        cwe.TypeOfTires = Console.ReadLine();

                        Console.WriteLine("Type of brakes");
                        cwe.TypeOfBrakes = Console.ReadLine();

                        Console.WriteLine("Drivetrain");
                        cwe.Drivetrain = Console.ReadLine();


                        break;

                    case 2:

                        Console.WriteLine("Distance driven");
                        cwe.DistanceDriven = Double.Parse(Console.ReadLine());

                        break;

                }
            } while (select < 1 || select > 4);
        }
    }
}

