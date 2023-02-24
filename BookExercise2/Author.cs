using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Literature;

namespace BookExercise2
{
    internal class Author
    {
        public string name;
        public string birthday;
        private Book book;

        public Author(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }

        public Author(string name, string birthday, Book book)
        {
            this.name = name;
            this.birthday = birthday;
            this.Book = book;

        }

        internal Book Book
        {
            get => book;
            set
            {
                if (this.name == value.Author)
                {
                    book = value;
                }
            }
        }

        public void PrintInformation()
        {
            if (this.book != null)
            {
                Console.WriteLine("Kirjailijan nimi " + this.name + ", Syntymävuosi " + this.birthday + ", " + Book.ToString());
            }
            else
            {
                Console.WriteLine("Kirjailijan nimi " + this.name + ", Syntymävuosi " + this.birthday + ", Ei teoksia\n");
            }

        }
    }
}
