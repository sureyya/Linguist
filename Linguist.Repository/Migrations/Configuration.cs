using Linguist.Repository.Core;
using System.Data.Entity.Migrations;
using Linguist.Model;
using System.Collections.Generic;

namespace Linguist.Repository.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<LinguistContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LinguistContext context)
        {
            var article = new Article { Title = "Hodně foukalo. I přesto Tsegay zaběhl pátý nejlepší čas historie" };

            var translation = new Translation
            {
                Content = "<ol class=\"round\"><li class=\"one\">" +
                         "<h5>Configure ASP.NET Membership</h5>" +
                         "ASP.NET membership gives you a built-in way to create, store, and " +
                         "validate user credentials (authentication). By default, membership works with a local instance of SQL Server, " +
                         "but you can configure it to use another database.</li>" +
                         "<li class=\"two\">" +
                         "<h5>Add NuGet packages and jump start your coding</h5>" +
                         "NuGet makes it easy to install and update free libraries and tools in Visual Studio. In <em>Solution Explorer</em>, " +
                         "right-click the <em>References</em> node, select <em>Manage NuGet Packages</em>, and then pick from the extensive " +
                         "list of packages.</li>" +
                         "</ol>"
            };

            var sentence = new Sentence();
            sentence.Words = new List<Word>();
            sentence.Order = 1;
            sentence.Words.Add(new Word() { Order = 0, Text = "Pražský" });
            sentence.Words.Add(new Word() { Order = 1, Text = "půlmaraton" });
            sentence.Words.Add(new Word() { Order = 2, Text = "vyhrál" });
            sentence.Words.Add(new Word() { Order = 3, Text = "etiopský" });
            sentence.Words.Add(new Word() { Order = 4, Text = "běžec" });
            sentence.Words.Add(new Word() { Order = 5, Text = "Atsedu" });
            sentence.Words.Add(new Word() { Order = 6, Text = "Tsegay" });
            sentence.Words.Add(new Word() { Order = 7, Text = "v" });
            sentence.Words.Add(new Word() { Order = 8, Text = "nejlepším" });
            sentence.Words.Add(new Word() { Order = 9, Text = "letošním" });
            sentence.Words.Add(new Word() { Order = 10, Text = "čase" });
            sentence.Words.Add(new Word() { Order = 11, Text = "a" });
            sentence.Words.Add(new Word() { Order = 12, Text = "pátém" });
            sentence.Words.Add(new Word() { Order = 13, Text = "výkonu" });
            sentence.Words.Add(new Word() { Order = 14, Text = "historie" });
            sentence.Words.Add(new Word() { Order = 15, Text = "58:47" });
            sentence.Words.Add(new Word() { Order = 16, Text = "minuty." });
            

            var sentence2 = new Sentence();
            sentence2.Order = 2;
            sentence2.Words = new List<Word>();
            sentence2.Words.Add(new Word() { Order = 1, Text = "Útok" });
            sentence2.Words.Add(new Word() { Order = 2, Text = "na" });
            sentence2.Words.Add(new Word() { Order = 3, Text = "světový" });
            sentence2.Words.Add(new Word() { Order = 4, Text = "rekord" });
            sentence2.Words.Add(new Word() { Order = 5, Text = "Zersenaye" });
            sentence2.Words.Add(new Word() { Order = 6, Text = "Tadeseho" });
            sentence2.Words.Add(new Word() { Order = 7, Text = "z" });
            sentence2.Words.Add(new Word() { Order = 8, Text = "Eritrey," });
            sentence2.Words.Add(new Word() { Order = 9, Text = "který" });
            sentence2.Words.Add(new Word() { Order = 10, Text = "má" });
            sentence2.Words.Add(new Word() { Order = 11, Text = "hodnotu" });
            sentence2.Words.Add(new Word() { Order = 12, Text = "58:23," });
            sentence2.Words.Add(new Word() { Order = 13, Text = "dnes" });
            sentence2.Words.Add(new Word() { Order = 14, Text = "zhatil" });
            sentence2.Words.Add(new Word() { Order = 15, Text = "vítr." });
            


            sentence.Words[0].Translations.Add(translation);

            article.Sentences = new List<Sentence> { sentence, sentence2 };

            context.Articles.AddOrUpdate(article);
        }
    }
}
