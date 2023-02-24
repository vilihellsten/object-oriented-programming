namespace Literature
{
    internal class Book
    {
        private string name;
        private string author;
        private string publisher;
        private double price;
        private string isbn;
        private static string theme;

        private const int MAX_LENGTH = 13;
        private const string PREFIX = "978";

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                if (value > 30)
                {
                    price = value * 0.9;
                }
                else
                {
                    price = value;
                }
            }
        }

        public string Isbn
        {
            get
            {
                return isbn;
            }

            set
            {
                bool cont = true;

                while (cont)
                if (value.Length == MAX_LENGTH && value.StartsWith(PREFIX))
                {
                    isbn = value;
                    cont = false;
                }
                else
                {
                    Console.WriteLine(value + " : Tämä ISBN ei kelpaa, syötä uusi, 13 merkkiä pitkä ja aloitettava numeroilla 978");
                    
                    value = Console.ReadLine();
                    cont = true;
                }
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
        }

        public string Name { get => name; set => name = value; }
        public string Publisher { get => publisher; set => publisher = value; }

        public static void ChangeTheme(string value)
        {
            theme = value;
        }

        public Book()
        {
            this.Name = string.Empty;
            this.author = string.Empty;
            this.Publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;

        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.Name = name;
            this.author = author;
            this.Publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public void GetBookDetails(string isbn)
        {
            if(this.Isbn == isbn)
            {
                Console.WriteLine("Kirjan nimi " + this.Name + ", Kirjailija " + this.Author + ", Publisher " + this.Publisher + ", Hinta " + this.Price.ToString("0.00") + ", ISBN: " + this.Isbn + ", Teema: " + theme);
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voida tulostaa, väärä ISBN");
            }
        }

        public override string? ToString()
        {
          
            return " Kirjan nimi " + this.Name + ", Publisher " + this.Publisher + "\nHinta " + this.Price + "e, ISBN numero " + this.Isbn + ", Kirjan teema on " + theme +"\n";

        }
    }
}
