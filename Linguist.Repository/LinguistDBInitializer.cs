using System.Collections.Generic;
using System.Data.Entity;
using Linguist.Model;

namespace Linguist.Repository
{
    public class LinguistDBInitializer : DropCreateDatabaseIfModelChanges<LinguistContext>
    {       
        protected override void Seed(LinguistContext context)
        {
            //context.Database.ExecuteSqlCommand("ALTER DATABASE Tocrates SET SINGLE_USER WITH ROLLBACK IMMEDIATE");

            

           base.Seed(context);
        } 
    }
}