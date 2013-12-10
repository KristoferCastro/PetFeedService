using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using Newtonsoft.Json.Serialization;
using NHibernate.Cfg;
using PetFeed.Models;

namespace PetFeed
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {  
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            //HttpConfiguration config = GlobalConfiguration.Configuration;
            //((DefaultContractResolver)config.Formatters.JsonFormatter.SerializerSettings.ContractResolver).IgnoreSerializableAttribute = true;
        }
    }
}