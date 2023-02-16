using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesExercise
{
    internal class Book : IEquatable<Book>
    {
        public string title;
        public string author;
        public double price;

        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        public bool Equals(Book? other)
        {
            return this.title.Equals(other.title);
        }

        public override string? ToString()
        {
            return $"{this.author}: {this.title}, {this.price} €";
        }
    }
}
