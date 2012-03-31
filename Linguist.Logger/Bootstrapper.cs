using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Unity;

namespace Linguist.Logger
{
    public class Bootstrapper
    {
        public static void Init(UnityContainer container)
        {
            container.RegisterType(typeof(ILogger), typeof(Log4NetLogger));
        }
    }
}
