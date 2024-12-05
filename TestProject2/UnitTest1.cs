// Test1.cs
using LibraryManagementSystem;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace TestUnit2
{
    [TestClass]
    public class LibraryManagementSystemTests
    {
        [TestMethod]
        public void TestBookFineCalculation()
        {
            // Arrange
            var book = new Book("The Great Gatsby", "F. Scott Fitzgerald", 10);
            var fineCalculatorMock = new Mock<ILibraryVisitor>();
            fineCalculatorMock.Setup(x => x.VisitBook(book)).Verifiable();

            // Act
            book.Accept(fineCalculatorMock.Object);

            // Assert
            fineCalculatorMock.Verify(x => x.VisitBook(book), Times.Once, "The fine calculator should visit the book.");
        }

        [TestMethod]
        public void TestMagazineFineCalculation()
        {
            // Arrange
            var magazine = new Magazine("Time Magazine", "Editorial Team", 45);
            var fineCalculatorMock = new Mock<ILibraryVisitor>();
            fineCalculatorMock.Setup(x => x.VisitMagazine(magazine)).Verifiable();

            // Act
            magazine.Accept(fineCalculatorMock.Object);

            // Assert
            fineCalculatorMock.Verify(x => x.VisitMagazine(magazine), Times.Once, "The fine calculator should visit the magazine.");
        }

        [TestMethod]
        public void TestResearchPaperFineCalculation()
        {
            // Arrange
            var paper = new ResearchPaper("Quantum Mechanics", "Dr. John Doe", "Physics");
            var fineCalculatorMock = new Mock<ILibraryVisitor>();
            fineCalculatorMock.Setup(x => x.VisitResearchPaper(paper)).Verifiable();

            // Act
            paper.Accept(fineCalculatorMock.Object);

            // Assert
            fineCalculatorMock.Verify(x => x.VisitResearchPaper(paper), Times.Once, "The fine calculator should visit the research paper.");
        }

        [TestMethod]
        public void TestProgramWithVisitor()
        {
            // Arrange
            var libraryItems = new List<LibraryItem>
            {
                new Book("The Great Gatsby", "F. Scott Fitzgerald", 10),
                new Magazine("Time Magazine", "Editorial Team", 45),
                new ResearchPaper("Quantum Mechanics", "Dr. John Doe", "Physics")
            };

            var fineCalculatorMock = new Mock<ILibraryVisitor>();

            foreach (var item in libraryItems)
            {
                item.Accept(fineCalculatorMock.Object);
            }

            // Act & Assert
            fineCalculatorMock.Verify(x => x.VisitBook(It.IsAny<Book>()), Times.Once, "FineCalculator should visit the book.");
            fineCalculatorMock.Verify(x => x.VisitMagazine(It.IsAny<Magazine>()), Times.Once, "FineCalculator should visit the magazine.");
            fineCalculatorMock.Verify(x => x.VisitResearchPaper(It.IsAny<ResearchPaper>()), Times.Once, "FineCalculator should visit the research paper.");
        }

        [TestMethod]
        public void TestAnotherBookFineCalculation()
        {
            // Arrange
            var book = new Book("1984", "George Orwell", 15);
            var fineCalculatorMock = new Mock<ILibraryVisitor>();
            fineCalculatorMock.Setup(x => x.VisitBook(book)).Verifiable();

            // Act
            book.Accept(fineCalculatorMock.Object);

            // Assert
            fineCalculatorMock.Verify(x => x.VisitBook(book), Times.Once, "The fine calculator should visit this other book.");
        }
    }
}
