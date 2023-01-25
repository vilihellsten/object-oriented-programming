using System.Runtime.CompilerServices;
using BookExercise2;

internal class Program
{
    private static void Main(string[] args)
    {
        /*Person person = new Person();
        person.Name = "Pekka";

        Console.WriteLine(person.Name);*/

        // Näiden kirjojen ISBN on käypä ja menevät mutkitta 
        Book book1 = new Book("Matikka", "Ville K", "Kalaja", 25,"978asdqwerty1");
        Book book2 = new Book("Englanti", "Kalle V", "Kujala", 35, "978asduiower2");

        // Tämä ISBN on väärä ja kysyy käyttäjää uudelleen kirjoittamaan ISBN numeron
        Book book3 = new Book("Saksa", "Kerttu K", "Vuotsi", 15, "968sdfjlkqwe3");

        Console.WriteLine("\nHakee kirjat ISBN numeron mukaan, ilmiottaa jos väärä ISBN");
        book1.GetBookDetails("978asdqwerty1");
        book2.GetBookDetails("978asduiower2");
        book2.GetBookDetails("9781111111111");

        Console.WriteLine("\nMuuttaa kirjojen teeman alekirjoiksi ja tulostus näyttää tämän");
        Book.ChangeTheme("Alekirjat");
        book1.GetBookDetails("978asdqwerty1");

        Console.WriteLine("\nKutsuu kirjan authoria ja tulostaa sen");
        Console.WriteLine("Kirjan author on " + book1.Author);
    }
}