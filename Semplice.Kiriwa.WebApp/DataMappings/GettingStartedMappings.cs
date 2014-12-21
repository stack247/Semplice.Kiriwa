using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Highway.Data;
using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.WebApp.DataMappings
{
    public class GettingStartedMappings : IMappingConfiguration
    {
        public void ConfigureModelBuilder(DbModelBuilder modelBuilder)
        {
            //Approach 1
            modelBuilder.Entity<Card>(); //.HasKey(x => x.CardId).ToTable("Cards");
            modelBuilder.Entity<Stack>(); //.HasKey(x => x.StackId).ToTable("Stacks");
        }
    }
}