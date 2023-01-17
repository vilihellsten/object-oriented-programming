using CompanyExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("This is a Company Exercise!");

        Company finnair = new Company();
        finnair.setTitle("Finnair Oyj");  // finnair.title = "Finnair Oyj"; // jos muuttuja public company luokassa voi tehdä suoraan näin.
        finnair.PrintInfo();
        
        // Tiedot lufthansa yrityksestä
        Company lufthansa = new Company("Lufthansa Group", "Mannerheimintie 50 Helsinki", "0504012345", 225, 75);

        Console.WriteLine("\nTämä tulostaa ensin vain Luftansan titlen ja sen jälkeen kaikki Lufthansan tiedot");
        lufthansa.PrintInfo();
        Console.WriteLine(lufthansa.ToString());

        Console.WriteLine("\nTämä tulostaa Lufthansan tuottoprosentin ja tuloksen tuottoprosentin perusteella");
        lufthansa.Result();

        Console.WriteLine("\nTämä kopioi kaikki Lufthansan tiedot Norwegianille");
        Company norwegian = new Company(lufthansa);
        Console.WriteLine(norwegian.ToString());

    }
}