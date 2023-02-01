using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Vehicle
    {
        protected string make;
        protected string model;
        protected int modelYear;
        protected double price;

        public Vehicle()
        {
            this.make = string.Empty;
            this.model = string.Empty;
            this.modelYear = 0;
            this.price = 0;
        }
        
        public Vehicle(string make, string model, int modelYear, double price)
        {
            this.make = make;
            this.model = model;
            this.modelYear = modelYear;
            this.price = price;
        }

        public virtual void PrintInformation()
        {
            Console.Write("Make:" + this.make + ", Model:" + this.model + ", Year:" + this.modelYear + ", Price:" + this.price);
        }

        public virtual string? ToString()
        {
            return "Make:" + this.make + ", Model:" + this.model + ", Year:" + this.modelYear + ", Price:" + this.price;
        }
    }
}
