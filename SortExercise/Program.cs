using SortExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Book> books= new List<Book>();
        Book book1 = new Book("Matikka", "Ville K", "Kalaja", 25);
        Book book2 = new Book("Englanti", "Kalle V", "Kujala", 35);
        Book book3 = new Book("Saksa", "Kerttu K", "Vuotsi", 15);
        book1.ToString();
    }
}