using System.Data.Entity;
using System.Linq;
using Highway.Data;
using Semplice.Kiriwa.Domains;

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
                    _result.Include(x => x.Cards);

                return _result.FirstOrDefault(x => x.StackId == id);
            };
        }
    }

    public class Stacks : Query<Stack>
    {
        public Stacks()
        {
            ContextQuery = c => c.AsQueryable<Stack>();
        }
    }
}
