using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication26.Startup))]
namespace WebApplication26
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
