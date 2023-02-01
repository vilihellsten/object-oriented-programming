using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Employee : Person
    {
        private string id;
        public Employee ()
        {
            this.id = "asd";
        }

        public Employee(string name, string id):base(name)
        {

            this.id = id;
        }

        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   name == employee.name &&
                   id == employee.id;
        }


        public override void GetInfo()
        {
            base.GetInfo();
            //Console.WriteLine(this.id + " " + this.name);
            Console.WriteLine(this.id);
        }

        public override string? ToString()
        {
            return base.ToString() + this.id;
        }
    }
}
