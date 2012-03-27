using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;

namespace Linguist
{
    public static class Bootstrapper
    {
        public static  void Init()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            Repository.Bootstrapper.Init(container);        

            container.RegisterControllers();

            return container;
        }
    }
}