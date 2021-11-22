using System;

namespace complab
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("Jeff Lucas", 'M', "jslucas@cba.ua.edu");
            Console.WriteLine(myAuthor.ToString());

            Book myBook = new Book("12243", "My Book, Your Book", myAuthor);
            Console.WriteLine(myBook.ToString());

            // Console.WriteLine(myBook.GetAuthor().ToString());

            Book yourbook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamie@mail.com"));
            yourbook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            System.Console.WriteLine(yourbook.ToString());
            // System.Console.WriteLine(yourbook.GetAuthor().ToString());
            
        }
    }
}
