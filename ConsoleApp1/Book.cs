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
    
    public void DisplayBookInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
