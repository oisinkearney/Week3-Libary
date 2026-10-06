using Libary;


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            Book book = new Book("C# for Beginners", "BillGates", "12345678");
      
            book.DisplayBookInfo();

            Book book1 = new Book("C# Methods and Classes", "Microsoft", "55667788");

            book1.DisplayBookInfo();
        }
    }
}