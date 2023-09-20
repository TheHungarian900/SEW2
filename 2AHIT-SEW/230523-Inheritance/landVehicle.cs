using System;
using System.Collections.Generic;
using System.Text;

namespace _230523_Inheritance
{
    class LandVehicle : MeansOfTransportation
    {
        // private double distanceDriven;

        public double DistanceDriven { get; set; }

        public LandVehicle() { }

        public LandVehicle(double distanceDriven, double height, double width, double length, double weight, double price, int velocity, int constructionYear, string brand, string serialNumber, string typeOfPower, bool hasEngine) : base(height, width, length, weight, price, velocity, constructionYear, brand, serialNumber, typeOfPower, hasEngine)
        {
            this.DistanceDriven = distanceDriven;
        }
    }
}
