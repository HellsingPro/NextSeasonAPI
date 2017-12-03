using System.Web.Http;
using System.Web.Mvc;

namespace NS.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.ConfigureWebApi);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);

        }
    }
}
