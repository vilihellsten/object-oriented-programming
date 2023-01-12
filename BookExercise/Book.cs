using System;
using System.Collections.Generic;
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
        int pageCount;
        string id;
        double price;

        public Book()
        {
            this.title = ""; //string.Empty; nämä on samat
            this.author = string.Empty;
            this.pageCount = 0;
            this.id = "00000";
            this.price = 19.90;

            this.WriteTitle(this.pageCount, this.title);
        }

        public Book(string title, int pageCount)
        {
            this.title = title;
            this.pageCount = pageCount;
            // if(this.title.Length != 5);
            this.author = string.Empty;
            this.id = "00000";
            this.price = 19.90;

            this.WriteTitle(this.pageCount, this.title);
        }

        public Book(string title, string author, string id, double price)
        {
            this.title = title;
            this.author = author;
            this.SetID(id);
            this.price = price;
            this.pageCount = 0;
            this.PrintData();
            //this.WriteAllDetails(this.title, this.author, this.id, this.price); TÄMÄKIN TOIMII

        }

        public void WriteTitle(int parameter1, string parameter2)
        {
            Console.WriteLine("Page count {0}, " +
            "title {1}",
            parameter1, parameter2);
        }


        public void WriteAllDetails(string parameter1, string parameter2, string parameter3, double parameter4)
        {
            Console.WriteLine("Title is {0}, " +
            "author is {1}, " + "id {2}," + " price is {3} e",
            parameter1, parameter2, parameter3, parameter4);
            // Ei TÄLLÄ HETKELLÄ KÄYTÖSSÄ, tämäkin toimii
        }

        public void PrintData()
        {
            Console.WriteLine("Title is {0}, author is {1}, id {2}, price is {3} e",
            this.title, this.author, this.id, this.price);
            // TÄLLÄ HETKELLÄ TÄMÄ KÄYTÖSSÄ
        }

        public void CompareBooks(Book other) // voi nimetä muuttujan miksi vaan?
        {
            Console.WriteLine(this.title);
            Console.WriteLine(other.title);

        }

        public void SetID(string id)
        {
            if (id.Length == 5)
            {
                this.id = id;
            }
            else
            {
                Console.WriteLine("Id not valid");
                this.id = "ERROR";
            }
            
        }
    }
}
