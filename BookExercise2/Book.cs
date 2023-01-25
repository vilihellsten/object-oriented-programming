using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise2
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
                    Console.WriteLine(value + " Tämä ISBN ei kelpaa, syötä uusi, 13 merkkiä pitkä ja aloitettava numeroilla 978");
                        
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

        public static void ChangeTheme(string value)
        {
            theme = value;
        }
        public Book()
        {
            this.name = string.Empty;
            this.author = string.Empty;
            this.publisher = string.Empty;
            this.Price = 0;
            this.Isbn = string.Empty;
            theme = string.Empty;
        }

        public Book(string name, string author, string publisher, double price, string isbn)
        {
            this.name = name;
            this.author = author;
            this.publisher = publisher;
            this.Price = price;
            this.Isbn = isbn;
        }

        public void GetBookDetails(string isbn)
        {
            if(this.Isbn == isbn)
            {
                Console.WriteLine(this.name + ", " + this.Author + ", " + this.publisher + ", " + this.Price.ToString("0.00") + ", " + this.Isbn + ", " + theme);
            }
            else
            {
                Console.WriteLine("Kirjan tietoja ei voida tulostaa");
            }
        }

        

    }
}
