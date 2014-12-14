using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Highway.Data;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.SL.Queries
{
    public class AuthorById : Scalar<Author>
    {
        public AuthorById(int id)
        {
            ContextQuery = c => c.AsQueryable<Author>().FirstOrDefault(x => x.AuthorId == id);
        }
    }

    // TODO: 12.14.2014 - Remove this, just for test
    public class Authors : Query<Author>
    {
        public Authors()
        {
            ContextQuery = c => c.AsQueryable<Author>();
        }
    }
}
