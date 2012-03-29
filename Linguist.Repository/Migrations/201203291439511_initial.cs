namespace Linguist.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "Articles",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        DateCreated = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "Sentences",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        DateCreated = c.DateTime(),
                        Article_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Articles", t => t.Article_Id)
                .Index(t => t.Article_Id);
            
            CreateTable(
                "Words",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Order = c.Int(nullable: false),
                        Text = c.String(),
                        DateCreated = c.DateTime(),
                        Sentence_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Sentences", t => t.Sentence_Id)
                .Index(t => t.Sentence_Id);
            
            CreateTable(
                "Translations",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        Content = c.String(),
                        DateCreated = c.DateTime(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        Word_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("Words", t => t.Word_Id)
                .Index(t => t.Word_Id);

            Sql(@"
                        SET ANSI_NULLS ON

                        SET QUOTED_IDENTIFIER ON

                        SET ANSI_PADDING ON
                       
                        CREATE TABLE [dbo].[Log4Net_Error](
	                        [Id] [int] IDENTITY(1,1) NOT NULL,
	                        [Date] [datetime] NOT NULL,
	                        [Thread] [varchar](255) NOT NULL,
	                        [Level] [varchar](50) NOT NULL,
	                        [Logger] [varchar](255) NOT NULL,
	                        [Message] [varchar](4000) NOT NULL,
	                        [Exception] [varchar](2000) NULL
                        ) ON [PRIMARY]
                        SET ANSI_PADDING OFF
                    ");
            
        }
        
        public override void Down()
        {
            DropIndex("Translations", new[] { "Word_Id" });
            DropIndex("Words", new[] { "Sentence_Id" });
            DropIndex("Sentences", new[] { "Article_Id" });
            DropForeignKey("Translations", "Word_Id", "Words");
            DropForeignKey("Words", "Sentence_Id", "Sentences");
            DropForeignKey("Sentences", "Article_Id", "Articles");
            DropTable("Translations");
            DropTable("Words");
            DropTable("Sentences");
            DropTable("Articles");
            DropTable("Log4Net_Error");
        }
    }
}
