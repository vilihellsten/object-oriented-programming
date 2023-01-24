using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeExercise
{
    internal class Employee
    {
        string name;
        string id;
        string position;
        double salary;

        public Employee()
        {
            this.name = string.Empty;
            this.id = string.Empty;
            this.position = string.Empty;
            this.salary = 0;
        }

        public void CompareSalary(Employee employees)
        {
            if (this.salary == employees.salary)
                Console.WriteLine(this.name + ", " + this.salary + ", " + employees.name + ", " + employees.salary + ", Henkilöiden palkat ovat yhtäsuuret.");
            else
            if (this.salary > employees.salary)
                Console.WriteLine(this.name + ", " + this.salary + ", " + employees.name + ", " + employees.salary + ", Henkilön " + this.name + " palkka on suurempi.");
            else
                Console.WriteLine(this.name + ", " + this.salary + ", " + employees.name + ", " + employees.salary + ", Henkilön " + employees.name + " palkka on suurempi.");
        }

        public Employee(string v1, string v2, string v3, int v4)
        {
            this.name = v1;
            this.id = v2;
            this.position = v3;
            this.salary = v4;
        }

        public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.name +", " + this.id + ", " + this.position + ", " +this.salary);
        }

        public override string? ToString()
        {
            return this.name + ", " + this.id + ", " + this.position +", " + this.salary;
        }
    }
}
