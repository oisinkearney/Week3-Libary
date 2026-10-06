using System;
using System.Collections.Generic;
using System.Text;

namespace Libary
{
    public class Book
    {
        public string Title;
        public string Author;
        public string ISBN;

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor;
            this.ISBN = bookISBN;
        }
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}, Author: {Author}, ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
