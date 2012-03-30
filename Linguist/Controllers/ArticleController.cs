using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linguist.Repository.Repositories;
using log4net;

namespace Linguist.Controllers
{
    public class ArticleController : Controller
    {
        
        private readonly IArticleRepository articleRepository;
        private readonly ITranslationRepository translationRepository;

        private ILog logger;

        public ArticleController(IArticleRepository articleRepository,
                                            ITranslationRepository translationRepository)
        {
            this.articleRepository = articleRepository;
            this.translationRepository = translationRepository;
            
            //logger = LogManager.GetLogger(this.GetType());

        }
        
        public ActionResult Index()
        {
           // logger.Debug("Started Index Action");
           
           // logger.Info("Ended Index Action");
            return View(articleRepository.GetAllArticles());
        }


        public ActionResult Detail(Guid id)
        {            
            return View(articleRepository.GetArticle(id));
        }

    }
}
