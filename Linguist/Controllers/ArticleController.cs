using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linguist.Repository.Repositories;

namespace Linguist.Controllers
{
    public class ArticleController : Controller
    {
        
        private readonly IArticleRepository articleRepository;
        private readonly ITranslationRepository translationRepository;

        public ArticleController(IArticleRepository articleRepository,
                                            ITranslationRepository translationRepository)
        {
            this.articleRepository = articleRepository;
            this.translationRepository = translationRepository;
        }
        
        public ActionResult Index()
        {
            return View(articleRepository.GetAllArticles());
        }


        public ActionResult Detail(Guid id)
        {            
            return View(articleRepository.GetArticle(id));
        }

    }
}
