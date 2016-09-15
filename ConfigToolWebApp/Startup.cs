using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConfigToolWebApp.Startup))]
namespace ConfigToolWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
