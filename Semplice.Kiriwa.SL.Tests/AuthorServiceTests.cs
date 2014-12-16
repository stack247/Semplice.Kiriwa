using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Highway.Data.Contexts;
using Moq;
using NUnit.Framework;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Tests
{
    [TestFixture]
    public class AuthorServiceTests
    {
        [TestCase]
        public void m_s_2b()
        {
            // Arrange
            // InMemoryDataContext() doesn't seem to work. AuthorService can't find the Author in the repository.
            //var _context = new InMemoryDataContext();
            var _context = new Mock<IDataContext>();
            _context.Setup(x => x.AsQueryable<Author>())
                .Returns(new List<Author>
                {
                    new Author
                    {
                        AuthorId = 1,
                        FirstName = "Brant",
                        LastName = "Meail"
                    },
                    new Author
                    {
                        AuthorId = 2,
                        FirstName = "Lapat",
                        LastName = "Aheq"
                    }
                }.AsQueryable());

            var _service = new AuthorService(new Repository(_context.Object));

            // Act
            var _result = _service.GetAuthor(1);

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(1, _result.AuthorId);
            Assert.AreEqual("Brant", _result.FirstName);
            Assert.AreEqual("Meail", _result.LastName);
        }
    }
}
