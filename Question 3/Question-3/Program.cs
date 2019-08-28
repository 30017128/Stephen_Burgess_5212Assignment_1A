using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Book p1 = new Book();
            Console.Write("*** ENTER NEW BOOK DETAILS BELOW ***\n\n");

            Console.Write("Enter the book title: ");
            p1.Title = Console.ReadLine();
            Console.Write($"Enter the book author: ");
            p1.Author = Console.ReadLine();
            Console.Write($"Enter the book publisher: ");
            p1.Publisher = Console.ReadLine();



            Console.WriteLine($"\n******************************************" +
                $"\nThe Following new book has been processed:\nBook Title: " +
                $"{p1.Title}\nAuthor: {p1.Author}\nPublisher: {p1.Publisher}");
            Console.ReadLine();
        }

        class Book

        {
            private string title;
            private string author;
            private string publisher;

            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }

            public Book()
            { }
            public Book(string title, string author, string publisher)
            {
                Title = title;
                Author = author;
                Publisher = publisher;

            }





        }
    }
}
