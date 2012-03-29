using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linguist.Model;
using log4net;

namespace Linguist.Repository.Repositories
{
    public class ArticleRepository : RepositoryBase<LinguistContext> ,IArticleRepository
    {
        private ILog logger;
        public Article GetArticleDetail(Guid articleId)
        {
            logger = LogManager.GetLogger(this.GetType());

            logger.Debug(DataContext.Database.Connection.ConnectionString);
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
            logger = LogManager.GetLogger(this.GetType());

            logger.Debug(DataContext.Database.Connection.ConnectionString);
            var articles = GetList<Article>();
            return articles.ToList();
        }
    }
}
