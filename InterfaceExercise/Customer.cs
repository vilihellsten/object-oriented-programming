using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Customer : ICustomer
    {
        string name;
        double purchases;

        public Customer(string name, double purchases)
        {
            this.name = name;
            this.purchases = purchases;
        }
        public Customer GetCustomer(string name)
        {
            if (this.name == name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public void GetBonus()
        {
            if (this.purchases < 1000)
            {
                Console.WriteLine("Bonus 2% = " + this.purchases * 0.02 + "€, ostosten määrä " + this.purchases + "€");
            }
            else if (this.purchases < 2000)
            {
                Console.WriteLine("Bonus 3% = " + this.purchases * 0.03 + "€, ostosten määrä " + this.purchases + "€");
            }
            else
            {
                Console.WriteLine("Bonus 5% =: " + this.purchases * 0.05 + "€, ostosten määrä " + this.purchases + "€");
            }
        }
    }
}
