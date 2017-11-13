using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC_WEb_application.Startup))]
namespace MVC_WEb_application
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
