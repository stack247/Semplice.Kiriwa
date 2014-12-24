using System.Linq;
using Highway.Data;
using NUnit.Framework;
using Semplice.Kiriwa.SL.Tests.TestCommon;

namespace Semplice.Kiriwa.SL.Tests
{
    [TestFixture]
    public class ObliqServiceTests
    {
        #region GetStack

        [TestCase]
        public void GetStack_PassValidId_ShouldReturnResultAndIncludeChildren()
        {
            // Arrange
            var _context = Helpers.GetMockIDataContext();
            var _service = new ObliqService(new Repository(_context.Object));

            // Act
            var _result = _service.GetStack(1);

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(1, _result.StackId);
            Assert.AreEqual("Unit Test Stack 1 Name", _result.Name);
            Assert.IsNotNull(_result.Cards);
            Assert.AreEqual(1, _result.Cards.Count);
        }

        [TestCase]
        public void GetStack_PassInvalidId_ShouldReturnNull()
        {
            // Arrange
            var _context = Helpers.GetMockIDataContext();
            var _service = new ObliqService(new Repository(_context.Object));

            // Act
            var _result = _service.GetStack(29129);

            // Assert
            Assert.IsNull(_result);
        }

        #endregion

        #region GetStacksWithCardCount

        [TestCase]
        public void GetStacksWithCardCount_PassNothing_ShouldReturnNull()
        {
            // Arrange
            var _context = Helpers.GetMockIDataContext();
            var _service = new ObliqService(new Repository(_context.Object));

            // Act
            var _result = _service.GetStacksWithCardCount();

            // Assert
            Assert.IsNotNull(_result);
            Assert.IsTrue(_result.Any());
            Assert.AreEqual(1, _result.FirstOrDefault().CardCount);
        }

        #endregion
    }
}
