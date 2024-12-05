using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace LibraryManagementSystem
{
    // Visitor class that calculates fines for library items.
    // SRP: This class handles only the logic for calculating fines.
    // DIP: Depends on ILibraryVisitor abstraction, not directly on LibraryItems.
    public class FineCalculator : ILibraryVisitor
    {
        // Fine rate per day for borrowed items.
        private const decimal FineRatePerDay = 0.50m;

        // Calculates fine for books based on borrowed days.
        public void VisitBook(Book book)
        {
            decimal fine = book.BorrowedDays * FineRatePerDay;
            Console.WriteLine($"Book: {book.Title}, Fine: {fine:C}");
        }

        // No fine applicable for magazines in this system.
        public void VisitMagazine(Magazine magazine)
        {
            Console.WriteLine($"Magazine: {magazine.Title}, No fine applicable.");
        }

        // Flat fine of $5.00 for research papers.
        public void VisitResearchPaper(ResearchPaper researchPaper)
        {
            Console.WriteLine($"Research Paper: {researchPaper.Title}, Fine: $5.00");
        }
    }
}

