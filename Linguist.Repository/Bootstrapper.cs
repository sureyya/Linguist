using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Linguist.Repository.App_Start;
using Linguist.Repository.Repositories;
using Microsoft.Practices.Unity;

namespace Linguist.Repository
{
    public class Bootstrapper
    {
        public static void Init(UnityContainer container)
        {
            Database.SetInitializer(new LinguistDBInitializer());
            container.RegisterType<ITranslationRepository, TranslationRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IArticleRepository, ArticleRepository>(new HierarchicalLifetimeManager());     

            EntityFrameworkProfilerBootstrapper.PreStart();
        }
    }
}
