namespace Semplice.Kiriwa.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cards",
                c => new
                    {
                        CardId = c.Int(nullable: false, identity: true),
                        FrontTitle = c.String(),
                        FrontText = c.String(),
                        Created = c.DateTime(),
                        Updated = c.DateTime(),
                        Stack_StackId = c.Int(),
                    })
                .PrimaryKey(t => t.CardId)
                .ForeignKey("dbo.Stacks", t => t.Stack_StackId)
                .Index(t => t.Stack_StackId);
            
            CreateTable(
                "dbo.Stacks",
                c => new
                    {
                        StackId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Created = c.DateTime(),
                        Updated = c.DateTime(),
                    })
                .PrimaryKey(t => t.StackId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cards", "Stack_StackId", "dbo.Stacks");
            DropIndex("dbo.Cards", new[] { "Stack_StackId" });
            DropTable("dbo.Stacks");
            DropTable("dbo.Cards");
        }
    }
}
