using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Author: {Author}";
        }
    }

    public class Library
    {
        private Book[] books;

        public Library(int size)
        {
            books = new Book[size];
        }

        // Indexer to access books by index
        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < books.Length)
                {
                    return books[index];
                }
                throw new IndexOutOfRangeException("Invalid index");
            }
            set
            {
                if (index >= 0 && index < books.Length)
                {
                    books[index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("Invalid index");
                }
            }
        }

        // Method to display all books in the library
        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                if (book != null)
                {
                    Console.WriteLine(book);
                }
                else
                {
                    Console.WriteLine("Empty slot");
                }
            }
        }
    }

}
