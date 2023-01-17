using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        string title; // public
        string address;
        string phone;
        double outcome;
        double expense;

        public Company()
        {
            this.title = string.Empty;
            this.address = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expense = 0;
        }

        public Company(string title, string address, string phone, double outcome, double expense)
        {
            this.title = title;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expense = expense;
        }

        public void setTitle(string value)
        {
            this.title = value;
        }

        public void PrintInfo()
        {
            Console.WriteLine("Yrityksen nimi : " + this.title); //Console.Writeline($"Yrityksen nimi : {this.title}"); Voi tehdä myös näin
        }

        public override string? ToString() // tämä toimii samalla tavalla kuin print info paitsi kaikki muuttuu stringiksi?
        {
            return this.title + ", " + this.address + ", " + this.phone + ", " + this.outcome + ", " + this.expense;
        }

        public void Result()
        {
            double prosentti = (((this.outcome - this.expense) / this.expense) * 100);
            Console.WriteLine(prosentti + " % tuottoa");
            if (prosentti < 100)
                Console.WriteLine("Kehnosti tuottoa");
            else
                if (prosentti < 200)
                Console.WriteLine("Välttävästi tuottoa");
            else
                if (prosentti < 300)
                Console.WriteLine("Tyydyttävästi tuottoa");
            else
                Console.WriteLine("Hyvin tuottoa");

        }

        public Company(Company other) // kopiointi
        {
            this.title = other.title;
            this.address = other.address;
            this.phone = other.phone;
            this.outcome = other.outcome;
            this.expense = other.expense;
        }


    }
}
