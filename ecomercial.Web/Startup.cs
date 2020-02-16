using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ecomercial.Web.Startup))]
namespace ecomercial.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
