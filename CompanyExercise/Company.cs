using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyExercise
{
    internal class Company
    {
        string title;
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

        public void PrintTitle()
        {
            Console.WriteLine("Yrityksen nimi : " + this.title);
        }

        public override string? ToString()
        {
            return "Yrityksen nimi " + this.title + ", Osoite " + this.address + ", Puhelinnumero " + this.phone + ", Tulot " + this.outcome + ", Menot " + this.expense;
        }

        public void Result()
        {
            double prosentti = (((this.outcome - this.expense) / this.expense) * 100);
            if (prosentti < 100)
                Console.WriteLine(prosentti + " % tuotto = Kehnosti tuottoa");
            else
                if (prosentti < 200)
                Console.WriteLine(prosentti + " % tuotto = Välttävästi tuottoa");
            else
                if (prosentti < 300)
                Console.WriteLine(prosentti + " % tuotto = Tyydyttävästi tuottoa");
            else
                Console.WriteLine(prosentti + " % tuotto = Hyvin tuottoa");

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
