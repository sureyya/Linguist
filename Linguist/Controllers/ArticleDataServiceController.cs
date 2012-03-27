using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linguist.Repository.Repositories;

namespace Linguist.Controllers
{
    public class ArticleDataServiceController : Controller
    {
        private readonly IArticleRepository articleRepository;
        private readonly ITranslationRepository translationRepository;

        public ArticleDataServiceController(IArticleRepository articleRepository,
                                            ITranslationRepository translationRepository)
        {
            this.articleRepository = articleRepository;
            this.translationRepository = translationRepository;
        }


        [AllowAnonymous]
        public JsonResult GetArticleDetail(Guid id)
        {
            return Json(new { Article = articleRepository.GetArticleDetail(id) }, JsonRequestBehavior.AllowGet);
        }

        [AllowAnonymous]
        public JsonResult GetTranslation(Guid wordId)
        {
            return Json(new {Translation = translationRepository.GetFirstTranslation(wordId)},
                        JsonRequestBehavior.AllowGet);
        }

    }
}
