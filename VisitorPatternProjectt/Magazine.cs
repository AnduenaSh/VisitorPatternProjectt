using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    // Represents a magazine in the library.
    // SRP: This class focuses only on properties and behavior specific to magazines.
    // LSP: Can replace the base class LibraryItem without breaking functionality.
    public class Magazine : LibraryItem
    {
        // Specific property for magazines: Issue number.
        public int IssueNumber { get; set; }

        // Constructor to initialize Title, Author, and IssueNumber.
        public Magazine(string title, string author, int issueNumber)
            : base(title, author)
        {
            IssueNumber = issueNumber;
        }

        // Accept method for visitors.
        public override void Accept(ILibraryVisitor visitor)
        {
            visitor.VisitMagazine(this); // Passes itself to the visitor.
        }
    }
}
