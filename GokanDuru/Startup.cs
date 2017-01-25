using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GokanDuru.Startup))]
namespace GokanDuru
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
