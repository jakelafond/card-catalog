using System;
using System.Collections.Generic;

namespace card_catalog
{

    public class Book
    {
        public string BookName { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime OverDueDate { get; set; }
        public bool IsCheckedOut { get; set; }
        public string MemberWhoCheckedOut { get; set; }

        public Book() { }

    }
}