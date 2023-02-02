using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Store : IProducts
    {
        string name;
        double revenue;
        private List<Product> storeproducts = new List<Product>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddProducts(Product product)
        {
            this.storeproducts.Add(product);
        }

        public void PrintProducts()
        {
            Console.WriteLine("Tuotteiden lukumääärä " + storeproducts.Count);
            foreach (Product product in this.storeproducts)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Varaston arvo: " + product.CalculateTotal());
            }
        }

        public override string? ToString()
        {
            return "Kaupan nimi: " + this.name + ", Liikevaihto: " + this.revenue + "€";
        }
    }
}
