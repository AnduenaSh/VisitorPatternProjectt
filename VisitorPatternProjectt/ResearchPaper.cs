using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    // Represents a research paper in the library.
    // SRP: Focuses on properties and behaviors related to research papers.
    // LSP: Can substitute LibraryItem in any context without issues.
    public class ResearchPaper : LibraryItem
    {
        // Specific property for research papers: Field of study.
        public string FieldOfStudy { get; set; }

        // Constructor to initialize Title, Author, and FieldOfStudy.
        public ResearchPaper(string title, string author, string fieldOfStudy)
            : base(title, author)
        {
            FieldOfStudy = fieldOfStudy;
        }

        // Accept method for visitors.
        public override void Accept(ILibraryVisitor visitor)
        {
            visitor.VisitResearchPaper(this); // Passes itself to the visitor.
        }
    }
}
