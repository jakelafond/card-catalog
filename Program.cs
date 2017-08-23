using System;
using System.Collections.Generic;

namespace card_catalog
{
    class Program
    {
        static void Main(string[] args)
        {
            var lib = new Library();
            var dictionary = new Book
            {
                BookName = "Dictionary",
                Author = "The world",
                Genre = "Smart",
                PublishedDate = new DateTime(1980, 8, 10),
                IsCheckedOut = false
            };
            var stormOfSwords = new Book
            {
                BookName = "Storm of Swords",
                Author = "George R.R. Martin",
                Genre = "Fantasy",
                PublishedDate = new DateTime(2005, 3, 12),
                IsCheckedOut = true
            };

            var jake = new Member
            {
                MemberName = "Jake",
                MemberAddress = "Somewhere lane, somewhere city, FL",
                MemberPhoneNumber = "1308130"
            };
            lib.Catalog.Add(dictionary);
            lib.Catalog.Add(stormOfSwords);


            var nameSearchList = lib.searchForBookByName("Dictionary");
            foreach (var item in nameSearchList)
            {
                Console.WriteLine($"{item.BookName} was found.");
            }

            Console.WriteLine($"Here is the book: {lib.searchForBookByAuthor("The world").BookName}");

            Console.WriteLine($"Here is the book: {lib.searchForBookByGenre("Fantasy").BookName}");

            var overDueSearchList = lib.searchForOverDueBooks();
            foreach (var item in overDueSearchList)
            {
                Console.WriteLine($"{item.BookName} is overdue!");
            }

            lib.CheckOutBook("Dictionary", "jake");
            lib.CheckOutBook("Storm of Swords", "jake");
            lib.CheckInBook("Storm of Swords", "jake");
        }
    }
}
