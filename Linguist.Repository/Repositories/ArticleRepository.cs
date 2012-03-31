using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linguist.Model;
using Linguist.Logger;
using Linguist.Repository.Core;


namespace Linguist.Repository.Repositories
{
    public class ArticleRepository : RepositoryBase<LinguistContext> ,IArticleRepository
    {
        private readonly ILogger _logger;

        public ArticleRepository(ILogger logger)
        {
            _logger = logger;
        }

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
            _logger.LogDebug(DataContext.Database.Connection.ConnectionString);
            var articles = GetList<Article>();
            return articles.ToList();
        }
    }
}
