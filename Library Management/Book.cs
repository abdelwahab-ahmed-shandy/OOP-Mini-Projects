using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management
{
    class Book
    {
        public Book(string title, string author, int firstReleaseDate, bool availability = true)
        {
            if (string.IsNullOrWhiteSpace(title))
                throw new ArgumentException("You Must Enter Title");
            if (string.IsNullOrWhiteSpace(author))
                throw new ArgumentException("You Must Enter Author");
            if (firstReleaseDate <= 0)
                throw new ArgumentException("You Must Enter First Release Date");

            Title = title;
            Author = author;
            FirstReleaseDate = firstReleaseDate;
            Availability = availability;
        }

        public string Title { get; private set; }
        public string Author { get; private set; }
        public int FirstReleaseDate { get; private set; }
        public bool Availability { get; private set; }
    }
}
