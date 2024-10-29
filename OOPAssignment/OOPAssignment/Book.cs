using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAssignment
{
    public class Book
    {
        public string Title{  get; set; }
        public string Author{  get; set; }
        public string ISBN{  get; set; }

        public Book(string title, string author, string isbn)
        {
            Title= title;
            Author=author;
            ISBN=isbn;
        }
        public override string ToString() 
        {
            return $"{Title} by {Author} ISBN: {ISBN}";
        }

        public class Library
        {
            private List<Book> books = new List<Book>();

            public void AddBook(Book book)
            {
                books.Add(book);
            }
            public void RemoveBook(string isbn)
            {
                books.RemoveAll(b => b.ISBN == isbn);
            }
            public void DisplayBooks() 
            {
                foreach (var item in books)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
