using System.Data.Entity;
using System.Linq;
using Highway.Data;
using Semplice.Kiriwa.Domains;
using Semplice.Kiriwa.Domains.DTOs;

namespace Semplice.Kiriwa.DAL.Queries
{
    public class StackById : Scalar<Stack>
    {
        public StackById(int id, bool includeChildren = false)
        {
            ContextQuery = c =>
            {
                var _result = c.AsQueryable<Stack>();

                if (includeChildren)
                    _result = _result.Include(x => x.Cards);

                return _result.FirstOrDefault(x => x.StackId == id);
            };
        }
    }

    public class StacksWithCardCount : Query<StackWithCardCountDTO>
    {
        public StacksWithCardCount()
        {
            ContextQuery = c =>
            {
                var _stacks = (from s in c.AsQueryable<Stack>()
                    select new StackWithCardCountDTO
                    {
                        Stacks = s,
                        CardCount = s.Cards == null ? 0 : s.Cards.Count
                    });

                return _stacks;
            };
        }
    }
}
