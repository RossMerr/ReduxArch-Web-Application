using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Mvc;
using Redux.Web.Config;
using Redux.Web.Config.Modules;

namespace Redux.Web.UI
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : NinjectHttpApplication
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            AreaRegistration.RegisterAllAreas();

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = string.Empty } // Parameter defaults
            );

        }

        protected override void OnApplicationStarted()
        {
            EntitiesRegistration.RegisterAllEntities();
            RegisterRoutes(RouteTable.Routes);
            RegisterAllControllersIn(Assembly.GetExecutingAssembly());
            AutoMapperConfiguration.Configure();
        }

        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new DomainModule(), new ServiceModule());
        }
    }
}