using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RestaurantPhase011.Startup))]
namespace RestaurantPhase011
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
