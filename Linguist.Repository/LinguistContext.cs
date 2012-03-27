using System.Data.Entity;
using Linguist.Model;

namespace Linguist.Repository
{
    public class LinguistContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public DbSet<Sentence> Sentences { get; set; }

        public DbSet<Word> Words { get; set; }

        public DbSet<Translation> Translations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArticleConfiguration());
            modelBuilder.Configurations.Add(new SentenceConfiguration());
            modelBuilder.Configurations.Add(new WordConfiguration());
            modelBuilder.Configurations.Add(new TranslationConfiguration());      
        }
        
    }
}