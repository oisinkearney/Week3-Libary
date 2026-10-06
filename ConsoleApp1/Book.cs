using System;
using System.Collections.Generic;
using System.Text;

namespace Libary
{
     class Book
    {
        private string Title;
        private string Author;
        private string ISBN;
        public string title
        {
            get { return Title; }  // get method
            set { Title = value; }
        } // set method
        public string AUTHOR
        {
            get { return Author; }
            set
            { // Checks if any character in the incoming string is a digit
                if (!value.Any(char.IsDigit))
                {
                    Author = value;
                }
                else
                {
                    Console.WriteLine("Error: Author name cannot contain numbers.");
                }
            }
        }
        public string isbn
        {
            get { return ISBN; }
            set
            {  // Checks that the incoming string is not blank
                if (value != "")
                {
                    ISBN = value;
                }
                else
                {
                    Console.WriteLine("Error: ISBN cannot be blank.");
                }
            }
        }

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
