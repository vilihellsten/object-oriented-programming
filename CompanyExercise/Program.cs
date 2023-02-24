using CompanyExercise;

internal class Program
{
    private static void Main(string[] args)
    {

        // Tiedot lufthansa yrityksestä
        Company finnair = new Company("Finnair Oyj", "Tietotie 9 Vantaa", "0504069878", 300, 75);
        Company lufthansa = new Company("Lufthansa Group", "Mannerheimintie 50 Helsinki", "0504012345", 225, 75);

        Console.WriteLine("\nTämä tulostaa ensin vain Luftansan titlen ja sen jälkeen kaikki Lufthansan tiedot");
        lufthansa.PrintTitle();
        Console.WriteLine(lufthansa.ToString());

        Console.WriteLine("\nTämä tulostaa ensin vain Finnairin titlen ja sen jälkeen kaikki Finnairin tiedot");
        finnair.PrintTitle();
        Console.WriteLine(finnair.ToString());

        Console.WriteLine("\nTämä tulostaa Lufthansan tuottoprosentin ja tuloksen tuottoprosentin perusteella");
        lufthansa.Result();

        Console.WriteLine("\nTämä tulostaa Finnairin tuottoprosentin ja tuloksen tuottoprosentin perusteella");
        finnair.Result();

        Console.WriteLine("\nTämä kopioi kaikki Lufthansan tiedot Norwegianille ja tulostaa Norwegianin tiedot");
        Company norwegian = new Company(lufthansa);
        Console.WriteLine(norwegian.ToString());

    }
}