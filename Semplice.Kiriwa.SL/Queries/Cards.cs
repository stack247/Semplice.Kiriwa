using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Queries
{
    public class CardById : Scalar<Card>
    {
        public CardById(int id)
        {
            ContextQuery = c => c.AsQueryable<Card>().FirstOrDefault(x => x.CardId == id);
        }
    }

    // TODO: 12.14.2014 - Remove this, just for test
    public class Cards : Query<Card>
    {
        public Cards()
        {
            ContextQuery = c => c.AsQueryable<Card>();
        }
    }
}
