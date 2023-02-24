using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookExercise
{
    internal class Book
    {
        string title;
        string author;
        string id;
        double price;

        public Book()
        {
            this.title = string.Empty;
            this.author = string.Empty;
            this.id = "ERROR";
            this.price = 0;
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.SetID(id);
            this.price = price;
        }

        public void PrintData()
        {
            Console.WriteLine("Title is {0}, Author is {1}, ID {2}, Price is {3} e",
            this.title, this.author, this.id, this.price);
        }

        public void CompareBooks(Book other)
        {
            if (this.price > other.price)
            {
                Console.WriteLine(this.title + " (" + this.price + "e) kirja on kalliimpi kuin " + other.title + " (" + other.price + "e) kirja");
            }
            else
            {
                Console.WriteLine(other.title + " (" + other.price + "e) kirja on kalliimpi kuin " + this.title + " (" + this.price + "e) kirja");
            }
        }

        public void SetID(string id)
        {
            if (id.Length == 5)
            {
                this.id = id;
            }
            else
            {
                this.id = "was not valid";
            }
            
        }
    }
}
