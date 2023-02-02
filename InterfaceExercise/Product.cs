using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Product:IProduct
    {
        string name;
        double price;
        int count;

        public Product(string name, double price, int count)
        {
            this.name = name;
            this.price = price;
            this.count = count;
        }

        public double CalculateTotal()
        {
            return this.price * this.count;
        }

        public Product GetProduct(string name)
        {
            if(this.name == name)
            {
                return this;
            }
            else
            {
                return null;
            }
        }

        public override string? ToString()
        {
            return this.name + ", " + this.price + "€, " + this.count + " kpl";
        }
    }
}
