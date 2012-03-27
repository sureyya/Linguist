using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Linguist.DTOs;
using Linguist.Repository.Repositories;


namespace Linguist.Controllers
{
    public class HomeController : Controller
    {
        private readonly IArticleRepository articleRepository;
        private readonly ITranslationRepository translationRepository;

        public HomeController(IArticleRepository articleRepository , ITranslationRepository translationRepository )
        {
            this.articleRepository = articleRepository;
            this.translationRepository = translationRepository;
        }


        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";         
            return View();   
        }

        

       

        public ActionResult About()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }



        public ActionResult Contact()
        {
            ViewBag.Message = "Your quintessential contact page.";

            return View();
        }
    }
}
