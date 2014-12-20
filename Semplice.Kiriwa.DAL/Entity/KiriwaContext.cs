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
            : base("name=Kiriwa.SqlServer")
        {
        }

        public DbSet<Card> Cards { get; set; }
        public DbSet<Stack> Stacks { get; set; }
    }
}
