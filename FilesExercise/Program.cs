using System.Text.Json.Serialization;
using FilesExercise;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Tässä try/catch käyttö");

        FileManager fm1 = new FileManager();
        Console.WriteLine(fm1.ReadWords());

        Console.WriteLine("Tässä tulostuu kirjat");

        const string filePath = @"C:\Users\Vili\source\repos\Olio-ohjelmointi\object-oriented-programming\FilesExercise\myBooks.json";
        FileManager fm2 = new FileManager(filePath);
        Console.WriteLine(fm2.ReadWords());

        List<Book> books = JsonConvert.DeserializeObject<List<Book>>(fm2.ReadWords());

        Console.WriteLine("\nLuetaan myBooks.json ja deserialisoidaan listaksi\n");
        foreach (Book b in books)
        {

            Console.WriteLine(b);
        }

        books.Add(new Book("Matikka", "Kalle K", 25.95));
        books.Add(new Book("Englanti", "Simo K", 26.95));
        books.Add(new Book("Ruotsi", "Sari M", 24.95));
        books.Add(new Book("Saksa", "Mari S", 23.95));
        books.Add(new Book("Espanja", "Mirjo S", 22.95));
        books.Add(new Book("Norja", "Lotta A", 21.95));

        //Kirjojejn lisäys myBooks.json tiedostoon
        File.WriteAllText(filePath,JsonConvert.SerializeObject(books));
    }

}