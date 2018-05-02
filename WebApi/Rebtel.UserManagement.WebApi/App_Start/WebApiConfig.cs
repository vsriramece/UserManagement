using Rebtel.UserManagement.WebApi.Handlers;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace Rebtel.UserManagement.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API routes
            config.MapHttpAttributeRoutes();
            // Register WebAPIException  Handler to handle all unhandled exceptions.
            config.Services.Replace(typeof(IExceptionHandler), new WebAPIExceptionHandler());
        }
    }
}
