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
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LinguistContext context)
        {
            var article = new Article { Title = "First Test Article" };

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
            sentence.Words.Add(new Word() { Order = 0, Text = "V" });
            sentence.Words.Add(new Word() { Order = 1, Text = "Indickém" });
            sentence.Words.Add(new Word() { Order = 2, Text = "oceánu" });
            sentence.Words.Add(new Word() { Order = 3, Text = "asi" });
            sentence.Words.Add(new Word() { Order = 4, Text = "370" });
            sentence.Words.Add(new Word() { Order = 5, Text = "kilometru" });
            sentence.Words.Add(new Word() { Order = 6, Text = "od" });
            sentence.Words.Add(new Word() { Order = 7, Text = "Seychel" });
            sentence.Words.Add(new Word() { Order = 8, Text = "se" });
            sentence.Words.Add(new Word() { Order = 9, Text = "ocitla" });
            sentence.Words.Add(new Word() { Order = 10, Text = "v" });
            sentence.Words.Add(new Word() { Order = 11, Text = "potížích" });
            sentence.Words.Add(new Word() { Order = 12, Text = "lod" });
            sentence.Words.Add(new Word() { Order = 13, Text = "spolecnosti" });
            sentence.Words.Add(new Word() { Order = 14, Text = "Costa," });
            sentence.Words.Add(new Word() { Order = 15, Text = "jejíž" });
            sentence.Words.Add(new Word() { Order = 16, Text = "jedno" });
            sentence.Words.Add(new Word() { Order = 17, Text = "plavidlo" });
            sentence.Words.Add(new Word() { Order = 18, Text = "se" });
            sentence.Words.Add(new Word() { Order = 19, Text = "v" });
            sentence.Words.Add(new Word() { Order = 20, Text = "lednu" });
            sentence.Words.Add(new Word() { Order = 21, Text = "potopilo" });
            sentence.Words.Add(new Word() { Order = 22, Text = "u" });
            sentence.Words.Add(new Word() { Order = 23, Text = "italských" });
            sentence.Words.Add(new Word() { Order = 24, Text = "brehu," });
            sentence.Words.Add(new Word() { Order = 25, Text = "pricemž" });
            sentence.Words.Add(new Word() { Order = 26, Text = "zahynulo" });
            sentence.Words.Add(new Word() { Order = 27, Text = "32" });
            sentence.Words.Add(new Word() { Order = 28, Text = "lidí" });

            var sentence2 = new Sentence();
            sentence2.Order = 2;
            sentence2.Words = new List<Word>();
            sentence2.Words.Add(new Word() { Order = 1, Text = "Podle" });
            sentence2.Words.Add(new Word() { Order = 2, Text = "internetových" });
            sentence2.Words.Add(new Word() { Order = 3, Text = "stránek" });
            sentence2.Words.Add(new Word() { Order = 4, Text = "Lloyd's" });
            sentence2.Words.Add(new Word() { Order = 5, Text = "list" });
            sentence2.Words.Add(new Word() { Order = 6, Text = "zacalo" });
            sentence2.Words.Add(new Word() { Order = 7, Text = "v" });
            sentence2.Words.Add(new Word() { Order = 8, Text = "pondelí" });
            sentence2.Words.Add(new Word() { Order = 9, Text = "na" });
            sentence2.Words.Add(new Word() { Order = 10, Text = "lodi" });
            sentence2.Words.Add(new Word() { Order = 11, Text = "Costa" });
            sentence2.Words.Add(new Word() { Order = 12, Text = "Allegra" });
            sentence2.Words.Add(new Word() { Order = 13, Text = "horet" });
            sentence2.Words.Add(new Word() { Order = 14, Text = "a" });
            sentence2.Words.Add(new Word() { Order = 15, Text = "lod" });
            sentence2.Words.Add(new Word() { Order = 16, Text = "se" });
            sentence2.Words.Add(new Word() { Order = 17, Text = "ocitla" });
            sentence2.Words.Add(new Word() { Order = 18, Text = "bez" });
            sentence2.Words.Add(new Word() { Order = 19, Text = "proudu" });


            sentence.Words[0].Translations.Add(translation);

            article.Sentences = new List<Sentence> { sentence, sentence2 };

            context.Articles.AddOrUpdate(article);
        }
    }
}
