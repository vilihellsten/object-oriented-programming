using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleExercise
{
    internal class Person
    {
        protected string name;
        public Person ()
        {
            this.name = "Jaakko";
        }

        public Person(string name)
        {
            this.name = name;
        }

        public virtual void GetInfo()
        {
            
            Console.WriteLine(this.name);
        }

        public override string? ToString()
        {
            return this.name;
        }
    }
}
