using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Truck : Car
    {
        int load;
        int consumption;

        public Truck()
        {
            this.load = 0;
            this.consumption = 0;
        }

        public Truck(string make, string model, int modelYear, double price,int engine,string type,int doors, int load, int consumption) : base(make, model, modelYear, price,engine,type,doors)
        {
            this.load = load;
            this.consumption = consumption;
        }
        public void CalculateConsumption()
        {
            double kulutus = this.load / this.consumption;
            Console.WriteLine(this.make + ", Kulutus: " + kulutus);
        }

        public override void PrintInformation()
        {
            base.PrintInformation();
            Console.WriteLine(", Load:" + this.load + ", Consumption:" + this.consumption);
        }
    }
}
