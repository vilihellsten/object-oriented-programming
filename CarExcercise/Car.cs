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
            this.merkki = string.Empty;
            this.nopeus = 0;
        }

        public void AskData()
        {
            bool cont = true;
            Console.WriteLine("Anna auton merkki");
            this.merkki = Console.ReadLine();
            while(cont)
            { 
                Console.WriteLine("Anna auton nopeus");
                try
                {
                    this.nopeus = Convert.ToDouble(Console.ReadLine());
                    cont = false;
                }
                catch
                {
                    Console.WriteLine("Nopeus väärässä muodossa");
                    cont = true;
                }
            }
        }

        public void ShowCarInfo()
        {
            Console.WriteLine("merkki " + this.merkki + ", nopeus " + Math.Round(this.nopeus,2));
        }

        public void Accelerate()
        {
            double lisäys = 0;
            Console.WriteLine("Paljon auton nopeutta lisätään");
            bool cont = true;
            while (cont)
            {
                try
                {
                    lisäys = Convert.ToDouble(Console.ReadLine());
                    cont = false;
                }
                catch
                {
                    Console.WriteLine("Nopeus väärässä muodossa");
                    cont = true;
                }
                
            }

            if (lisäys > 0)
            {
                this.nopeus += lisäys;

            }
            else
            {
                this.nopeus = this.nopeus;
                Console.WriteLine("Lisäys ei voi olla negatiivinen, auton nopeutta ei muutettu");
            }
            Console.WriteLine("Auton uudet tiedot");
            ShowCarInfo();
        }

        public void Brake()
        {
            Console.WriteLine("Toinen auto jarruttaa 10%, uudet tiedot ovat");
            this.nopeus = Math.Round(this.nopeus * 0.9,2);
            ShowCarInfo();
        }
    }
}
