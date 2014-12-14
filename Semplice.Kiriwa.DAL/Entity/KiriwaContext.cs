using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.DAL.Entity
{
    public class KiriwaContext : DbContext
    {
        public KiriwaContext()
            : base("Kiriwa.SqlServer")
        {
        }

        public DbSet<Author> Authors { get; set; }
    }
}
