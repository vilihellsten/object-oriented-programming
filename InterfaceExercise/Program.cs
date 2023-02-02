using InterfaceExercise;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Product p1 = new Product("Puhelin", 150, 3);


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
    }
}