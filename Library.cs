using System;
using System.Collections.Generic;
using System.Linq;

namespace card_catalog
{

    class Library 
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public List<Book> Catalog = new List<Book>();

        public IEnumerable<Book> searchForBookByName(string bookName)
        {
            var nameResult = Catalog.Where(name => name.BookName.ToLower().Contains(bookName.ToLower()));
            return nameResult;

        }
        public Book searchForBookByAuthor(string author)
        {
            var authorResult = Catalog.FirstOrDefault(a => a.Author == author);
            return authorResult;

        }
        public Book searchForBookByGenre(string genre)
        {
            var genreResult = Catalog.FirstOrDefault(a => a.Genre == genre);
            return genreResult;

        }
        public IEnumerable<Book> searchForOverDueBooks()
        {
            var overDueResult = Catalog.Where(b => b.OverDueDate <= DateTime.Now);
            return overDueResult;

        }
        public void CheckOutBook(string bookName, string memberName)
        {
            var checkedOutBook = Catalog.FirstOrDefault(n => n.BookName == bookName);
            if (checkedOutBook?.IsCheckedOut == true)
            {
                Console.WriteLine("You can't check this out, it is already checked out!");
            }
            else
            {
                checkedOutBook.IsCheckedOut = true;
                checkedOutBook.MemberWhoCheckedOut = memberName;
                Console.WriteLine("Book successfully checked out!");
            }
        }
        public void CheckInBook(string bookName, string memberName)
        {
            var checkedOutBook = Catalog.FirstOrDefault(n => n.BookName == bookName);
            if (checkedOutBook?.IsCheckedOut == false)
            {
               Console.WriteLine($"You can't check this in, it is already checked in.");
            }
            else
            {
                checkedOutBook.IsCheckedOut = false;
                Console.WriteLine("Book successfully checked in!");
            }
        }
    }
}