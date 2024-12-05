using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    // Represents a book in the library.
    // SRP: This class is responsible only for properties and behaviors specific to books.
    // OCP: Can be extended with new behavior by adding new visitors, without modifying this class.
    // LSP: As a derived class, Book can substitute LibraryItem without breaking functionality.
    public class Book : LibraryItem
    {
        // Specific property for books: Number of days borrowed.
        public int BorrowedDays { get; set; }

        // Constructor to initialize Title, Author, and BorrowedDays.
        public Book(string title, string author, int borrowedDays)
            : base(title, author)
        {
            BorrowedDays = borrowedDays;
        }

        // Accept method for visitors.
        // OCP: Supports extending functionality via visitors.
        public override void Accept(ILibraryVisitor visitor)
        {
            visitor.VisitBook(this); // Passes itself to the visitor for processing.
        }
    }
}
