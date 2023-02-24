using BookExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Book myFirstBook = new Book("Matikka","Kalle K", "01010", 23.95);
        Book mySecondBook = new Book("Peppi Pitkätossu", "Astrid Lindgren", "01234", 29.95);
        Book myThirdBook = new Book("Muumit", "Tove Jansson", "0123", 25.95);

        Console.WriteLine("Tulostaa kaikki kirjat ja niiden tiedot, kolmannen kirjan ID ei täytyä vaatimuksia ja tulostaa ID not valid\n");
        myFirstBook.PrintData();
        mySecondBook.PrintData();
        myThirdBook.PrintData();

        Console.WriteLine("\nTässä käytän SetId metodia korjatakseni ID:n kelpaavaksi");
        myThirdBook.SetID("56431");
        myThirdBook.PrintData();

        Console.WriteLine("\nTässä verrataan kahta kirjaa ja tulostetaan tiedot kumpi on kalliimpi");
        mySecondBook.CompareBooks(myThirdBook);
        
    }
}