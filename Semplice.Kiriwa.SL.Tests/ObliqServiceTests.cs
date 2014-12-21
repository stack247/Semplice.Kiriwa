﻿using System;
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
    public class ObliqServiceTests
    {
        [TestCase]
        public void m_s_2b()
        {
            // Arrange
            // InMemoryDataContext() doesn't seem to work. AuthorService can't find the Author in the repository.
            //var _context = new InMemoryDataContext();
            var _context = new Mock<IDataContext>();
            _context.Setup(x => x.AsQueryable<Stack>())
                .Returns(new List<Stack>
                {
                    new Stack
                    {
                        StackId = 1,
                        Name = "Brant"
                    }
                }.AsQueryable());

            var _service = new ObliqService(new Repository(_context.Object));

            // Act
            var _result = _service.GetStack(1);

            // Assert
            Assert.IsNotNull(_result);
            Assert.AreEqual(1, _result.StackId);
            Assert.AreEqual("Brant", _result.Name);
        }
    }
}
