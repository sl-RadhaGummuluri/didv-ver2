using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Did.APIs;
using System.ServiceModel.Activation;
using Microsoft.ApplicationServer.Http.Activation;
using Microsoft.ApplicationServer.Http;

namespace Did
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            var config = new HttpConfiguration() { EnableTestClient = true };

            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.Add(new ServiceRoute("api/clients", new HttpServiceHostFactory() { Configuration = config }, typeof(ClientsApi)));
            routes.Add(new ServiceRoute("api/data", new HttpServiceHostFactory(), typeof(DataApi)));

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}