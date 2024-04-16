using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Model
{
    public class Library
    {
        Book[] books = new Book[0];
        public void AddBook(Book book)
        {
            Array.Resize(ref books, books.Length + 1);
            books[books.Length - 1] = book;
        }
        public Book this[int id]
        {
            get
            {
                foreach (var book in books)
                {
                    if (book.Id == id)
                    {
                        return book;
                    }
                }
                return null;
            }
        }
    }
}
