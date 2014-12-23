using System.Data.Entity;
using System.Linq;
using Highway.Data;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.DAL.Queries
{
    public class CardById : Scalar<Card>
    {
        public CardById(int id, bool includeChildren = false)
        {
            ContextQuery = c =>
            {
                var _result = c.AsQueryable<Card>();

                if (includeChildren)
                    _result = _result.Include(x => x.Stack);

                return _result.FirstOrDefault(x => x.CardId == id);
            };
        }
    }
}
