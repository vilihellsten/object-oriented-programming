using System.Runtime.CompilerServices;
using Literature;
using BookExercise2;

internal class Program
{
    private static void Main(string[] args)
    {

        // Näiden kirjojen ISBN on käypä ja menevät mutkitta, myös englannin kielen kirjaan tulee alennus koska hinta yli 30e
        Book book1 = new Book("Matikka", "Ville K", "Kalaja", 25,"978asdqwerty1");
        Book book2 = new Book("Englanti", "Kalle V", "Kujala", 35, "978asduiower2");

        // Tämä ISBN ei kelpaa ja kysyy käyttäjää uudelleen kirjoittamaan ISBN numeron
        Book book3 = new Book("Saksa", "Kerttu K", "Vuotsi", 15, "968sdfjlkqwe3");

        Console.WriteLine("\nHakee kirjat ISBN numeron avulla, ilmoittaa jos ISBN ei täsmää kirjaan");
        book1.GetBookDetails("978asdqwerty1");
        book2.GetBookDetails("978asduiower2");
        book2.GetBookDetails("9781111111111");
        
        Console.WriteLine("\nMuuttaa kirjojen teeman alekirjoiksi ja tulostus näyttää teeman");
        Book.ChangeTheme("Alekirjat");
        book1.GetBookDetails("978asdqwerty1");

        Console.WriteLine("\nKutsuu kirjan price ominaisuutta ja tulostaa sen");
        Console.WriteLine("Kirjan hinta on " + book2.Price); // alkuperäinen hinta oli 35 mutta kirja sai 10% alennuksen
        Console.WriteLine("\nKutsuu kirjan authoria ominaisuutta ja tulostaa sen");
        Console.WriteLine("Kirjan author on " + book1.Author);

        //Lisätään 4 authoria
        Author author1 = new Author("Ville K", "1950", book1);
        Author author2 = new Author("Kalle V", "1960", book2);
        Author author3 = new Author("Kerttu K", "1970", book3);
        Author author4 = new Author("Keijo S", "1980");          // Tälle authorille ei lisätty kirjaa

        Console.WriteLine("\nTulostaa kirjailijan ja kirjan tiedot jos niitä on\n"); // Ei kaadu jos ei löydy kirjatietoja authorilta
        author1.PrintInformation();
        author2.PrintInformation();
        author3.PrintInformation();
        author4.PrintInformation();
    }

}