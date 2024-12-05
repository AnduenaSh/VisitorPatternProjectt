using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    // Interface for visitors in the Visitor Pattern.
    // DIP: High-level modules (LibraryItems) depend on this abstraction, not specific visitors.
    public interface ILibraryVisitor
    {
        // Methods to handle different LibraryItem types.
        void VisitBook(Book book);
        void VisitMagazine(Magazine magazine);
        void VisitResearchPaper(ResearchPaper researchPaper);
    }
}
