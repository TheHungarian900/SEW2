using System;
using System.Collections.Generic;
using System.Text;

namespace _230523_Inheritance
{
    class CarWithEngine : LandVehicle
    {
        //private double horsePower;
        public double HorsePower { get; set; }
        
        //private double tirePressure;
        public double TirePressure { get; set; }
        
        //private double consumption;
        public double Consumption { get; set; }

        public double PowerUsage { get; set; }

        //private double fuel;
        public double Fuel { get; set; }

        //private int numberOfDoors;
        public int NumberOfDoors { get; set; }
        
        //private int numberOfTires;
        public int NumberOfTires { get; set; }
        
        //private int torque;
        public int Torque { get; set; }

        //private string licensePlate;
        public string LicensePlate { get; set; }
        
        //private string typeOfTires;
        public string TypeOfTires { get; set; }
        
        //private string typeOfBrakes;
        public string TypeOfBrakes { get; set; }

        //private string drivetrain;
        public string Drivetrain { get; set; }

        private bool engine = false;
        public bool Engine { get { return engine; } set { engine = value; } }

        private bool door = false;
        public bool Door { get { return door; } set { door = value; } }

        public CarWithEngine() { }

        public CarWithEngine(double horsePower, double tirePressure, double consumption, double fuel, int numberOfDoors, int numberOfTires, int torque, string licensePlate, string typeOfTires, string typeOfBrakes, string drivetrain, double distanceDriven, double height, double width, double length, double weight, double price, int velocity, int constructionYear, string brand, string serialNumber, string typeOfPower, bool hasEngine) : base (distanceDriven, height, width, length, weight, price, velocity, constructionYear, brand, serialNumber, typeOfPower, hasEngine)
        {
            this.HorsePower = horsePower;
            this.TirePressure = tirePressure;
            this.Consumption = consumption;
            this.Fuel = fuel;
            this.NumberOfDoors = numberOfDoors;
            this.NumberOfTires = numberOfTires;
            this.Torque = torque;
            this.LicensePlate = licensePlate;
            this.TypeOfTires = typeOfTires;
            this.TypeOfBrakes = typeOfBrakes;
            this.Drivetrain = drivetrain;
        }

        public void StartEngine(bool engine)
        {
            if(this.Engine == engine)
            {
                throw new Exception("Engine is running already!");
            }
            else
            {
                this.Engine = engine;
            }
        }
        public void StopEngine(bool engine)
        {
            if (this.Engine == engine)
            {
                throw new Exception("Engine has been stopped already!");
            }
            else
            {
                this.Engine = engine;
            }
        }
        public void OpenDoor(bool door)
        {
            if (this.Door == door)
            {
                throw new Exception("Door is already open!");
            }
            else
            {
                this.Door = door;
            }
        }
        public void CloseDoor(bool door)
        {
            if (this.Door == door)
            {
                throw new Exception("Door is already closed!");
            }
            else
            {
                this.Door = door;
            }
        }
        public void GetPowerUsage(double powerUsage)
        {
            this.PowerUsage = powerUsage;
        }
    }
}
