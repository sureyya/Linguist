namespace Linguist.Repository.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
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
        }
    }
}
