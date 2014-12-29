using System.Collections.Generic;
using System.Linq;
using Highway.Data;
using Moq;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Tests.TestCommon
{
    internal class Helpers
    {
        public static Mock<IDataContext> GetMockIDataContext(List<Stack> stacks = null, List<Card> cards = null)
        {
            // Define default return object for Stacks
            if (stacks == null)
                stacks = new List<Stack>
                {
                    Models.StackWithOneCard,
                    Models.StackWithoutChildren
                };

            // Define default return object for Cards
            if (cards == null)
                cards = new List<Card>
                {
                    Models.CardWithoutChildren
                };

            // InMemoryDataContext() doesn't seem to work. AuthorService can't find the Author in the repository.
            //var _context = new InMemoryDataContext();
            var _context = new Mock<IDataContext>();

            // Add default return to Stacks
            _context.Setup(x => x.AsQueryable<Stack>())
                .Returns(stacks.AsQueryable());

            // Add default return to Cards
            _context.Setup(x => x.AsQueryable<Card>())
                .Returns(cards.AsQueryable());

            return _context;
        }
    }
}
