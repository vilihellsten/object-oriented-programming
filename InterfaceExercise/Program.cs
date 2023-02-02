using InterfaceExercise;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Product p1 = new Product("Puhelin", 150, 3);
        Console.WriteLine(p1.GetProduct("Puhelin"));

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p1.CalculateTotal());

        List<Product> products = new List<Product>() {
        new Product("Laturi",150, 4),
        new Product("Kuulokkeet", 120, 7),
        new Product("Kaiutin", 90, 8),
        new Product("Kotelo", 15, 10)};

        foreach (Product p in products)
        {
            Console.WriteLine(p.ToString());
        }
    }
}