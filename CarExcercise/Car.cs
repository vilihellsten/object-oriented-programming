using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarExcercise
{
    internal class Car
    {
        string merkki;
        double nopeus;

        public Car()
        {
            
        }

        public void AskData()
        {
            Console.WriteLine("Anna auton merkki");
            this.merkki = Console.ReadLine();
            Console.WriteLine("Anna auton nopeus");
            this.nopeus = Convert.ToInt32(Console.ReadLine());
        }

        public void ShowCarInfo()
        {
            Console.WriteLine(this.merkki +" " + this.nopeus);
        }

        public void Accelerate(int nopeus)
        {
            if (nopeus > this.nopeus)
                this.nopeus = nopeus;
            else
                this.nopeus = this.nopeus;

        }

        public void Brake()
        {
            this.nopeus = this.nopeus * 0.9;
        }
    }
}
