using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    // Base class representing a general library item.
    // SRP: This class only defines the shared properties (Title, Author) and the Accept method.
    // OCP: Open for extension by adding new LibraryItem types (e.g., Ebooks) without modifying this class.
    public abstract class LibraryItem
    {
        // Common properties for all library items.
        public string Title { get; set; }
        public string Author { get; set; }

        // Constructor to initialize common properties.
        protected LibraryItem(string title, string author)
        {
            Title = title;
            Author = author;
        }

        // Abstract method to allow visitors to perform operations.
        // OCP: New visitor operations can be added without modifying this class.
        public abstract void Accept(ILibraryVisitor visitor);
    }
}

