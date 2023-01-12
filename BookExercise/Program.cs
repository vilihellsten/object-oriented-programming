using BookExercise;

internal class Program
{
    private static void Main(string[] args)
    {
        Book myFirstBook = new Book();
        Book mySecondBook = new Book("Peppi Pitkätossu", 77);
        Book myBook = new Book("Muumit", "Tove Jansson", "01234", 23.50);
        myBook.PrintData();
        mySecondBook.CompareBooks(myBook);
        
    }
}