using System.Dynamic;
using InterfaceExercise;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Product p1 = new Product("Puhelin", 150, 3);
        if(p1.GetProduct("Puhelin") != null)
        {
            Console.WriteLine("Puhelin löytyi: " + p1.ToString() + "\n");
        }

        List<Product> products = new List<Product>() {
        new Product("Laturi",150, 4),
        new Product("Kuulokkeet", 120, 7),
        new Product("Kaiutin", 90, 8),
        new Product("Kotelo", 15, 10)};

        Console.WriteLine("Käy tuotelistan läpi etsien kuulokkeita ja tulostaa tiedot");
        foreach (Product p in products)
        {
            if (p.GetProduct("Kuulokkeet") != null)
            {
                Console.WriteLine("Tuote löytyi listasta: " + p.ToString());
                Console.WriteLine("Tuotteiden varaston arvo: " + p.CalculateTotal() + "€");
            }
        }

        List<Customer> customers = new List<Customer>() {
            new Customer("Ville", 500),
            new Customer("Kalle", 1500),
            new Customer("Keijo", 2000) };

        Console.WriteLine("\nKäy asiakaslistan läpi etsien Kallea ja tulostaa tiedot");
        foreach (Customer c in customers)
        {
            if(c.GetCustomer("Kalle") != null)
            {
                Console.WriteLine("Asiakas löytyi listasta: " + c.ToString());
                c.GetBonus();
            }

        }
        Console.WriteLine("\n-- Store --");

        Store dna = new Store("DNA", 934000000);

        dna.AddProducts(new Product("Laturi", 75,8));
        dna.AddProducts(new Product("Tietokone", 650, 3));
        dna.AddProducts(new Product("Tabletti", 550, 4));

        Console.WriteLine("\nTulostaa kaikki kaupan tuotteet\n");
        dna.PrintProducts();

        dna.AddCustomers(new Customer("Ville", 500));
        dna.AddCustomers(new Customer("Kalle", 1500));
        dna.AddCustomers(new Customer("Keijo", 2000));

        Console.WriteLine("\nTulostaa kaikki kaupan asiakkaat\n");
        dna.PrintCustomers();

        Console.WriteLine("\nTulostaa kaikki kaupan tiedot");
        Console.WriteLine(dna.ToString());

    }

}