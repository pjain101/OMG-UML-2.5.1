using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using UML.CommonStructure;
using UML.Factory.CommonStructure;

namespace UML.Tests.CommonStructure
{
    [TestClass]
    public sealed class ElementTests
    {
        private readonly Element sut;

        public ElementTests()
        {
            sut = Substitute.For<ElementImpl>();
        }

        [TestMethod]
        [WorkItem(123)]
        public void Can_have_Comments()
        {
            // Arrange
            Comment comment = new CommentImpl();

            // Act
            sut.ownedComments = new[] { comment };

            // Assert
            sut.ownedComments
                .Should()
                .Contain(comment)
                .And
                .HaveCount(1);
        }
    }
}
