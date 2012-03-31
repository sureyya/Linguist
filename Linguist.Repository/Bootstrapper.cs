using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Linguist.Repository.Core;
using Linguist.Repository.Repositories;
using Microsoft.Practices.Unity;
using Linguist.Repository.Migrations;

namespace Linguist.Repository
{
    public class Bootstrapper
    {
        public static void Init(UnityContainer container)
        {
            //Database.SetInitializer(new LinguistDBInitializer());
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<LinguistContext, Configuration>());
            container.RegisterType<ITranslationRepository, TranslationRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IArticleRepository, ArticleRepository>(new HierarchicalLifetimeManager());     

            //EntityFrameworkProfilerBootstrapper.PreStart();
        }
    }
}
