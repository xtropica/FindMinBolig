using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(find_min_bolig.Startup))]
namespace find_min_bolig
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
