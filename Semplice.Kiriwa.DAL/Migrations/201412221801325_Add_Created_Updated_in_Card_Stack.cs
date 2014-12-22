namespace Semplice.Kiriwa.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Created_Updated_in_Card_Stack : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cards", "Updated", c => c.DateTime());
            AddColumn("dbo.Stacks", "Created", c => c.DateTime());
            AddColumn("dbo.Stacks", "Updated", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Stacks", "Updated");
            DropColumn("dbo.Stacks", "Created");
            DropColumn("dbo.Cards", "Updated");
        }
    }
}
