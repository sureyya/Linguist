namespace Linguist.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TypeAndCaseAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("Translations", "Type", c => c.String());
            AddColumn("Translations", "Case", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("Translations", "Case");
            DropColumn("Translations", "Type");
        }
    }
}
