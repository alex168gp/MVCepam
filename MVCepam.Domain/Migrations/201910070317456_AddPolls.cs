namespace MVCepam.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPolls : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PollOptions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                        Votes = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Polls",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Question = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PollPollOptions",
                c => new
                    {
                        Poll_Id = c.Int(nullable: false),
                        PollOption_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Poll_Id, t.PollOption_Id })
                .ForeignKey("dbo.Polls", t => t.Poll_Id, cascadeDelete: true)
                .ForeignKey("dbo.PollOptions", t => t.PollOption_Id, cascadeDelete: true)
                .Index(t => t.Poll_Id)
                .Index(t => t.PollOption_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PollPollOptions", "PollOption_Id", "dbo.PollOptions");
            DropForeignKey("dbo.PollPollOptions", "Poll_Id", "dbo.Polls");
            DropIndex("dbo.PollPollOptions", new[] { "PollOption_Id" });
            DropIndex("dbo.PollPollOptions", new[] { "Poll_Id" });
            DropTable("dbo.PollPollOptions");
            DropTable("dbo.Polls");
            DropTable("dbo.PollOptions");
        }
    }
}
