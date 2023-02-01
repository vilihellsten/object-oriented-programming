using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Car : Vehicle
    {
        protected int engine;
        protected string type;
        protected int doors;

        public Car()
        {
            this.engine = 0;
            this.type = string.Empty;
            this.doors = 0;
        }

        public Car(string make, string model, int modelYear, double price,int engine, string type, int doors) : base (make,type,modelYear,price)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public override bool Equals(object? obj)
        {
            return obj is Car car &&
                   make == car.make &&
                   model == car.model &&
                   modelYear == car.modelYear &&
                   price == car.price &&
                   engine == car.engine &&
                   type == car.type &&
                   doors == car.doors;
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.Write(" Engine:" + this.engine + ", Type:" + this.type + ", Doors:" + this.doors);
        }

        public override string? ToString()
        {
            return base.ToString() + " Engine:" + this.engine + ", Type:" + this.type + ", Doors:" + this.doors;
        }
    }
}
