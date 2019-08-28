using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book p1 = new Book();
            Console.Write("*** ENTER NEW BOOK DETAILS BELOW ***\n\n");

            Console.Write("Enter the book title: ");
            p1.SetTitle(Console.ReadLine());
            Console.Write($"Enter the book author: ");
            p1.SetAuthor(Console.ReadLine());
            Console.Write($"Enter the book publisher: ");
            p1.SetPublisher(Console.ReadLine());


            Console.WriteLine($"\n******************************************\nThe Following new book has been processed:\nBook Title: {p1.GetTitle()}\nAuthor: {p1.GetAuthor()}\nPublisher: {p1.GetPublisher()}");
            Console.ReadLine();
        }

        class Book

        {
            private string title;
            private string author;
            private string publisher;

            public void SetTitle(string _title)
            {
                title = _title;
            }
            public string GetTitle()
            {
                return title;
            }
            public void SetAuthor(string _author)
            {
                author = _author;
            }
            public string GetAuthor()
            {
                return author;
            }
            public void SetPublisher(string _publisher)
            {
                publisher = _publisher;
            }
            public string GetPublisher()
            {
                return publisher;
            }









        }
    }
}
