using System.Dynamic;
using InterfaceExercise;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Product p1 = new Product("Puhelin", 150, 3);
        p1.GetProduct("Puhelin");

        List<Product> products = new List<Product>() {
        new Product("Laturi",150, 4),
        new Product("Kuulokkeet", 120, 7),
        new Product("Kaiutin", 90, 8),
        new Product("Kotelo", 15, 10)};

        foreach (Product p in products)
        {
            if (p.GetProduct("Kuulokkeet") != null)
            {
                Console.WriteLine("Kuulokkeet löytyi");
                Console.WriteLine("Varaston arvo: " + p.CalculateTotal() + "€");
            }
            //Console.WriteLine(p.GetProduct("Kuulokkeet")); // voi käydä listaa läpi näin ja palauttaa kuulokkeiden tiedot tällä

        }

        List<Customer> customers = new List<Customer>() {
            new Customer("Ville", 500),
            new Customer("Kalle", 1500),
            new Customer("Keijo", 2000) 
        };

        foreach (Customer c in customers)
        {
            if(c.GetCustomer("Kalle") != null)
            {
                
                Console.WriteLine("Asiakas löytyi");
                c.GetBonus();
            }

        }
        Console.WriteLine("Store");

        Store dna = new Store("DNA", 934000000);
        dna.AddProducts(new Product("Laturi", 75,8)); //Kumpikin toimii
        dna.AddProducts(new Product("Tietokone", 650, 3));
        dna.AddProducts(new Product("Tabletti", 550, 4));
        
        dna.PrintProducts();

        Console.WriteLine(dna.ToString());
    }

}