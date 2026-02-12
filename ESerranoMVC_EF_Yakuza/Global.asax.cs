using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using ESerranoMVC_EF_Yakuza.Models;

namespace ESerranoMVC_EF_Yakuza
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // added in Step 6: add the DBcontext initialising Strategy
            Database.SetInitializer(new YakuzaDbInitializer());

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
