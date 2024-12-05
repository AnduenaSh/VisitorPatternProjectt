using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

namespace LibraryManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of library items.
            // LSP: All LibraryItems are substitutable (e.g., Book, Magazine, ResearchPaper).
            List<LibraryItem> libraryItems = new List<LibraryItem>
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 10),
                new Magazine("Time Magazine", "Editorial Team", 45),
                new ResearchPaper("Quantum Mechanics", "Dr. John Doe", "Physics")
            };

            // Create a visitor instance.
            // DIP: Program depends on ILibraryVisitor abstraction (FineCalculator).
            ILibraryVisitor fineCalculator = new FineCalculator();

            // Process each LibraryItem using the visitor.
            foreach (var item in libraryItems)
            {
                // OCP: Adding new visitors (e.g., ReportGenerator) doesn't require modifying this loop.
                item.Accept(fineCalculator);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey(); // Pause to view results.
        }
    }
}

