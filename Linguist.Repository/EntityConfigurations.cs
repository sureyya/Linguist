using System.ComponentModel.DataAnnotations;
using System.Data.Entity.ModelConfiguration;
using Linguist.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace Linguist.Repository
{

    public class EntityConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : EntityBase
    {
        public EntityConfiguration()
        {
            HasKey(p => p.Id);
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(p => p.DateCreated).HasColumnType("datetime");
        }
        
    }

    public class ArticleConfiguration : EntityConfiguration<Article>
    {
        public ArticleConfiguration()
        {            
            HasMany(p => p.Sentences);            
            
        }

    }

    public class SentenceConfiguration : EntityConfiguration<Sentence>
    {
        public SentenceConfiguration()
        {
            HasMany(p => p.Words);
        }
    }

    public class WordConfiguration : EntityConfiguration<Word>
    {
        public WordConfiguration()
        {
            HasMany(p => p.Translations);
        }
    }

    public class TranslationConfiguration : EntityConfiguration<Translation>
    {

    }
}