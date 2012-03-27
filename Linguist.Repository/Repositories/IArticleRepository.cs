using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Linguist.Model;

namespace Linguist.Repository.Repositories
{
    public interface IArticleRepository
    {
        //TODO: Change method parameter to Guid once you create parent page for articles.
        /// <summary>
        /// Return Article
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        Article GetArticleDetail(Guid articleId);


        
        /// <summary>
        /// Return Article
        /// </summary>
        /// <param name="articleId"></param>
        /// <returns></returns>
        Article GetArticle(Guid articleId);


        IList<Article> GetAllArticles();
    }
}
