using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Library
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine($"Add Book ({book.Title}) , Author ({book.Author}) , FirstRelease ({book.FirstReleaseDate})");
        }
        public void SearchBook(string title)
        {
            bool Found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                    Found = true;
            }
            if (Found == true)
                Console.WriteLine($"Yes the {title} it is available ");
            else
                Console.WriteLine($"No The {title} Not Found");
        }
        public void ReturnBook(string title)
        {
            bool Found = false;
            for (int i = 0; i < books.Count; i++)
            {
                if (books[i].Title == title)
                    Found = true;
            }
            if (Found == false)
                Console.WriteLine($"Thanks for returning the {title}");
            else
                Console.WriteLine($"The {title} is already there, will you return it?");
        }
    }
}
