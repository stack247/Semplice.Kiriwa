using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.WebApp.DataMappings
{
    public class CardMap : EntityTypeConfiguration<Card>
    {
        public CardMap()
        {
            this.ToTable("Cards");
            this.HasKey(x => x.CardId);
            this.Property(x => x.Text).HasColumnType("text");
            this.Property(x => x.Title).HasColumnType("text");
        }
    }
}