using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Store : IProducts, ICustomers
    {
        string name;
        double revenue;
        private List<Product> storeproducts = new List<Product>();
        private List<Customer> customers = new List<Customer>();

        public Store(string name, double revenue)
        {
            this.name = name;
            this.revenue = revenue;
        }

        public void AddCustomers(Customer customer)
        {
            this.customers.Add(customer);
        }

        public void AddProducts(Product product)
        {
            this.storeproducts.Add(product);
        }

        public void PrintCustomers()
        {
            Console.WriteLine("Asiakkaiden lukumäärä " + customers.Count);
            foreach (Customer customer in this.customers)
            {
                Console.WriteLine(customer.ToString());
                customer.GetBonus();
            }
        }

        public void PrintProducts()
        {
            Console.WriteLine("Tuotteiden lukumäärä " + storeproducts.Count);
            foreach (Product product in this.storeproducts)
            {
                Console.WriteLine(product.ToString());
                Console.WriteLine("Varaston arvo: " + product.CalculateTotal() + "€");
            }
        }

        public override string? ToString()
        {
            return "Kaupan nimi: " + this.name + ", liikevaihto: " + this.revenue + "€, asiakkaiden määrä: " + customers.Count + ", tuotteiden määrä: " + storeproducts.Count;
        }
    }
}
