using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linguist.Model;

namespace Linguist.Repository.Repositories
{
    public class ArticleRepository : RepositoryBase<LinguistContext> ,IArticleRepository
    {
        public Article GetArticleDetail(Guid articleId)
        {
            var dbArticle = DataContext.Articles
                                            .Include("Sentences")
                                            .Include("Sentences.Words").SingleOrDefault(p => p.Id == articleId);

            if (dbArticle != null)
            {
                dbArticle.Sentences = dbArticle.Sentences.OrderBy(p => p.Order).ToList();

                foreach (var sentence in dbArticle.Sentences)
                {
                    sentence.Words = sentence.Words.OrderBy(p => p.Order).ToList();
                }
            }
            return dbArticle;            
        }

        public Article GetArticle(Guid articleId)
        {
            var article = Get<Article>(m => m.Id == articleId);
            return article;
        }

        public IList<Article> GetAllArticles()
        {
            var articles = GetList<Article>();
            return articles.ToList();
        }
    }
}
