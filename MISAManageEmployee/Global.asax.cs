using MISAManageEmployee.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Routing;

namespace MISAManageEmployee
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configuration.EnableCors();
            System.Web.Http.GlobalConfiguration.Configuration.SetCorsPolicyProviderFactory(new CorsPolicyProviderFactory(new CustomCorsPolicyProvider()));
            GlobalConfiguration.Configure(WebApiConfig.Register);
        }
    }
}
