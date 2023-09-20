using System;
using System.Collections.Generic;
using System.Text;

namespace _230523_Inheritance
{
    class MeansOfTransportation
    {
        //private double height;
        public double Height { get; set; }

        //private double width;
        public double Width { get; set; }

        //private double length;
        public double Length { get; set; }

        //private double weight;
        public double Weight { get; set; }

        //private double price;
        public double Price { get; set; }

        //private int velocity;
        public int Velocity { get; set; }

        //private int constructionYear;
        public int ConstructionYear { get; set; }

        //private string brand;
        public string Brand { get; set; }

        //private string serialNumber;
        public string SerialNumber { get; set; }

        //private string typeOfPower;
        public string TypeOfPower { get; set; }

        private bool hasEngine;

        public MeansOfTransportation() { }

        public MeansOfTransportation(double height, double width, double length, double weight, double price, int velocity, int constructionYear, string brand, string serialNumber, string typeOfPower, bool hasEngine)
        {
            this.Height = height;
            this.Width = width;
            this.Length = length;
            this.Weight = weight;
            this.Price = price;
            this.Velocity = velocity;
            this.ConstructionYear = constructionYear;
            this.Brand = brand;
            this.SerialNumber = serialNumber;
            this.TypeOfPower = typeOfPower;
            this.hasEngine = hasEngine;
        }

        public void Accelerate(int accelerate)
        {
            this.Velocity += accelerate;
        }

    }
}
