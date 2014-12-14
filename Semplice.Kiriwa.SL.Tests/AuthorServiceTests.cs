using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Highway.Data.Contexts;
using NUnit.Framework;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Tests
{
    [TestFixture]
    public class AuthorServiceTests
    {
        [TestCase]
        public void m_s_b()
        {
            // Arrange
            var _context = new InMemoryDataContext();
            _context.Add(new Author
            {
                AuthorId = 1,
                FirstName = "Brant",
                LastName = "Meail"
            });

            var _service = new AuthorService(new Repository(_context));

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
