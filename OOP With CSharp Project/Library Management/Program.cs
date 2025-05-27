/*
Library Management
Required:

Create a class named Book.
The class has the following properties: title, author, firstReleaseDate ,availability .

Create a class named Library.
Link it to books and also make it add ReturnBook, AddBook and SearchBook.

Have it add, search and return books.
 */
namespace Library_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            // Adding books to the library
            library.AddBook(new Book("Running Linux", "Matt Welsh", 1995));
            library.AddBook(new Book("Linux Kernel Development", "Robert Love", 2003));
            library.AddBook(new Book("Linux Bible", "Christopher Negus", 2001));
            Console.WriteLine();
            // Searching and borrowing books
            library.SearchBook("Running Linux");
            library.SearchBook("Linux Bible");
            library.SearchBook("Linux");
            Console.WriteLine();
            // Returning books
            library.ReturnBook("Linux Kernel Development");
            library.ReturnBook("Gatsby");
            library.ReturnBook("Harry Potter");
            Console.WriteLine();
        }
    }
}
