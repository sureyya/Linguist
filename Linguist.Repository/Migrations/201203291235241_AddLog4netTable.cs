namespace Linguist.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLog4netTable : DbMigration
    {
        public override void Up()
        {
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
            DropTable("Log4Net_Error");
        }
    }
}
