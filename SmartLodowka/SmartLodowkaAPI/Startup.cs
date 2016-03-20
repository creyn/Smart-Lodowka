using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using SmartLodowkaAPI.Config;

[assembly: OwinStartup(typeof(SmartLodowkaAPI.Startup))]

namespace SmartLodowkaAPI
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=316888

            var config = new HttpConfiguration();

            // Register routes
            WebApiConfig.Register(config);

            // Want to use Web Api
            app.UseWebApi(config);
        }
    }
}
