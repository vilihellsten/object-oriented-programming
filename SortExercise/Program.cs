using SortExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books= new List<Book>();
        books.Add(new Book("Matikka", "Ville K", "Kalaja", 25));
        books.Add(new Book("Englanti", "Kalle V", "Kujala", 35));
        books.Add(new Book("Saksa", "Kerttu K", "Vuotsi", 15));

        Console.WriteLine("Ennen Sort()-metodia");
        foreach(Book book in books)
        {
            book.SortPrintAll();
        }

        books.Sort();

        Console.WriteLine("\nSort()-metodin jälkeen hinnan perusteella...");
        foreach (Book book in books)
        {
            book.SortPrintAll();
        }


    }
}